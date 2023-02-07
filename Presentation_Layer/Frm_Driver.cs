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
    public partial class Frm_Driver : Form
    {
        public Frm_Driver()
        {
            InitializeComponent();
        }

        E_Drivers Edriver = new();
        BL_Driver BLdriver = new();

        private void ClearForm()
        {
            codigoTxt.Clear();
            cedulaTxt.Clear();
            nombreTxt.Clear();
            apellidoTxt.Clear();
            celularTxt.Clear();
            correoTxt.Clear();
        }

        private void ShowDrivers(string search)
        {
            driversDGV.DataSource = BLdriver.DriversRecord(search);
        }

        private void Frm_Driver_Load(object sender, EventArgs e)
        {
            fechNacDtp.CustomFormat = "yyyy/MM/dd";
            ShowDrivers("");
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

                cedulaTxt.ReadOnly = true;
                addBTN.Visible = false;
            }
            else if (!editCbx.Checked)
            {
                codigoLbl.Visible = false;
                codigoPBx.Visible = false;
                codigoTxt.Visible = false;
                editBTN.Visible = false;

                cedulaTxt.ReadOnly = false;
                addBTN.Visible = true;
            }

            ClearForm();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDriver()
        {
            if (cedulaTxt.Text.Length == 0 || nombreTxt.Text.Length == 0 || apellidoTxt.Text.Length == 0 || celularTxt.Text.Length == 0
                || correoTxt.Text.Length == 0)
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
            else
            {
                Edriver.Cedula = cedulaTxt.Text;
                Edriver.FirstName = nombreTxt.Text;
                Edriver.LastName = apellidoTxt.Text;
                Edriver.Birthdate = fechNacDtp.Value;
                Edriver.Movil = celularTxt.Text;
                Edriver.Email = correoTxt.Text;

                BLdriver.InsertDriver(Edriver);
                ClearForm();
                ShowDrivers("");
            }
        }

        private void editDriver()
        {
            if (driversDGV.SelectedRows.Count > 0)
            {
                codigoTxt.Text = driversDGV.CurrentRow.Cells[1].Value.ToString();
                cedulaTxt.Text = driversDGV.CurrentRow.Cells[2].Value.ToString();
                nombreTxt.Text = driversDGV.CurrentRow.Cells[3].Value.ToString();
                apellidoTxt.Text = driversDGV.CurrentRow.Cells[4].Value.ToString();
                fechNacDtp.Text = driversDGV.CurrentRow.Cells[5].Value.ToString();
                celularTxt.Text = driversDGV.CurrentRow.Cells[6].Value.ToString();
                correoTxt.Text = driversDGV.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void EditDriver()
        {
            if (nombreTxt.Text.Length == 0 || apellidoTxt.Text.Length == 0
            || celularTxt.Text.Length == 0 || correoTxt.Text.Length == 0)
            {
                MessageBox.Show("Los campos no deben estar vacio");
            }
            else
            {
                Edriver.DriverCode = codigoTxt.Text;
                Edriver.FirstName = nombreTxt.Text;
                Edriver.LastName = apellidoTxt.Text;
                Edriver.Birthdate = Convert.ToDateTime(fechNacDtp.Value);
                Edriver.Movil = celularTxt.Text;
                Edriver.Email = correoTxt.Text;

                BLdriver.UpdateDriver(Edriver);
                ClearForm();
                ShowDrivers("");
            }
        }

        private void DelDriver()
        {

            if (driversDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Edriver.DriverCode = driversDGV.CurrentRow.Cells[1].Value.ToString();
                    BLdriver.DeleteDriver(Edriver);
                    if (codigoTxt.Text == driversDGV.CurrentRow.Cells[1].Value.ToString() )
                    {
                        ClearForm();
                    }
                    ShowDrivers("");
                }

            }
            else
            {
                MessageBox.Show("Debes selecionar una fila para eliminar");
            }
        }

        private void driversDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (editCbx.Checked)
            {
                editDriver();
            }
        }

        private void editCbx_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideField();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            AddDriver();

        }
        private void editBTN_Click(object sender, EventArgs e)
        {
            EditDriver();
        }

        private void delDriverBtn_Click(object sender, EventArgs e)
        {
            DelDriver();
        }

    }
    
}
