namespace FightClubPractice.UI.AutorizationScene
{
    partial class AutorizationUserControl
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
            this.PlaerNameTextBox = new System.Windows.Forms.TextBox();
            this.CreationButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlaerNameTextBox
            // 
            this.PlaerNameTextBox.Location = new System.Drawing.Point(22, 48);
            this.PlaerNameTextBox.MaxLength = 10;
            this.PlaerNameTextBox.Name = "PlaerNameTextBox";
            this.PlaerNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.PlaerNameTextBox.TabIndex = 11;
            // 
            // CreationButton
            // 
            this.CreationButton.Location = new System.Drawing.Point(22, 87);
            this.CreationButton.Name = "CreationButton";
            this.CreationButton.Size = new System.Drawing.Size(75, 23);
            this.CreationButton.TabIndex = 10;
            this.CreationButton.Text = "Create new";
            this.CreationButton.UseVisualStyleBackColor = true;
            this.CreationButton.Click += new System.EventHandler(this.CreationButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(199, 87);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(19, 19);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(99, 13);
            this.EnterNameLabel.TabIndex = 8;
            this.EnterNameLabel.Text = "Enter player\'s name";
            // 
            // AutorizationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlaerNameTextBox);
            this.Controls.Add(this.CreationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.EnterNameLabel);
            this.Name = "AutorizationUserControl";
            this.Size = new System.Drawing.Size(307, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaerNameTextBox;
        private System.Windows.Forms.Button CreationButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label EnterNameLabel;
    }
}
