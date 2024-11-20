using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SteamAnalyzer
{
    internal class GameInfo
    {
        public static GameInfo? CreateFromFile(string file)
        {
            GameInfo gameInfo = new GameInfo();

            FileInfo finfo = new FileInfo(file);
            if (!finfo.Exists)
            {
                return null;
            }

            gameInfo.File = file;

            TextReader reader = finfo.OpenText();

            Regex gameName = new Regex(@"(""name"")(\s*)""(.*)""");
            Regex UpdateBehavior = new Regex(@"(""AutoUpdateBehavior"")(\s*)""([\d]*)""");

            string GameTitle = "";
            string UpdateMode = "";

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Match matchName = gameName.Match(line);
                if (matchName.Success)
                {
                    GameTitle = matchName.Groups[3].Value;
                }
                Match matchUpdateBehavior = UpdateBehavior.Match(line);
                if (matchUpdateBehavior.Success)
                {
                    UpdateMode = matchUpdateBehavior.Groups[3].Value;
                }
            }

            if (string.IsNullOrEmpty(GameTitle))
            {
                return null;
            }

            gameInfo.Name = GameTitle;
            int updateModeInt;   
            if (int.TryParse(UpdateMode, out updateModeInt))
            {
                gameInfo.UpdateMode = updateModeInt;
               return gameInfo;
            }

            return null;
        }

        public void SetUpdateMode(int value)
        {
            FileInfo finfo = new FileInfo(File);
            if (!finfo.Exists)
            {
                return;
            }

            StreamReader reader = new StreamReader(File);
            string content = reader.ReadToEnd();
            reader.Close();

            Regex UpdateBehavior = new Regex(@"(""AutoUpdateBehavior"")(\s*)(""\d"")"); 

            Match match = UpdateBehavior.Match(content);
            if (match.Success)
            {
                string content2 = UpdateBehavior.Replace(content, m => m.Groups[1].Value + m.Groups[2].Value + "\"" + value.ToString() + "\"");
                string UpdateMode = "";

                try
                {
                    StreamWriter writer = new StreamWriter(File);
                    writer.Write(content2);
                    writer.Close();
                }
                catch (Exception ex) { }
            }
        }

        public GameInfo() { }
        public string Name { get; set; }
        public string File { get; set; }
        public int UpdateMode { get; set; }
    }
}
