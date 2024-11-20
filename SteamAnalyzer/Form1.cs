using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.IO;

namespace SteamAnalyzer
{
    public partial class Form1 : Form
    {
        private List<GameInfo> m_games = new List<GameInfo>();
        private GameInfo? m_SelectedGame;

        public Form1()
        {
            InitializeComponent();

            btn_games.Enabled = false;
            btn_setUpdateMode.Enabled = false;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string installPath = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamPath", null);
            if (string.IsNullOrEmpty(installPath))
            {
                return;
            }

            lbl_steamFolder.Text = installPath;

            LoadLibs(installPath);
        }

        private void LoadLibs(string installPath)
        {
            lb_listPaths.Items.Clear();

            FileInfo finfo = new FileInfo(installPath + "/steamapps/libraryfolders.vdf");
            if (!finfo.Exists)
            {
                return;
            }

            TextReader reader = finfo.OpenText();

            Regex parts = new Regex(@"(""path"")(\s*)""([\w:\\\s\(\)]*)""");

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Match match = parts.Match(line);
                if (match.Success)
                {
                    string path = match.Groups[3].Value;

                    if (Directory.Exists(path + "\\steamapps"))
                    {
                        lb_listPaths.Items.Add(path);
                    }
                }
            }

            btn_games.Enabled = true;
        }

        private void btn_games_Click(object sender, EventArgs e)
        {
            loadGames();
        }

        private void loadGames()
        {
            lb_debug.Items.Clear();
            m_games.Clear();
            dataGames.Rows.Clear();

            if (lb_listPaths.SelectedItems.Count == 0)
            {  return; }

            string selectedItem = lb_listPaths.SelectedItems[0].ToString();

            if (string.IsNullOrEmpty(selectedItem))
            {
                return;
            }

            if (!Directory.Exists(selectedItem + "\\steamapps"))
            {
                return;
            }

            string[] files = Directory.GetFiles(selectedItem + "\\steamapps");
            foreach (string file in files)
            {
                if (file.EndsWith(".acf"))
                {
                    //lb_debug.Items.Add(file);
                    ParseGameACF(file);
                }
            }

            btn_setUpdateMode.Enabled = true;
        }

        private void ParseGameACF(string file)
        {

            GameInfo? game = GameInfo.CreateFromFile(file);

            if (game == null)
                { return; }

           // lb_debug.Items.Add(game.Name + " " + game.UpdateMode.ToString());
            dataGames.Rows.Add(game.Name, game.UpdateMode.ToString());
            m_games.Add(game);
        }

        private void dataGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0)
            { return; }
            //lb_debug.Items.Add(e.RowIndex);
            string name = dataGames.Rows[e.RowIndex].Cells[0].Value.ToString();
            string updateMode = dataGames.Rows[e.RowIndex].Cells[1].Value.ToString();
            lb_debug.Items.Add(name + " " + updateMode);
            SelectGame(name);
        }

        private void SelectGame(string name)
        {
            GameInfo game = m_games.Find(x => x.Name == name);
            lbl_game.Text = game.Name;
            combo_updateMode.SelectedIndex = game.UpdateMode;

            m_SelectedGame = game;
        }

        private void btn_setUpdateMode_Click(object sender, EventArgs e)
        {
            if (cb_all.Checked)
            {
                foreach (GameInfo game in m_games)
                {
                    game.SetUpdateMode(combo_updateMode.SelectedIndex);
                }
            }
            else
            {
                if (m_SelectedGame == null)
                { return; }

                m_SelectedGame.SetUpdateMode(combo_updateMode.SelectedIndex);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
