
namespace Insurance.WinFormsClient
{
    partial class FrmCustomers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(293, 24);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(495, 352);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(293, 401);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(230, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(562, 401);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(225, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "FrmCustomers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

