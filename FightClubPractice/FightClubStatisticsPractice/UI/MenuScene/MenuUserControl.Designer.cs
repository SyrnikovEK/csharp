namespace FightClubStatisticsPractice.UI.MenuScene
{
    partial class MenuUserControl
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
            this.exitButton = new System.Windows.Forms.Button();
            this.toCombatLogControl = new System.Windows.Forms.Button();
            this.toUsersControl = new System.Windows.Forms.Button();
            this.toHitLogControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(23, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(269, 59);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // toCombatLogControl
            // 
            this.toCombatLogControl.Location = new System.Drawing.Point(23, 121);
            this.toCombatLogControl.Name = "toCombatLogControl";
            this.toCombatLogControl.Size = new System.Drawing.Size(269, 59);
            this.toCombatLogControl.TabIndex = 7;
            this.toCombatLogControl.Text = "Combat logs";
            this.toCombatLogControl.UseVisualStyleBackColor = true;
            this.toCombatLogControl.Click += new System.EventHandler(this.toCombatLogControl_Click);
            // 
            // toUsersControl
            // 
            this.toUsersControl.Location = new System.Drawing.Point(23, 28);
            this.toUsersControl.Name = "toUsersControl";
            this.toUsersControl.Size = new System.Drawing.Size(269, 59);
            this.toUsersControl.TabIndex = 5;
            this.toUsersControl.Text = "Users";
            this.toUsersControl.UseVisualStyleBackColor = true;
            this.toUsersControl.Click += new System.EventHandler(this.toUsersControl_Click);
            // 
            // toHitLogControl
            // 
            this.toHitLogControl.Location = new System.Drawing.Point(23, 209);
            this.toHitLogControl.Name = "toHitLogControl";
            this.toHitLogControl.Size = new System.Drawing.Size(269, 59);
            this.toHitLogControl.TabIndex = 9;
            this.toHitLogControl.Text = "HitLogs";
            this.toHitLogControl.UseVisualStyleBackColor = true;
            this.toHitLogControl.Click += new System.EventHandler(this.toHitLogControl_Click);
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toHitLogControl);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.toCombatLogControl);
            this.Controls.Add(this.toUsersControl);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(320, 554);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button toCombatLogControl;
        private System.Windows.Forms.Button toUsersControl;
        private System.Windows.Forms.Button toHitLogControl;
    }
}
