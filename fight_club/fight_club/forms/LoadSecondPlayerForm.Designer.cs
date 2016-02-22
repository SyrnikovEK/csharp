namespace fight_club
{
    partial class LoadSecondPlayerForm
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
            this.PlaerNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginSecondPlayerButton = new System.Windows.Forms.Button();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlaerNameTextBox
            // 
            this.PlaerNameTextBox.Location = new System.Drawing.Point(34, 53);
            this.PlaerNameTextBox.MaxLength = 10;
            this.PlaerNameTextBox.Name = "PlaerNameTextBox";
            this.PlaerNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.PlaerNameTextBox.TabIndex = 7;
            this.PlaerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaerNameTextBox_KeyPress);
            // 
            // LoginSecondPlayerButton
            // 
            this.LoginSecondPlayerButton.Location = new System.Drawing.Point(211, 92);
            this.LoginSecondPlayerButton.Name = "LoginSecondPlayerButton";
            this.LoginSecondPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.LoginSecondPlayerButton.TabIndex = 5;
            this.LoginSecondPlayerButton.Text = "Login";
            this.LoginSecondPlayerButton.UseVisualStyleBackColor = true;
            this.LoginSecondPlayerButton.Click += new System.EventHandler(this.LoginSecondPlayerButton_Click);
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(31, 24);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(99, 13);
            this.EnterNameLabel.TabIndex = 4;
            this.EnterNameLabel.Text = "Enter player\'s name";
            // 
            // LoadSecondPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 143);
            this.Controls.Add(this.PlaerNameTextBox);
            this.Controls.Add(this.LoginSecondPlayerButton);
            this.Controls.Add(this.EnterNameLabel);
            this.Name = "LoadSecondPlayerForm";
            this.Text = "LoadSecondPlayerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadSecondPlayerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaerNameTextBox;
        private System.Windows.Forms.Button LoginSecondPlayerButton;
        private System.Windows.Forms.Label EnterNameLabel;
    }
}