using Insurance.FakeRepositories;
using Insurance.IRepositories;
using Insurance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance.WinFormsClient
{
    public partial class FrmCustomer : Form
    {
        private ICustomerRepository customerRepository;

        public FrmCustomer()
        {
            InitializeComponent();
        }
        
        public FrmCustomer(ICustomerRepository customerRepository) : this()
        {
            this.customerRepository = customerRepository;
        }

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Customer customer = new Customer() { FirstName = txtFirstName.Text, LastName = txtLastName.Text, Pesel = txtPesel.Text };
                if (String.IsNullOrEmpty(customer.Error))
                {
                    customerRepository.Add(customer);
                }
                
            }
        }
    }
}
