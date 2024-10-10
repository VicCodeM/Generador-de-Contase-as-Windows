namespace GeneradordeContraseñas
{
    partial class FormPasswords
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
            this.dataGridViewPasswords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPasswords
            // 
            this.dataGridViewPasswords.AllowUserToAddRows = false;
            this.dataGridViewPasswords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.dataGridViewPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPasswords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPasswords.Name = "dataGridViewPasswords";
            this.dataGridViewPasswords.ReadOnly = true;
            this.dataGridViewPasswords.Size = new System.Drawing.Size(381, 299);
            this.dataGridViewPasswords.TabIndex = 0;
            // 
            // FormPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(381, 299);
            this.Controls.Add(this.dataGridViewPasswords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPasswords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPasswords";
            this.Load += new System.EventHandler(this.FormPasswords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasswords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPasswords;
    }
}