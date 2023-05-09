using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гороскоп_Друидов__Тимур_ИС_22_
{
    public partial class zastavka : Form
    {
        public zastavka()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value+=10;
            label1.Text = "Загрузка " + progressBar1.Value+"%";
            if (progressBar1.Value == 100) {
                timer1.Stop();
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Application.Exit();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
