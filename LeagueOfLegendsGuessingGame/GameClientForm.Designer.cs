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
            this.label1 = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.winrateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.divisionPB)).BeginInit();
            this.SuspendLayout();
            // 
            // historyBtn
            // 
            this.historyBtn.Location = new System.Drawing.Point(64, 91);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(75, 23);
            this.historyBtn.TabIndex = 0;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(353, 66);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(99, 48);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "PLAY";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // rankedBtn
            // 
            this.rankedBtn.Location = new System.Drawing.Point(183, 91);
            this.rankedBtn.Name = "rankedBtn";
            this.rankedBtn.Size = new System.Drawing.Size(75, 23);
            this.rankedBtn.TabIndex = 2;
            this.rankedBtn.Text = "Ranked";
            this.rankedBtn.UseVisualStyleBackColor = true;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(584, 91);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(75, 23);
            this.optionsBtn.TabIndex = 3;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(680, 91);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // divisionPB
            // 
            this.divisionPB.Location = new System.Drawing.Point(77, 205);
            this.divisionPB.Name = "divisionPB";
            this.divisionPB.Size = new System.Drawing.Size(231, 197);
            this.divisionPB.TabIndex = 5;
            this.divisionPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "GAMES PLAYED:";
            // 
            // lossesLabel
            // 
            this.lossesLabel.AutoSize = true;
            this.lossesLabel.Location = new System.Drawing.Point(557, 299);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(52, 13);
            this.lossesLabel.TabIndex = 7;
            this.lossesLabel.Text = "LOSSES:";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(557, 270);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(39, 13);
            this.winsLabel.TabIndex = 8;
            this.winsLabel.Text = "WINS:";
            // 
            // winrateLabel
            // 
            this.winrateLabel.AutoSize = true;
            this.winrateLabel.Location = new System.Drawing.Point(557, 323);
            this.winrateLabel.Name = "winrateLabel";
            this.winrateLabel.Size = new System.Drawing.Size(61, 13);
            this.winrateLabel.TabIndex = 9;
            this.winrateLabel.Text = "WINRATE:";
            // 
            // GameClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 465);
            this.Controls.Add(this.winrateLabel);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.lossesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisionPB);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.rankedBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.historyBtn);
            this.Name = "GameClientForm";
            this.Text = "GameClient";
            ((System.ComponentModel.ISupportInitialize)(this.divisionPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button rankedBtn;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox divisionPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label winrateLabel;
    }
}