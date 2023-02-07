using System.Windows.Forms;
using Entities;
using BusinessLogic_Layer;

namespace Presentation_Layer
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
                
        private void ShowTrips(string search)
        {
            BL_Trip trips = new();
            mainDGV.DataSource = trips.TripsRecord(search);
            
        }

        private void DelTrip()
        {
            E_Trips Et = new();
            BL_Trip BLt = new();
            if (mainDGV.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Et.TripCode = mainDGV.CurrentRow.Cells[0].Value.ToString();
                    BLt.DeleteTrip(Et);
                    ShowTrips("");
                }

            }
            else
            {
                MessageBox.Show("Debes selecionar una fila para eliminar");
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ShowTrips("");
        }     

        private void driverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Driver d = new();
            d.ShowDialog();
            this.Visible = true;
        }

        private void routeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Route r = new();
            r.ShowDialog();
            this.Visible = true;
        }

        private void busBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Bus b = new();
            b.ShowDialog();
            this.Visible = true;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addTripBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Trip t = new();
            t.ShowDialog();
            ShowTrips("");
            this.Visible = true;
        }

        private void delTripBtn_Click(object sender, EventArgs e)
        {
            DelTrip();
        }
    }
}