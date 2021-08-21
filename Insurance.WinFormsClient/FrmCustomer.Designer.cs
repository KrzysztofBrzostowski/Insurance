
namespace Insurance.WinFormsClient
{
    partial class FrmCustomer
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(459, 159);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(201, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(264, 159);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(139, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Podaj imię";
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(264, 204);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Podaj nazwisko";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(459, 203);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(459, 252);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(201, 23);
            this.txtPesel.TabIndex = 5;
            // 
            // lblPesel
            // 
            this.lblPesel.Location = new System.Drawing.Point(264, 253);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(100, 23);
            this.lblPesel.TabIndex = 4;
            this.lblPesel.Text = "Podaj pesel";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(328, 324);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(525, 324);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // FrmCustomer
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnuluj;
    }
}