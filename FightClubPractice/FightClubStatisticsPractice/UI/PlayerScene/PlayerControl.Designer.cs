namespace FightClubStatisticsPractice.UI.PlayerScene
{
    partial class PlayerControl
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
            this.toMenuButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toMenuButton
            // 
            this.toMenuButton.Location = new System.Drawing.Point(17, 405);
            this.toMenuButton.Name = "toMenuButton";
            this.toMenuButton.Size = new System.Drawing.Size(216, 40);
            this.toMenuButton.TabIndex = 12;
            this.toMenuButton.Text = "Back to Menu";
            this.toMenuButton.UseVisualStyleBackColor = true;
            this.toMenuButton.Click += new System.EventHandler(this.toMenuButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(17, 135);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(216, 40);
            this.deleteUserButton.TabIndex = 11;
            this.deleteUserButton.Text = "DeleteUser";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(17, 76);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(216, 40);
            this.editUserButton.TabIndex = 10;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(17, 18);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(216, 40);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToOrderColumns = true;
            this.usersDataGrid.AllowUserToResizeRows = false;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usersDataGrid.Location = new System.Drawing.Point(260, 18);
            this.usersDataGrid.MultiSelect = false;
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.Size = new System.Drawing.Size(764, 427);
            this.usersDataGrid.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "To Combat Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toMenuButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersDataGrid);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(1042, 466);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button toMenuButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Button button1;
    }
}
