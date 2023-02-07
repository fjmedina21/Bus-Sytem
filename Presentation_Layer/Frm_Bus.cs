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
    public partial class Frm_Bus : Form
    {
        public Frm_Bus()
        {
            InitializeComponent();
        }

        E_Buses Ebus = new();
        BL_Bus BLbus = new();

        private void ClearForm()
        {
            marcaTxt.Clear();
            modeloTxt.Clear();
            placaTxt.Clear();
            anioTxt.Clear();
         }

        private void AddBus()
        {
            if (marcaTxt.Text.Length == 0 || modeloTxt.Text.Length == 0 || placaTxt.Text.Length == 0 || anioTxt.Text.Length == 0)
            {
                MessageBox.Show("Los campos no deben estar vacio");
            }
            else
            {
                Ebus.Brand = marcaTxt.Text;
                Ebus.Model = modeloTxt.Text;
                Ebus.LicensePlate = placaTxt.Text;
                Ebus.Color = colorTxt.Text;
                Ebus.ModelYear = Convert.ToInt32(anioTxt.Text);

                BLbus.InsertBus(Ebus);
                ClearForm();
                ShowBuses("");
            }         
        }

        private void DelBus()
        {

            if (busesDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Ebus.BusCode = busesDGV.CurrentRow.Cells[1].Value.ToString();
                    BLbus.DeleteBus(Ebus);
                    ShowBuses("");
                }

            }
            else
            {
                MessageBox.Show("Debes selecionar una fila para eliminar");
            }
        }

        private void ShowBuses(string search)
        {
            busesDGV.DataSource = BLbus.BusesRecord(search);
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Bus_Load(object sender, EventArgs e)
        {
            ShowBuses("");
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            AddBus();
        }

        private void delBusBtn_Click(object sender, EventArgs e)
        {
            DelBus();
        }
    }
}
