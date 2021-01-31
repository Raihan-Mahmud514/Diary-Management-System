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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventForm ef = new EventForm();
            ef.Show();
        }
    }
}
