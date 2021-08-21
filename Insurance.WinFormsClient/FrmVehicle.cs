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
    public partial class FrmVehicle : Form
    {
        public FrmVehicle()
        {
            InitializeComponent();

            //
            //dgvVehicle.DataSource
            var vehicles = new FakeRepositories.FakeVehicleRepository().Get();
            dgvVehicle.DataSource = vehicles;
            
        }
    }
}
