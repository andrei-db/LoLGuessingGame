namespace LeagueOfLegendsGuessingGame
{
    partial class GameClientForm
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
            this.historyBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.rankedBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.divisionPB = new System.Windows.Forms.PictureBox();
            this.gamesPlayedLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.winrateLabel = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.historyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.divisionPB)).BeginInit();
            this.homePanel.SuspendLayout();
            this.historyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // historyBtn
            // 
            this.historyBtn.Location = new System.Drawing.Point(170, 37);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(75, 23);
            this.historyBtn.TabIndex = 0;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(353, 12);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(99, 48);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // rankedBtn
            // 
            this.rankedBtn.Location = new System.Drawing.Point(263, 37);
            this.rankedBtn.Name = "rankedBtn";
            this.rankedBtn.Size = new System.Drawing.Size(75, 23);
            this.rankedBtn.TabIndex = 2;
            this.rankedBtn.Text = "Ranked";
            this.rankedBtn.UseVisualStyleBackColor = true;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(584, 37);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(75, 23);
            this.optionsBtn.TabIndex = 3;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(680, 37);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // divisionPB
            // 
            this.divisionPB.Location = new System.Drawing.Point(100, 80);
            this.divisionPB.Name = "divisionPB";
            this.divisionPB.Size = new System.Drawing.Size(231, 197);
            this.divisionPB.TabIndex = 5;
            this.divisionPB.TabStop = false;
            this.divisionPB.Click += new System.EventHandler(this.divisionPB_Click);
            // 
            // gamesPlayedLabel
            // 
            this.gamesPlayedLabel.AutoSize = true;
            this.gamesPlayedLabel.Location = new System.Drawing.Point(580, 117);
            this.gamesPlayedLabel.Name = "gamesPlayedLabel";
            this.gamesPlayedLabel.Size = new System.Drawing.Size(93, 13);
            this.gamesPlayedLabel.TabIndex = 6;
            this.gamesPlayedLabel.Text = "GAMES PLAYED:";
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Location = new System.Drawing.Point(580, 174);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(52, 13);
            this.lossesLabel.TabIndex = 7;
            this.lossesLabel.Text = "LOSSES:";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(580, 145);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(39, 13);
            this.winsLabel.TabIndex = 8;
            this.winsLabel.Text = "WINS:";
            // 
            // winrateLabel
            // 
            this.winrateLabel.AutoSize = true;
            this.winrateLabel.Location = new System.Drawing.Point(580, 198);
            this.winrateLabel.Name = "winrateLabel";
            this.winrateLabel.Size = new System.Drawing.Size(61, 13);
            this.winrateLabel.TabIndex = 9;
            this.winrateLabel.Text = "WINRATE:";
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(66, 37);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 11;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.historyPanel);
            this.homePanel.Controls.Add(this.divisionPB);
            this.homePanel.Controls.Add(this.gamesPlayedLabel);
            this.homePanel.Controls.Add(this.winrateLabel);
            this.homePanel.Controls.Add(this.lossesLabel);
            this.homePanel.Controls.Add(this.winsLabel);
            this.homePanel.Location = new System.Drawing.Point(1, 81);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(810, 388);
            this.homePanel.TabIndex = 12;
            // 
            // historyPanel
            // 
            this.historyPanel.Controls.Add(this.historyGrid);
            this.historyPanel.Location = new System.Drawing.Point(0, 0);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(810, 385);
            this.historyPanel.TabIndex = 10;
            // 
            // historyGrid
            // 
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Location = new System.Drawing.Point(31, 32);
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.Size = new System.Drawing.Size(743, 324);
            this.historyGrid.TabIndex = 0;
            // 
            // GameClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 465);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.rankedBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.homePanel);
            this.Name = "GameClientForm";
            this.Text = "GameClient";
            ((System.ComponentModel.ISupportInitialize)(this.divisionPB)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button rankedBtn;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox divisionPB;
        private System.Windows.Forms.Label gamesPlayedLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label winrateLabel;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.DataGridView historyGrid;
    }
}