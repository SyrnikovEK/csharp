namespace FightClubStatisticsPractice.UI.PlayerScene
{
    partial class PlayerEditControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerExpTextBox = new System.Windows.Forms.TextBox();
            this.playerExpLabel = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerExpTextBox
            // 
            this.playerExpTextBox.Location = new System.Drawing.Point(26, 112);
            this.playerExpTextBox.MaxLength = 50;
            this.playerExpTextBox.Name = "playerExpTextBox";
            this.playerExpTextBox.Size = new System.Drawing.Size(376, 20);
            this.playerExpTextBox.TabIndex = 26;
            this.playerExpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerExpTextBox_KeyPress);
            // 
            // playerExpLabel
            // 
            this.playerExpLabel.AutoSize = true;
            this.playerExpLabel.Location = new System.Drawing.Point(23, 87);
            this.playerExpLabel.Name = "playerExpLabel";
            this.playerExpLabel.Size = new System.Drawing.Size(75, 13);
            this.playerExpLabel.TabIndex = 25;
            this.playerExpLabel.Text = "Player Straight";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(26, 45);
            this.playerNameTextBox.MaxLength = 50;
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(376, 20);
            this.playerNameTextBox.TabIndex = 24;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(23, 20);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.playerNameLabel.TabIndex = 23;
            this.playerNameLabel.Text = "Player Name";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(26, 471);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(186, 48);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(246, 471);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(186, 48);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 175);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Player Stamina";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 237);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Player Agility";
            // 
            // PlayerEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerExpTextBox);
            this.Controls.Add(this.playerExpLabel);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "PlayerEditControl";
            this.Size = new System.Drawing.Size(466, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playerExpTextBox;
        private System.Windows.Forms.Label playerExpLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
