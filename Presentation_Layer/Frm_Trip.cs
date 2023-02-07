using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic_Layer;
using Entities;

namespace Presentation_Layer
{
    public partial class Frm_Trip : Form
    {
        public Frm_Trip()
        {
            InitializeComponent();
        }

        E_Trips Etrip = new();
        BL_Trip BLtrip = new();
        BL_Bus BLbus = new();
        BL_Driver BLdriver = new();
        BL_Route BLroute = new();

        private void ClearForm()
        {
            conductorIDTxt.Clear();
            autobusIDTxt.Clear();
            rutaIDTxt.Clear();
        }

        private void ShowRecord()
        {
            driversDGV.DataSource = BLdriver.DriversRecord("");
            busesDGV.DataSource = BLbus.BusesRecord("");
            routesDGV.DataSource = BLroute.RoutesRecord("");

        }

        private void Frm_Trip_Load(object sender, EventArgs e)
        {
            ShowRecord();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDTrip()
        {
            if (driversDGV.SelectedRows.Count > 0)
            {
                conductorIDTxt.Text = driversDGV.CurrentRow.Cells[0].Value.ToString();   
            }
        }

        private void addRTrip()
        {
            if (routesDGV.SelectedRows.Count > 0)
            {
                rutaIDTxt.Text = routesDGV.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void addBTrip()
        {         
            if (busesDGV.SelectedRows.Count > 0)
            {
                autobusIDTxt.Text = busesDGV.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void AddTrip()
        {
            if (conductorIDTxt.Text.Length == 0 || autobusIDTxt.Text.Length == 0 || rutaIDTxt.Text.Length == 0 )
            {
                MessageBox.Show("Los campos no deben estar vacio");
            }
            else
            {
                Etrip.DriverID = Convert.ToInt32(conductorIDTxt.Text);
                Etrip.BusID = Convert.ToInt32(autobusIDTxt.Text);
                Etrip.RouteID = Convert.ToInt32(rutaIDTxt.Text);

                BLtrip.InsertTrip(Etrip);
                ClearForm();
                ShowRecord();
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            AddTrip();
        }

        private void driversDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addDTrip();
        }

        private void busesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBTrip();
        }

        private void routesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addRTrip();
        }
    }
}
