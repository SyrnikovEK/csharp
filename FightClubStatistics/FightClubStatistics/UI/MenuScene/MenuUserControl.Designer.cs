namespace FightClubStatistics.UI.MenuScene
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
            this.toUsersControl = new System.Windows.Forms.Button();
            this.toTransactionsControl = new System.Windows.Forms.Button();
            this.toCombatLogControl = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toUsersControl
            // 
            this.toUsersControl.Location = new System.Drawing.Point(48, 31);
            this.toUsersControl.Name = "toUsersControl";
            this.toUsersControl.Size = new System.Drawing.Size(269, 59);
            this.toUsersControl.TabIndex = 0;
            this.toUsersControl.Text = "Users";
            this.toUsersControl.UseVisualStyleBackColor = true;
            this.toUsersControl.Click += new System.EventHandler(this.toUsersControl_Click);
            // 
            // toTransactionsControl
            // 
            this.toTransactionsControl.Location = new System.Drawing.Point(48, 119);
            this.toTransactionsControl.Name = "toTransactionsControl";
            this.toTransactionsControl.Size = new System.Drawing.Size(269, 59);
            this.toTransactionsControl.TabIndex = 1;
            this.toTransactionsControl.Text = "Transactions";
            this.toTransactionsControl.UseVisualStyleBackColor = true;
            this.toTransactionsControl.Click += new System.EventHandler(this.toTransactionsControl_Click);
            // 
            // toCombatLogControl
            // 
            this.toCombatLogControl.Location = new System.Drawing.Point(48, 210);
            this.toCombatLogControl.Name = "toCombatLogControl";
            this.toCombatLogControl.Size = new System.Drawing.Size(269, 59);
            this.toCombatLogControl.TabIndex = 2;
            this.toCombatLogControl.Text = "Combat logs";
            this.toCombatLogControl.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(48, 447);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(269, 59);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.toCombatLogControl);
            this.Controls.Add(this.toTransactionsControl);
            this.Controls.Add(this.toUsersControl);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(365, 568);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toUsersControl;
        private System.Windows.Forms.Button toTransactionsControl;
        private System.Windows.Forms.Button toCombatLogControl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button exitButton;
    }
}
