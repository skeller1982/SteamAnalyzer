namespace SteamAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_steamFolder = new System.Windows.Forms.Label();
            this.lb_listPaths = new System.Windows.Forms.ListBox();
            this.btn_games = new System.Windows.Forms.Button();
            this.lb_debug = new System.Windows.Forms.ListBox();
            this.dataGames = new System.Windows.Forms.DataGridView();
            this.GameName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_updateMode = new System.Windows.Forms.ComboBox();
            this.btn_setUpdateMode = new System.Windows.Forms.Button();
            this.lbl_game = new System.Windows.Forms.Label();
            this.cb_all = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGames)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Steam App Folder:";
            // 
            // lbl_steamFolder
            // 
            this.lbl_steamFolder.AutoSize = true;
            this.lbl_steamFolder.Location = new System.Drawing.Point(194, 17);
            this.lbl_steamFolder.Name = "lbl_steamFolder";
            this.lbl_steamFolder.Size = new System.Drawing.Size(67, 13);
            this.lbl_steamFolder.TabIndex = 2;
            this.lbl_steamFolder.Text = "\"not loaded\"";
            // 
            // lb_listPaths
            // 
            this.lb_listPaths.FormattingEnabled = true;
            this.lb_listPaths.Location = new System.Drawing.Point(12, 50);
            this.lb_listPaths.Name = "lb_listPaths";
            this.lb_listPaths.Size = new System.Drawing.Size(240, 147);
            this.lb_listPaths.TabIndex = 3;
            // 
            // btn_games
            // 
            this.btn_games.Location = new System.Drawing.Point(12, 203);
            this.btn_games.Name = "btn_games";
            this.btn_games.Size = new System.Drawing.Size(106, 29);
            this.btn_games.TabIndex = 4;
            this.btn_games.Text = "load Games";
            this.btn_games.UseVisualStyleBackColor = true;
            this.btn_games.Click += new System.EventHandler(this.btn_games_Click);
            // 
            // lb_debug
            // 
            this.lb_debug.FormattingEnabled = true;
            this.lb_debug.Location = new System.Drawing.Point(258, 50);
            this.lb_debug.Name = "lb_debug";
            this.lb_debug.Size = new System.Drawing.Size(18, 303);
            this.lb_debug.TabIndex = 5;
            this.lb_debug.Visible = false;
            // 
            // dataGames
            // 
            this.dataGames.AllowUserToAddRows = false;
            this.dataGames.AllowUserToDeleteRows = false;
            this.dataGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameName2,
            this.UpdateMode});
            this.dataGames.Location = new System.Drawing.Point(282, 50);
            this.dataGames.Name = "dataGames";
            this.dataGames.ReadOnly = true;
            this.dataGames.Size = new System.Drawing.Size(480, 303);
            this.dataGames.TabIndex = 6;
            this.dataGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGames_CellContentClick);
            // 
            // GameName2
            // 
            this.GameName2.HeaderText = "Name";
            this.GameName2.Name = "GameName2";
            this.GameName2.ReadOnly = true;
            this.GameName2.Width = 250;
            // 
            // UpdateMode
            // 
            this.UpdateMode.HeaderText = "UpdateMode";
            this.UpdateMode.Name = "UpdateMode";
            this.UpdateMode.ReadOnly = true;
            this.UpdateMode.Width = 70;
            // 
            // combo_updateMode
            // 
            this.combo_updateMode.FormattingEnabled = true;
            this.combo_updateMode.Items.AddRange(new object[] {
            "0 (default)",
            "1 (none)",
            "2 (prio)"});
            this.combo_updateMode.Location = new System.Drawing.Point(612, 370);
            this.combo_updateMode.Name = "combo_updateMode";
            this.combo_updateMode.Size = new System.Drawing.Size(150, 21);
            this.combo_updateMode.TabIndex = 7;
            // 
            // btn_setUpdateMode
            // 
            this.btn_setUpdateMode.Location = new System.Drawing.Point(615, 397);
            this.btn_setUpdateMode.Name = "btn_setUpdateMode";
            this.btn_setUpdateMode.Size = new System.Drawing.Size(147, 22);
            this.btn_setUpdateMode.TabIndex = 8;
            this.btn_setUpdateMode.Text = "Set UpdateMode";
            this.btn_setUpdateMode.UseVisualStyleBackColor = true;
            this.btn_setUpdateMode.Click += new System.EventHandler(this.btn_setUpdateMode_Click);
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.Location = new System.Drawing.Point(393, 373);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(76, 13);
            this.lbl_game.TabIndex = 9;
            this.lbl_game.Text = "selected game";
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Location = new System.Drawing.Point(529, 397);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(53, 17);
            this.cb_all.TabIndex = 10;
            this.cb_all.Text = "set all";
            this.cb_all.UseVisualStyleBackColor = true;
            this.cb_all.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 448);
            this.Controls.Add(this.cb_all);
            this.Controls.Add(this.lbl_game);
            this.Controls.Add(this.btn_setUpdateMode);
            this.Controls.Add(this.combo_updateMode);
            this.Controls.Add(this.dataGames);
            this.Controls.Add(this.lb_debug);
            this.Controls.Add(this.btn_games);
            this.Controls.Add(this.lb_listPaths);
            this.Controls.Add(this.lbl_steamFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_load);
            this.Name = "Form1";
            this.Text = "SteamAnalyzer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_steamFolder;
        private System.Windows.Forms.ListBox lb_listPaths;
        private System.Windows.Forms.Button btn_games;
        private System.Windows.Forms.ListBox lb_debug;
        private System.Windows.Forms.DataGridView dataGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.ComboBox combo_updateMode;
        private System.Windows.Forms.Button btn_setUpdateMode;
        private System.Windows.Forms.Label lbl_game;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateMode;
        private System.Windows.Forms.CheckBox cb_all;
    }
}

