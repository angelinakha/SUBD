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
    public partial class FormPilot : Form
    {
        PilotStorage pilotStorage;
        public FormPilot()
        {
            InitializeComponent();
            pilotStorage = new PilotStorage();
        }
        private void LoadData()
        {
            try
            {
                List<Pilot> list;
                list = pilotStorage.GetFullList();
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

        private void FormPilot_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxFIO.Text;
            try
            {
                pilotStorage.Insert(new Pilot()
                {
                    NamePilot = name,
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
            string name = textBoxFIO.Text;
            try
            {
                pilotStorage.Update(new Pilot()
                {
                    Id = id,
                    NamePilot = name
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
                pilotStorage.Delete(new Pilot() { Id = (int)comboBoxId.SelectedValue });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
    }
}
