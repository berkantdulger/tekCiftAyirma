using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekCiftSayilariFarkliListelereEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Sayı Giriniz";
            button1.Text = "Ekle";
            checkBox1.Text = "Tek sayıları topla";
            label2.Text = "Çift sayılar";
            label3.Text = "Tek sayılar";
            label4.Text = "Toplam";
            
            button2.Text = "Topla";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);

            if (sayi % 2 == 0)
            {
                listBox1.Items.Add(sayi);
                textBox1.Text = "";
                    
             }
            else
            {

                listBox2.Items.Add(sayi);
                textBox1.Text = "";
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                double toplam = 0;
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(listBox2.Items[i]);
                }
                label4.Text = "Tek sayıların toplamı : " + toplam;

                int adet = 0;
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    adet = i;

                }
                adet++;
                label5.Text = "Toplanan sayı adeti" + adet;
            }
            else
            {
                double toplam = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(listBox1.Items[i]);
                }
                label4.Text = "Çift sayıların toplamı : " + toplam;

                int adet = 0;


                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    adet = i;

                }
                adet++;
                label5.Text = "Toplanan sayı adeti" + adet;


            }
           


        }
    }
}