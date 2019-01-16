using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Otoparkımız op = new Otoparkımız();


        private void btnkuyruk_Click(object sender, EventArgs e)
        {
            if(rtbKuyruk.Text == "")
            {
                rtbKuyruk.Text = op.c.Listele();
            }
               
        }

        private void btnstack_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            for(int i = 0; i<15; i++)
            {
                mesaj += "Araba No:   " + op.s.items[i].ToString() + Environment.NewLine;
                
            }
            if(rtbstack.Text == "")
            {
                rtbstack.Text = mesaj;
            }

        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            if(rtblist.Text=="")
            {
                rtblist.Text = op.l.DisplayElements();
            }
        }

        private void btncikart_Click(object sender, EventArgs e)
        {
  
            rtbcikan.Text += "Çıkan Araba No:   " + op.c.Remove() + Environment.NewLine;
            int ihtimal;
            Random r = new Random();
            ihtimal = r.Next(0, 2);
            if (op.s.size == 0 && op.l.Size == 0)
                ihtimal = 2;
            else if (ihtimal == 0 && op.s.size != 0)
            {
                Araba a = new Araba();
                a.ArabaNo = op.s.Pop();
                op.c.Insert(a);
                rtbstack.Clear();
                rtbKuyruk.Clear();
                if (rtbKuyruk.Text == "")
                {
                    rtbKuyruk.Text = op.c.Listele();
                }

                if (rtbstack.Text == "")

                {
                    string mesaj = "";
                    for (int i = 0; i < op.s.size; i++)
                    {
                        mesaj += "Araba No:   " + op.s.items[i].ToString() + Environment.NewLine;
                    }
                    rtbstack.Text = mesaj;

                }
            }

            else if (ihtimal == 1 && op.l.Size != 0)
            {
                Araba a = new Araba();
                a.ArabaNo = op.l.DeleteFirst();
                op.c.Insert(a);
                rtblist.Clear();
                rtbKuyruk.Clear();
                if (rtbKuyruk.Text == "")
                {
                    rtbKuyruk.Text = op.c.Listele();
                }
                if (rtblist.Text == "")
                {
                    rtblist.Text = op.l.DisplayElements();
                }
            }

            else if (ihtimal == 2 && op.s.size == 0 && op.l.Size == 0 && op.c.front != 14)
            {
                rtbcikan.Text += "Çıkan Araba No:   " + op.c.Remove() + Environment.NewLine;
                rtbKuyruk.Clear();
                if (rtbKuyruk.Text == "")
                {
                    rtbKuyruk.Text = op.c.Listele();
                }

            }

        }
    }
}
