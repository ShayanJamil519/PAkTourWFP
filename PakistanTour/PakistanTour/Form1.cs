using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakistanTour
{
    public partial class Form1 : Form
    {
        Sindh sin = new Sindh();
        Punjab punj = new Punjab();
        Balochistan bal = new Balochistan();
        KhyberPakhtunKhuwa kpk = new KhyberPakhtunKhuwa();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSindh_Click(object sender, EventArgs e)
        {
            sin.Show();
            punj.Hide();
            bal.Hide();
            kpk.Hide();
        }

        private void buttonPunjab_Click(object sender, EventArgs e)
        {
            punj.Show();
            sin.Hide();
            bal.Hide();
            kpk.Hide();
        }

        private void buttonKhyberPakhtunKhuwa_Click(object sender, EventArgs e)
        {
            kpk.Show();
            sin.Hide();
            punj.Hide();
            bal.Hide();
        }

        private void buttonBalochistan_Click(object sender, EventArgs e)
        {
            bal.Show();
            sin.Hide();
            punj.Hide();
            kpk.Hide();
            
        }

    }
}
