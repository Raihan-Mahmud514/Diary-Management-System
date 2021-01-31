using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Management_System
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new NewEventForm()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new ModifiedEventForm()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new DeleteEventForm()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Login ln = new Login();
            //ln.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
