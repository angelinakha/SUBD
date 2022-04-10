using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subd_laba5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFlight_Click(object sender, EventArgs e)
        {
            FormFlight form = new FormFlight();
            form.ShowDialog();
        }

        private void buttonAirplane_Click(object sender, EventArgs e)
        {
            FormAirplane form = new FormAirplane();
            form.ShowDialog();
        }

        private void buttonRoute_Click(object sender, EventArgs e)
        {
            FormRoute form = new FormRoute();
            form.ShowDialog();
        }

        private void buttonPilot_Click(object sender, EventArgs e)
        {
            FormPilot form = new FormPilot();
            form.ShowDialog();
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            FormTicket form = new FormTicket();
            form.ShowDialog();
        }
    }
}
