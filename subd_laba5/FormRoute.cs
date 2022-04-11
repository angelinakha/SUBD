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
    public partial class FormRoute : Form
    {
        RouteStorage routeStorage;
        public FormRoute()
        {
            InitializeComponent();
            routeStorage = new RouteStorage();
        }
        private void LoadData()
        {
            try
            {
                List<Route> list;
                list = routeStorage.GetFullList();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRoute_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                routeStorage.Delete(new Route() { Id = (int)comboBoxId.SelectedValue });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string from = textBoxDestination.Text;
            string to = textBoxDeparture.Text;

            try
            {
                routeStorage.Insert(new Route()
                {
                    Destination = from,
                    DeparturePoint = to,
                    FlightDate = DateTime.UtcNow
                });
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            int id = (int)comboBoxId.SelectedValue;
            string from = textBoxDestination.Text;
            string to = textBoxDeparture.Text;
            try
            {
                routeStorage.Update(new Route()
                {
                    Id = id,
                    Destination = from,
                    DeparturePoint = to,
                    FlightDate = DateTime.UtcNow
                });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
    }
}
