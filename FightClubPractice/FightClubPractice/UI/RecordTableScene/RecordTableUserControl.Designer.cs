namespace FightClubPractice.UI.RecordTableScene
{
    partial class RecordTableUserControl
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
            this.components = new System.ComponentModel.Container();
            this.RecordTable = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ToMenu = new System.Windows.Forms.Button();
            this.playersDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordTable
            // 
            this.RecordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordTable.Location = new System.Drawing.Point(13, 97);
            this.RecordTable.Name = "RecordTable";
            this.RecordTable.Size = new System.Drawing.Size(835, 262);
            this.RecordTable.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(323, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(229, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "In Progress";
            // 
            // ToMenu
            // 
            this.ToMenu.Location = new System.Drawing.Point(13, 17);
            this.ToMenu.Name = "ToMenu";
            this.ToMenu.Size = new System.Drawing.Size(75, 23);
            this.ToMenu.TabIndex = 9;
            this.ToMenu.Text = "Back";
            this.ToMenu.UseVisualStyleBackColor = true;
            this.ToMenu.Click += new System.EventHandler(this.ToMenu_Click);
            // 
            // RecordTableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RecordTable);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToMenu);
            this.Name = "RecordTableUserControl";
            this.Size = new System.Drawing.Size(866, 402);
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource playersDBBindingSource;
        private System.Windows.Forms.DataGridView RecordTable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource playerRepositoryBindingSource;
        private System.Windows.Forms.Button ToMenu;
    }
}
