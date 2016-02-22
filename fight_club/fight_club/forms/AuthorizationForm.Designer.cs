namespace fight_club
{
    partial class AuthorizationForm
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
            this.EnterNameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CreationButton = new System.Windows.Forms.Button();
            this.PlaerNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterNameLabel
            // 
            this.EnterNameLabel.AutoSize = true;
            this.EnterNameLabel.Location = new System.Drawing.Point(23, 21);
            this.EnterNameLabel.Name = "EnterNameLabel";
            this.EnterNameLabel.Size = new System.Drawing.Size(99, 13);
            this.EnterNameLabel.TabIndex = 0;
            this.EnterNameLabel.Text = "Enter player\'s name";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(203, 89);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreationButton
            // 
            this.CreationButton.Location = new System.Drawing.Point(26, 89);
            this.CreationButton.Name = "CreationButton";
            this.CreationButton.Size = new System.Drawing.Size(75, 23);
            this.CreationButton.TabIndex = 2;
            this.CreationButton.Text = "Create new";
            this.CreationButton.UseVisualStyleBackColor = true;
            this.CreationButton.Click += new System.EventHandler(this.CreationButton_Click);
            // 
            // PlaerNameTextBox
            // 
            this.PlaerNameTextBox.Location = new System.Drawing.Point(26, 50);
            this.PlaerNameTextBox.MaxLength = 10;
            this.PlaerNameTextBox.Name = "PlaerNameTextBox";
            this.PlaerNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.PlaerNameTextBox.TabIndex = 3;
            this.PlaerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaerNameTextBox_KeyPress);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 137);
            this.Controls.Add(this.PlaerNameTextBox);
            this.Controls.Add(this.CreationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.EnterNameLabel);
            this.MaximumSize = new System.Drawing.Size(330, 175);
            this.MinimumSize = new System.Drawing.Size(330, 175);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthorizationForm_FormClosed);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterNameLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CreationButton;
        private System.Windows.Forms.TextBox PlaerNameTextBox;
    }
}