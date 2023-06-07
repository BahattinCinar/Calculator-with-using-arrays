using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DIziler_ile_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i , giris_sayisi, toplam = 0, carpim = 1 , bolum = 1, cikartma = 0;

            try
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    MessageBox.Show("bir islem seciniz");
                }

                giris_sayisi = Convert.ToInt32(Interaction.InputBox("Giris yapicaginiz sayi miktari", "Kac Sayi Girilecek", "", 125, 125));

                int[] num = new int[giris_sayisi];

                if (radioButton1.Checked == true)
                {
                    for (i = 0 ; i <= num.Length - 1; i++)
                    {
                        num[i] = Convert.ToInt32(Interaction.InputBox($"{i + 1}. Sayi girisi", "Sayi Giris Ekrani", "", 250, 250));
                        toplam += num[i];
                    }

                    label1.Text = $"Girdiginiz sayilarin toplami = {toplam}";
                }

                else if (radioButton3.Checked == true)
                {
                    for (i = 0; i <= num.Length-1; i++)
                    {
                        num[i] = Convert.ToInt32(Interaction.InputBox($"{i + 1}. Sayi girisi", "Sayi Giris Ekrani", "", 250, 250));
                        carpim *= num[i];
                    }

                    label1.Text = $"Girdiginiz sayilarin carpimi = {carpim}";
                }

                else if (radioButton4.Checked == true)
                {
                    for (i = 0; i <= num.Length-1; i++)
                    {
                        num[i] = Convert.ToInt32(Interaction.InputBox($"{i + 1}. Sayi girisi", "Sayi Giris Ekrani", "", 250, 250));
                        bolum /= num[i];
                    }

                    label1.Text = $"Girdiginiz sayilarin bolumu = {bolum}";
                }

                else
                {
                    for (i = 0; i <= num.Length - 1; i++)
                    {
                        num[i] = Convert.ToInt32(Interaction.InputBox($"{i + 1}. Sayi girisi", "Sayi Giris Ekrani", "", 250, 250));
                        cikartma = -num[i] - cikartma;
                    }

                    label1.Text = $"Girdiginiz sayilarin bolumu = {cikartma}";
                }
            }

            catch (FormatException error1)
            {
                MessageBox.Show("Tam sayi giriniz");
                MessageBox.Show(error1.Message);
            }

            catch(OverflowException error2)
            {
                MessageBox.Show("sayi araliginiz -2,147,483,648 ve 2,147,483,647 arasinda olmali");
                MessageBox.Show(error2.Message);
            }

            catch
            {
                MessageBox.Show("Beklenmedik bir hata ile karsilastiniz");
            }

            finally
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;    
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
