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
    public partial class FormTicket : Form
    {
        TicketStorage ticketStorage;
        public FormTicket()
        {
            InitializeComponent();
            ticketStorage = new TicketStorage();
        }
    }
}
