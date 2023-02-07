using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic_Layer;

namespace Presentation_Layer
{
    public partial class Frm_Route : Form
    {
        public Frm_Route()
        {
            InitializeComponent();
        }

        E_Routes Eroute = new();
        BL_Route BLroute = new();

        private void ShowRoutes(string search)
        {
            routesDGV.DataSource = BLroute.RoutesRecord(search);
        }

        private void ClearForm()
        {
            codigoTxt.Clear(); 
            origenTxt.Clear();
            destinoTxt.Clear();
            precioTxt.Clear();
        }

        private void AddRoute()
        {
            if( origenTxt.Text.Length == 0 || destinoTxt.Text.Length == 0 || precioTxt.Text.Length == 0)
            {
                MessageBox.Show("Debes llenar todos los campos");                
            }
            else
            {
                Eroute.Origin = origenTxt.Text;
                Eroute.Destination = destinoTxt.Text;
                Eroute.Price = Convert.ToInt32(precioTxt.Text);
                
                BLroute.InsertRoute(Eroute);
                ClearForm();
                ShowRoutes("");
            }
        }

        private void editRoute()
        {
            if (routesDGV.SelectedRows.Count > 0)
            {
                codigoTxt.Text = routesDGV.CurrentRow.Cells[1].Value.ToString();
                origenTxt.Text = routesDGV.CurrentRow.Cells[2].Value.ToString();
                destinoTxt.Text = routesDGV.CurrentRow.Cells[3].Value.ToString();
                precioTxt.Text = routesDGV.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void EditRoute()
        {
            if (precioTxt.Text.Length == 0)
            {
                MessageBox.Show("Los campos no deben estar vacio");
            }
            else
            {
                Eroute.RouteCode = codigoTxt.Text;
                Eroute.Price = Convert.ToInt32(precioTxt.Text);

                BLroute.UpdateRoute(Eroute);
                ClearForm();
                ShowRoutes("");
            }
        }

        private void Frm_Route_Load(object sender, EventArgs e)
        {
            ShowRoutes("");
        }

        private void ShowHideField()
        {
            if (editCbx.Checked)
            {
                codigoLbl.Visible = true;
                codigoPBx.Visible = true;
                codigoTxt.Visible = true;
                editBTN.Visible = true;
                codigoTxt.ReadOnly = true;

                origenTxt.ReadOnly = true;
                destinoTxt.ReadOnly = true;

                addBTN.Visible = false;                          
            }
            else if (!editCbx.Checked)
            {
                codigoLbl.Visible = false;
                codigoPBx.Visible = false;
                codigoTxt.Visible = false;
                editBTN.Visible = false;

                origenTxt.ReadOnly = false;
                destinoTxt.ReadOnly = false;

                addBTN.Visible = true;
            }

            ClearForm();
        }

        private void DelRoute()
        {

            if (routesDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Eroute.RouteCode = routesDGV.CurrentRow.Cells[1].Value.ToString();
                    BLroute.DeleteRoute(Eroute);
                    if (codigoTxt.Text == routesDGV.CurrentRow.Cells[1].Value.ToString())
                    {
                        ClearForm();
                    }
                    ShowRoutes("");
                }

            }
            else
            {
                MessageBox.Show("Debes selecionar una fila para eliminar");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            AddRoute();

        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            EditRoute();    
        }

        private void editCbx_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideField();
        }

        private void routesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (editCbx.Checked)
            {
                editRoute();
            }
        }

        private void delRouteBtn_Click(object sender, EventArgs e)
        {
            DelRoute();
        }
    }
}
 