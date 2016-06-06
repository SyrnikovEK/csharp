namespace FightClubStatisticsPractice.UI.CombatLogScene
{
    partial class CombatLogUserControl
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toMenuButton
            // 
            this.toMenuButton.Location = new System.Drawing.Point(14, 400);
            this.toMenuButton.Name = "toMenuButton";
            this.toMenuButton.Size = new System.Drawing.Size(216, 40);
            this.toMenuButton.TabIndex = 17;
            this.toMenuButton.Text = "Back to Menu";
            this.toMenuButton.UseVisualStyleBackColor = true;
            this.toMenuButton.Click += new System.EventHandler(this.toMenuButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(14, 13);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(216, 40);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "To HitLogs";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToOrderColumns = true;
            this.usersDataGrid.AllowUserToResizeRows = false;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usersDataGrid.Location = new System.Drawing.Point(257, 13);
            this.usersDataGrid.MultiSelect = false;
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.Size = new System.Drawing.Size(764, 427);
            this.usersDataGrid.TabIndex = 13;
            // 
            // CombatLogUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toMenuButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersDataGrid);
            this.Name = "CombatLogUserControl";
            this.Size = new System.Drawing.Size(1056, 460);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toMenuButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView usersDataGrid;
    }
}
