using Insurance.EFRepositories;
using Insurance.FakeRepositories;
using Insurance.IRepositories;
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
    public partial class FrmCustomers : Form
    {
        private ICustomerRepository customerRepository;
        public FrmCustomers()
        {
            InitializeComponent();
            //customerRepository = new FakeCustomerRepository();
            customerRepository = new DbCustomerRepository(new InsuranceContext());
            RefreshCustomerList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer(customerRepository);
            frmCustomer.ShowDialog();
            if (frmCustomer.DialogResult==DialogResult.OK)
            {
                RefreshCustomerList();
            }
        }

        private void RefreshCustomerList()
        {
            bindingSource1.DataSource = customerRepository.Get();
            dgvCustomers.DataSource = bindingSource1;
            bindingSource1.ResetBindings(false);
            //dgvCustomers.Refresh();
            //dgvCustomers.Update();

        }
    }
}
