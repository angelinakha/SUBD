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
    public partial class FormAirplane : Form
    {
        AirplaneStorage airplaneStorage;

        public FormAirplane()
        {
            InitializeComponent();
            airplaneStorage = new AirplaneStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int count = Convert.ToInt32(textBoxSeat.Text);
            try
            {
                airplaneStorage.Insert(new Airplane()
                {
                    Aircraftname = name,
                    MaxNumberOfSeats = count
                });
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            int id = (int)comboBoxId.SelectedValue;
            string name = textBoxName.Text;
            int count = Convert.ToInt32(textBoxSeat.Text);
            try
            {
                airplaneStorage.Update(new Airplane()
                {
                    Id = id,
                    Aircraftname = name,
                    MaxNumberOfSeats = count
                });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                airplaneStorage.Delete(new Airplane() { Id = (int)comboBoxId.SelectedValue });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void FormAirplane_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Airplane> list;
                list = airplaneStorage.GetFullList();
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
    }
}
