
namespace Insurance.WinFormsClient
{
    partial class FrmVehicle
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
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Location = new System.Drawing.Point(298, 12);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.RowTemplate.Height = 25;
            this.dgvVehicle.Size = new System.Drawing.Size(490, 328);
            this.dgvVehicle.TabIndex = 0;
            // 
            // FrmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVehicle);
            this.Name = "FrmVehicle";
            this.Text = "FrmVehicle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicle;
    }
}