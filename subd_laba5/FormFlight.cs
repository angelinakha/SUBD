using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB.Implements;
using DB.Tables;

namespace subd_laba5
{
    public partial class FormFlight : Form
    {
        FlightStorage flightStorage;
        AirplaneStorage airplaneStorage;
        PilotStorage pilotStorage;
        RouteStorage routeStorage;
        TicketStorage ticketStorage;
        public FormFlight()
        {
            InitializeComponent();
            flightStorage = new FlightStorage();
            airplaneStorage = new AirplaneStorage();
            pilotStorage = new PilotStorage();
            routeStorage = new RouteStorage();
            ticketStorage = new TicketStorage();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                flightStorage.Delete(new Flight() { Id = (string)comboBoxId.SelectedValue });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            string id = (string)comboBoxId.SelectedValue;
            int count = Convert.ToInt32(textBoxCount.Text);
            int idPilot = (int)comboBoxIdPilot.SelectedValue;
            int idAirplane = (int)comboBoxIdAirplane.SelectedValue;
            int idRoute = (int)comboBoxIdRoute.SelectedValue;
            int ticketId = (int)comboBoxIdTicket.SelectedValue;
            try
            {
                flightStorage.Update(new Flight()
                {
                    Id = id,
                    OccupPlaces = count,
                    FlightDate = DateTime.UtcNow,
                    IdPilot = idPilot,
                    IdAirplane = idAirplane,
                    IdRoute = idRoute,
                    IdTicket = ticketId
                });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(textBoxCount.Text);
            int idPilot = (int)comboBoxIdPilot.SelectedValue;
            int idAirplane = (int)comboBoxIdAirplane.SelectedValue;
            int idRoute = (int)comboBoxIdRoute.SelectedValue;
            int ticketId = (int)comboBoxIdTicket.SelectedValue;

            try
            {
                flightStorage.Insert(new Flight()
                {
                    OccupPlaces = count,
                    FlightDate = DateTime.UtcNow,
                    IdPilot = idPilot,
                    IdAirplane = idAirplane,
                    IdRoute = idRoute,
                    IdTicket = ticketId
                });
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData();
        }

        private void FormFlight_Load(object sender, EventArgs e)
        {
           LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Flight> list;
                list = flightStorage.GetFullList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                    foreach (var component in list)
                    {
                        comboBoxId.DisplayMember = "Id";
                        comboBoxId.ValueMember = "Id";
                        comboBoxId.DataSource = list;
                        comboBoxId.SelectedItem = null;
                    }
                }
                var listAirplane = airplaneStorage.GetFullList();
                if (listAirplane != null)
                {
                    foreach (var component in listAirplane)
                    {
                        comboBoxIdAirplane.DisplayMember = "Id";
                        comboBoxIdAirplane.ValueMember = "Id";
                        comboBoxIdAirplane.DataSource = listAirplane;
                        comboBoxIdAirplane.SelectedItem = null;
                    }
                }
                var listPilot = pilotStorage.GetFullList();
                if (listPilot != null)
                {
                    foreach (var component in listPilot)
                    {
                        comboBoxIdPilot.DisplayMember = "Id";
                        comboBoxIdPilot.ValueMember = "Id";
                        comboBoxIdPilot.DataSource = listPilot;
                        comboBoxIdPilot.SelectedItem = null;
                    }
                }
                var listRoute = routeStorage.GetFullList();
                if (listRoute != null)
                {
                    foreach (var component in listRoute)
                    {
                        comboBoxIdRoute.DisplayMember = "Id";
                        comboBoxIdRoute.ValueMember = "Id";
                        comboBoxIdRoute.DataSource = listRoute;
                        comboBoxIdRoute.SelectedItem = null;
                    }
                }
                var listTicket = ticketStorage.GetFullList();
                if (listTicket != null)
                {
                    foreach (var component in listTicket)
                    {
                        comboBoxIdTicket.DisplayMember = "Id";
                        comboBoxIdTicket.ValueMember = "Id";
                        comboBoxIdTicket.DataSource = listTicket;
                        comboBoxIdTicket.SelectedItem = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
