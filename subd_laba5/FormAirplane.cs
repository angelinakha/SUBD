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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void FormAirplane_Load(object sender, EventArgs e)
        {

        }


        private void textBoxSeat_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
