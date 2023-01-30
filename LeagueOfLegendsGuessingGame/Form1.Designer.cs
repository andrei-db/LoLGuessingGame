namespace LeagueOfLegendsGuessingGame
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
            this.qPictureBox = new System.Windows.Forms.PictureBox();
            this.wPictureBox = new System.Windows.Forms.PictureBox();
            this.ePictureBox = new System.Windows.Forms.PictureBox();
            this.rPictureBox = new System.Windows.Forms.PictureBox();
            this.guessingField = new System.Windows.Forms.TextBox();
            this.guessingBtn = new System.Windows.Forms.Button();
            this.guessingResponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qPictureBox
            // 
            this.qPictureBox.Location = new System.Drawing.Point(39, 124);
            this.qPictureBox.Name = "qPictureBox";
            this.qPictureBox.Size = new System.Drawing.Size(166, 145);
            this.qPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qPictureBox.TabIndex = 0;
            this.qPictureBox.TabStop = false;
            // 
            // wPictureBox
            // 
            this.wPictureBox.Location = new System.Drawing.Point(230, 124);
            this.wPictureBox.Name = "wPictureBox";
            this.wPictureBox.Size = new System.Drawing.Size(166, 145);
            this.wPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wPictureBox.TabIndex = 1;
            this.wPictureBox.TabStop = false;
            // 
            // ePictureBox
            // 
            this.ePictureBox.Location = new System.Drawing.Point(415, 124);
            this.ePictureBox.Name = "ePictureBox";
            this.ePictureBox.Size = new System.Drawing.Size(166, 145);
            this.ePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ePictureBox.TabIndex = 2;
            this.ePictureBox.TabStop = false;
            // 
            // rPictureBox
            // 
            this.rPictureBox.Location = new System.Drawing.Point(600, 124);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 519);
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
    }
}

