namespace FightClubStatistics.UI.UserScene
{
    partial class UserUserControl
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
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.toMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(227, 20);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.Size = new System.Drawing.Size(764, 399);
            this.usersDataGrid.TabIndex = 0;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(21, 20);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(182, 40);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(21, 78);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(182, 40);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(21, 137);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(182, 40);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "DeleteUser";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // toMenuButton
            // 
            this.toMenuButton.Location = new System.Drawing.Point(21, 379);
            this.toMenuButton.Name = "toMenuButton";
            this.toMenuButton.Size = new System.Drawing.Size(182, 40);
            this.toMenuButton.TabIndex = 4;
            this.toMenuButton.Text = "Back to Menu";
            this.toMenuButton.UseVisualStyleBackColor = true;
            // 
            // UserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toMenuButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersDataGrid);
            this.Name = "UserUserControl";
            this.Size = new System.Drawing.Size(1020, 476);
            this.Load += new System.EventHandler(this.UserUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button toMenuButton;
    }
}
