namespace LeagueOfLegendsGuessingGame
{
    partial class GameForm
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
            this.qPictureBox = new System.Windows.Forms.PictureBox();
            this.wPictureBox = new System.Windows.Forms.PictureBox();
            this.ePictureBox = new System.Windows.Forms.PictureBox();
            this.rPictureBox = new System.Windows.Forms.PictureBox();
            this.guessingField = new System.Windows.Forms.TextBox();
            this.guessingBtn = new System.Windows.Forms.Button();
            this.guessingResponse = new System.Windows.Forms.Label();
            this.skipBtn = new System.Windows.Forms.Button();
            this.divisionTextLabel = new System.Windows.Forms.Label();
            this.divisionLabel = new System.Windows.Forms.Label();
            this.SeriesLabel = new System.Windows.Forms.Label();
            this.SeriesResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qPictureBox
            // 
            this.qPictureBox.Location = new System.Drawing.Point(52, 228);
            this.qPictureBox.Name = "qPictureBox";
            this.qPictureBox.Size = new System.Drawing.Size(166, 145);
            this.qPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qPictureBox.TabIndex = 0;
            this.qPictureBox.TabStop = false;
            // 
            // wPictureBox
            // 
            this.wPictureBox.Location = new System.Drawing.Point(243, 228);
            this.wPictureBox.Name = "wPictureBox";
            this.wPictureBox.Size = new System.Drawing.Size(166, 145);
            this.wPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wPictureBox.TabIndex = 1;
            this.wPictureBox.TabStop = false;
            // 
            // ePictureBox
            // 
            this.ePictureBox.Location = new System.Drawing.Point(428, 228);
            this.ePictureBox.Name = "ePictureBox";
            this.ePictureBox.Size = new System.Drawing.Size(166, 145);
            this.ePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ePictureBox.TabIndex = 2;
            this.ePictureBox.TabStop = false;
            // 
            // rPictureBox
            // 
            this.rPictureBox.Location = new System.Drawing.Point(613, 228);
            this.rPictureBox.Name = "rPictureBox";
            this.rPictureBox.Size = new System.Drawing.Size(166, 145);
            this.rPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rPictureBox.TabIndex = 3;
            this.rPictureBox.TabStop = false;
            // 
            // guessingField
            // 
            this.guessingField.Location = new System.Drawing.Point(462, 52);
            this.guessingField.Name = "guessingField";
            this.guessingField.Size = new System.Drawing.Size(176, 20);
            this.guessingField.TabIndex = 4;
            // 
            // guessingBtn
            // 
            this.guessingBtn.Location = new System.Drawing.Point(644, 49);
            this.guessingBtn.Name = "guessingBtn";
            this.guessingBtn.Size = new System.Drawing.Size(75, 23);
            this.guessingBtn.TabIndex = 5;
            this.guessingBtn.Text = "Guess";
            this.guessingBtn.UseVisualStyleBackColor = true;
            this.guessingBtn.Click += new System.EventHandler(this.guessingBtn_Click);
            // 
            // guessingResponse
            // 
            this.guessingResponse.AutoSize = true;
            this.guessingResponse.BackColor = System.Drawing.SystemColors.Control;
            this.guessingResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessingResponse.Location = new System.Drawing.Point(363, 383);
            this.guessingResponse.Name = "guessingResponse";
            this.guessingResponse.Size = new System.Drawing.Size(0, 25);
            this.guessingResponse.TabIndex = 6;
            // 
            // skipBtn
            // 
            this.skipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipBtn.Location = new System.Drawing.Point(662, 442);
            this.skipBtn.Name = "skipBtn";
            this.skipBtn.Size = new System.Drawing.Size(172, 55);
            this.skipBtn.TabIndex = 7;
            this.skipBtn.Text = "SKIP ( - 20 LP )";
            this.skipBtn.UseVisualStyleBackColor = true;
            this.skipBtn.Click += new System.EventHandler(this.skipBtn_Click);
            // 
            // divisionTextLabel
            // 
            this.divisionTextLabel.AutoSize = true;
            this.divisionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionTextLabel.Location = new System.Drawing.Point(48, 47);
            this.divisionTextLabel.Name = "divisionTextLabel";
            this.divisionTextLabel.Size = new System.Drawing.Size(95, 24);
            this.divisionTextLabel.TabIndex = 8;
            this.divisionTextLabel.Text = "Division: ";
            // 
            // divisionLabel
            // 
            this.divisionLabel.AutoSize = true;
            this.divisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionLabel.Location = new System.Drawing.Point(138, 48);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(0, 24);
            this.divisionLabel.TabIndex = 9;
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.AutoSize = true;
            this.SeriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesLabel.Location = new System.Drawing.Point(286, 145);
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Size = new System.Drawing.Size(0, 24);
            this.SeriesLabel.TabIndex = 11;
            // 
            // SeriesResult
            // 
            this.SeriesResult.AutoSize = true;
            this.SeriesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesResult.Location = new System.Drawing.Point(196, 144);
            this.SeriesResult.Name = "SeriesResult";
            this.SeriesResult.Size = new System.Drawing.Size(75, 24);
            this.SeriesResult.TabIndex = 10;
            this.SeriesResult.Text = "Series:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 519);
            this.Controls.Add(this.SeriesLabel);
            this.Controls.Add(this.SeriesResult);
            this.Controls.Add(this.divisionLabel);
            this.Controls.Add(this.divisionTextLabel);
            this.Controls.Add(this.skipBtn);
            this.Controls.Add(this.guessingResponse);
            this.Controls.Add(this.guessingBtn);
            this.Controls.Add(this.guessingField);
            this.Controls.Add(this.rPictureBox);
            this.Controls.Add(this.ePictureBox);
            this.Controls.Add(this.wPictureBox);
            this.Controls.Add(this.qPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.qPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qPictureBox;
        private System.Windows.Forms.PictureBox wPictureBox;
        private System.Windows.Forms.PictureBox ePictureBox;
        private System.Windows.Forms.PictureBox rPictureBox;
        private System.Windows.Forms.TextBox guessingField;
        private System.Windows.Forms.Button guessingBtn;
        private System.Windows.Forms.Label guessingResponse;
        private System.Windows.Forms.Button skipBtn;
        private System.Windows.Forms.Label divisionTextLabel;
        private System.Windows.Forms.Label divisionLabel;
        private System.Windows.Forms.Label SeriesLabel;
        private System.Windows.Forms.Label SeriesResult;
    }
}

