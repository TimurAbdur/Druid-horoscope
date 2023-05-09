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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка выхода из программы
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Кнопка информация о программн
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Show();
        }

        //При выборе даты срабатывает это событие
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Examination();
        }

        //Examination метод проверки даты
        public void Examination() {
            int day = monthCalendar1.SelectionRange.Start.Day;
            int month = monthCalendar1.SelectionRange.Start.Month;
            
            //Яблоня -
            if (((day >= 23 && month == 12) || (day == 1 && month == 1)) || ((day >= 25 && month == 6) || (day <= 4 && month == 7)))
            {
                richTextBox1.LoadFile("texts/aplle.rtf");
                pictureBox1.Load("imgs/aplle.png"); 
            }
            
            //Пихта -
            else if ((day >= 2 && day <= 11 && month == 1) || (day >= 5 && day <= 14 && month == 7))
            {
                richTextBox1.LoadFile("texts/pihta.rtf");
                pictureBox1.Load("imgs/pihta.png");
            } 
            
            //Вяз -
            else if ((day >= 12 && day <= 24 && month == 1) || (day >= 15 && day <= 25 && month == 7))
            {
                richTextBox1.LoadFile("texts/vyaz.rtf");
                pictureBox1.Load("imgs/vyaz.png");
            }
            
            //Кипарис -
            else if (((day >= 25 && month == 1) || (day <= 3 && month == 2)) || ((day >= 26 && month == 7) || (day <= 4 && month == 8)))
            {
                richTextBox1.LoadFile("texts/kiparis.rtf");
                pictureBox1.Load("imgs/kiparis.png");
            }
            
            //Тополь - 
            else if ((day >= 4 && day <= 8 && month == 2) || (day >= 5 && day <= 13 && month == 8))
            {
                richTextBox1.LoadFile("texts/topol.rtf");
                pictureBox1.Load("imgs/topol.png");
            }
            
            //Каркас Южный -
            else if ((day >= 9 && day <= 18 && month == 2) || (day >= 14 && day <= 23 && month == 8))
            {
                richTextBox1.LoadFile("texts/karkasred.rtf");
                pictureBox1.Load("imgs/karkas.png");
            }
            
            //Сосна -
            else if ((day >= 19 && day <= 29 && month == 2) || ((day >= 24 && month == 8) || (day <= 2 && month == 3)))
            {
                richTextBox1.LoadFile("texts/sosna.rtf");
                pictureBox1.Load("imgs/sosna.png");
            }
            
            //Ива -
            else if ((day >= 1 && day <= 10 && month == 3) || (day >= 3 && day <= 12 && month == 9))
            {
                richTextBox1.LoadFile("texts/iva.rtf");
                pictureBox1.Load("imgs/iva.png");
            }
            
            //Липа -
            else if ((day >= 11 && day <= 20 && month == 3) || (day >= 13 && day <= 22 && month == 9))
            {
                richTextBox1.LoadFile("texts/lipa.rtf");
                pictureBox1.Load("imgs/lipa.png");
            }
            
            //Орешник -
            else if ((day >= 22 && day <= 31 && month == 3) || ((day >= 24 && month == 9) || (day <= 3 && month == 10)))
            {
                richTextBox1.LoadFile("texts/oreshnik.rtf"); 
                     pictureBox1.Load("imgs/oreshnik.png");
            }
            
            //Рябина -
            else if ((day >= 1 && day <= 10 && month == 4) || (day >= 4 && day <= 13 && month == 10))
            {
                richTextBox1.LoadFile("texts/ryabina.rtf");
                pictureBox1.Load("imgs/ryabina.png");
            }
            
            //Клён -
            else if ((day >= 11 && day <= 20 && month == 4) || (day >= 14 && day <= 23 && month == 10))
            {
                richTextBox1.LoadFile("texts/klen.rtf");
                pictureBox1.Load("imgs/klen.png");
            }
            
            //Орех -
            else if ((day >= 21 && day <= 30 && month == 4) || ((day >= 24 && month == 10) || (day <= 2 && month == 11)))
            {
                richTextBox1.LoadFile("texts/orex.rtf");
                pictureBox1.Load("imgs/orex.png");
            }
            
            //Жасмин -
            else if ((day >= 1 && day <= 14 && month == 5) || (day >= 3 && day <= 11 && month == 11))
            {
                richTextBox1.LoadFile("texts/jasmin.rtf");
                pictureBox1.Load("imgs/jasmin.png");
            }
            
            //Каштан -
            else if ((day >= 15 && day <= 24 && month == 5) || (day >= 12 && day <= 21 && month == 11))
            {
                richTextBox1.LoadFile("texts/kashtan.rtf");
                pictureBox1.Load("imgs/kashtan.png");
            }
            
            //Ясень -
            else if (((day >= 23 && month == 5) || (day <= 3 && month == 6)) || ((day >= 22 && month == 11) || (day <= 1 && month == 12)))
            {
                richTextBox1.LoadFile("texts/yasen.rtf");
                pictureBox1.Load("imgs/yasen.png");
            }
            
            //Граб -
            else if ((day >= 4 && day <= 13 && month == 6) || (day >= 2 && day <= 11 && month == 12))
            {
                richTextBox1.LoadFile("texts/grab.rtf");
                pictureBox1.Load("imgs/grab.png");
            }
            
            //Инжир -
            else if ((day >= 14 && day <= 23 && month == 6) || (day >= 12 && day <= 20 && month == 12))
            {
                richTextBox1.LoadFile("texts/injir.rtf");
                pictureBox1.Load("imgs/injir.png");
            }
            
            //Дуб -
            else if (day >= 21 && month == 3)
            {
                richTextBox1.LoadFile("texts/dyb.rtf");
                pictureBox1.Load("imgs/dyb.png");
            }

            //Береза -
            else if (day >= 24 && month == 6)
            {
                richTextBox1.LoadFile("texts/bereza.rtf");
                pictureBox1.Load("imgs/bereza.png");
            }
            
            //Маслина
            else if (day >= 23 && month == 9)
            {
                richTextBox1.LoadFile("texts/maslina.rtf");
                pictureBox1.Load("imgs/maslina.png");
            }
            
            //Бук
            else if (day >= 21 && day <= 22 && month == 12)
            {
                richTextBox1.LoadFile("texts/byk.rtf");
                pictureBox1.Load("imgs/byk.png");
            }

            else
            {
                richTextBox1.Text = "";
            }
        }

        private void выхоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            about form2 = new about();
            form2.ShowDialog();
            Show();
        }

        private void оПрограммеToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            оПрограммеToolStripMenuItem.ForeColor = Color.Black;
        }

        private void выхоToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            выхоToolStripMenuItem.ForeColor = Color.Black;
        }

        private void выходToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            выходToolStripMenuItem.ForeColor = Color.Black;
        }

        private void выходToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            выходToolStripMenuItem.ForeColor = Color.WhiteSmoke;
        }

        private void оПрограммеToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            оПрограммеToolStripMenuItem.ForeColor = Color.WhiteSmoke;
        }

        private void выхоToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            выхоToolStripMenuItem.ForeColor = Color.WhiteSmoke;
        }
    }
}
