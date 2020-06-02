using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_21
{
    public partial class Form1 : Form
    {   
        //объявление всех переменных
        Random nomerkarti = new Random();
        Random sopernik = new Random();
        static public int nomerigb = 2; 
        static public int schet = 0;
        static public int k = 2;
        static public int proverkapobedi = 0;
        static public int schetsopernika = 0;
        static public int kartostalos = 20;
        static public int[] kolvokart = new int[8];
        static public int[] kartisopernika1 = new int[6];

        //генератор случайного числа
        static int GenerateDigit(Random nomerkarti)
        {
            nomerkarti.Next(6, 15);
            return nomerkarti.Next(6,15);
        }

        //генератор случайного числа
        static int GenerateDigit1(Random sopernik)
        {
            sopernik.Next(6, 15);
            sopernik.Next(6, 15);
            sopernik.Next(6, 15);
            sopernik.Next(6, 15);
            sopernik.Next(6, 15);
            sopernik.Next(6, 15);
            return sopernik.Next(6, 15);
        }

        //запуск формы по середине экрана
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        //проверка сколько взято карт
        private void button1_Click(object sender, EventArgs e)
        {
            
            int kartasopernika = 0;
            nomerigb++;
            int karta = 0;
            for (int i = 0; i < kolvokart.Length; i++)
            { if (kolvokart[i] > 4)
                { if (karta != 13) karta = karta + 1;
                    else {
                        if (karta == 13) karta = karta - 1;
                    } } }
            if (1 == 1)
            {
                if (nomerigb == 3)
                {
                   
                    karta = GenerateDigit(nomerkarti);

                    if (karta == 6) { pictureBox3.Image = Properties.Resources.p_6; schet = schet + karta; }
                    if (karta == 7) { pictureBox3.Image = Properties.Resources.p_7; schet = schet + karta; }
                    if (karta == 8) { pictureBox3.Image = Properties.Resources.p_8; schet = schet + karta; }
                    if (karta == 9) { pictureBox3.Image = Properties.Resources.p_9; schet = schet + karta; }
                    if (karta == 10) { pictureBox3.Image = Properties.Resources.p_10; schet = schet + karta; }
                    if (karta == 11) { pictureBox3.Image = Properties.Resources.p_val; schet = schet + 2; }
                    if (karta == 12) { pictureBox3.Image = Properties.Resources.p_dam; schet = schet + 3; }
                    if (karta == 13) { pictureBox3.Image = Properties.Resources.p_kor; schet = schet + 4; }
                    if (karta == 14) { pictureBox3.Image = Properties.Resources.p_tuz; schet = schet + 11; }
                    label1.Text = "Ваш счет: " + schet;
                    if(schetsopernika<=16)
                    {
                        pictureBox9.Visible = true;
                        kartasopernika = GenerateDigit1(sopernik);
                        kartisopernika1[k] = kartasopernika; k++;
                        if (kartasopernika <= 10) schetsopernika = schetsopernika + kartasopernika;
                        else
                        {
                            if (kartasopernika == 11) { schetsopernika = schetsopernika + 2; }
                            if (kartasopernika == 12) { schetsopernika = schetsopernika + 3; }
                            if (kartasopernika == 13) { schetsopernika = schetsopernika + 4; }
                            if (kartasopernika == 14) { schetsopernika = schetsopernika + 11; }

                        }
                        
                    }
                }
                if (nomerigb == 4)
                {

                    karta = GenerateDigit(nomerkarti);

                    if (karta == 6) { pictureBox4.Image = Properties.Resources.p_6; schet = schet + karta; }
                    if (karta == 7) { pictureBox4.Image = Properties.Resources.p_7; schet = schet + karta; }
                    if (karta == 8) { pictureBox4.Image = Properties.Resources.p_8; schet = schet + karta; }
                    if (karta == 9) { pictureBox4.Image = Properties.Resources.p_9; schet = schet + karta; }
                    if (karta == 10) { pictureBox4.Image = Properties.Resources.p_10; schet = schet + karta; }
                    if (karta == 11) { pictureBox4.Image = Properties.Resources.p_val; schet = schet + 2; }
                    if (karta == 12) { pictureBox4.Image = Properties.Resources.p_dam; schet = schet + 3; }
                    if (karta == 13) { pictureBox4.Image = Properties.Resources.p_kor; schet = schet + 4; }
                    if (karta == 14) { pictureBox4.Image = Properties.Resources.p_tuz; schet = schet + 11; }
                    label1.Text = "Ваш счет: " + schet;
                    if (schetsopernika <= 16)
                    {
                        pictureBox10.Visible = true;
                        kartasopernika = GenerateDigit1(sopernik);
                        kartisopernika1[k] = kartasopernika; k++;
                        if (kartasopernika <= 10) schetsopernika = schetsopernika + kartasopernika;
                        else
                        {
                            if (kartasopernika == 11) { schetsopernika = schetsopernika + 2; }
                            if (kartasopernika == 12) { schetsopernika = schetsopernika + 3; }
                            if (kartasopernika == 13) { schetsopernika = schetsopernika + 4; }
                            if (kartasopernika == 14) { schetsopernika = schetsopernika + 11; }

                        }
                        
                    }
                }
                if (nomerigb == 5)
                {
                    
                    karta = GenerateDigit(nomerkarti);

                    if (karta == 6) { pictureBox5.Image = Properties.Resources.p_6; schet = schet + karta; }
                    if (karta == 7) { pictureBox5.Image = Properties.Resources.p_7; schet = schet + karta; }
                    if (karta == 8) { pictureBox5.Image = Properties.Resources.p_8; schet = schet + karta; }
                    if (karta == 9) { pictureBox5.Image = Properties.Resources.p_9; schet = schet + karta; }
                    if (karta == 10) { pictureBox5.Image = Properties.Resources.p_10; schet = schet + karta; }
                    if (karta == 11) { pictureBox5.Image = Properties.Resources.p_val; schet = schet + 2; }
                    if (karta == 12) { pictureBox5.Image = Properties.Resources.p_dam; schet = schet + 3; }
                    if (karta == 13) { pictureBox5.Image = Properties.Resources.p_kor; schet = schet + 4; }
                    if (karta == 14) { pictureBox5.Image = Properties.Resources.p_tuz; schet = schet + 11; }
                    label1.Text = "Ваш счет: " + schet;
                    if (schetsopernika <= 16)
                    {
                        pictureBox11.Visible = true;
                        
                        kartasopernika = GenerateDigit1(sopernik);
                        kartisopernika1[k] = kartasopernika; k++;
                        if (kartasopernika <= 10) schetsopernika = schetsopernika + kartasopernika;
                        else
                        {
                            if (kartasopernika == 11) { schetsopernika = schetsopernika + 2; }
                            if (kartasopernika == 12) { schetsopernika = schetsopernika + 3; }
                            if (kartasopernika == 13) { schetsopernika = schetsopernika + 4; }
                            if (kartasopernika == 14) { schetsopernika = schetsopernika + 11; }

                        }
                        
                    }

                }
                if (nomerigb == 6)
                {
                    
                    karta = GenerateDigit(nomerkarti);

                    if (karta == 6) { pictureBox6.Image = Properties.Resources.p_6; schet = schet + karta; }
                    if (karta == 7) { pictureBox6.Image = Properties.Resources.p_7; schet = schet + karta; }
                    if (karta == 8) { pictureBox6.Image = Properties.Resources.p_8; schet = schet + karta; }
                    if (karta == 9) { pictureBox6.Image = Properties.Resources.p_9; schet = schet + karta; }
                    if (karta == 10) { pictureBox6.Image = Properties.Resources.p_10; schet = schet + karta; }
                    if (karta == 11) { pictureBox6.Image = Properties.Resources.p_val; schet = schet + 2; }
                    if (karta == 12) { pictureBox6.Image = Properties.Resources.p_dam; schet = schet + 3; }
                    if (karta == 13) { pictureBox6.Image = Properties.Resources.p_kor; schet = schet + 4; }
                    if (karta == 14) { pictureBox6.Image = Properties.Resources.p_tuz; schet = schet + 11; }
                    label1.Text = "Ваш счет: " + schet;
                    if (schetsopernika <= 16)
                    {
                        pictureBox12.Visible = true;

                        kartasopernika = GenerateDigit1(sopernik);
                        kartisopernika1[k] = kartasopernika; k++;
                        if (kartasopernika <= 10) schetsopernika = schetsopernika + kartasopernika;
                        else
                        {
                            if (kartasopernika == 11) { schetsopernika = schetsopernika + 2; }
                            if (kartasopernika == 12) { schetsopernika = schetsopernika + 3; }
                            if (kartasopernika == 13) { schetsopernika = schetsopernika + 4; }
                            if (kartasopernika == 14) { schetsopernika = schetsopernika + 11; }

                        }
                        
                    }
                }
                if (nomerigb >= 7)
                {
                    MessageBox.Show("Больше нельзя взять!", "Предупреждение");

                }
                else
                {
                    if (kartostalos != 0 && nomerigb < 14)
                    { label2.Text = Convert.ToString(kartostalos); }
                    else { label2.Text = Convert.ToString(kartostalos); pictureBox13.Visible = false; label2.Visible = false; }
                }
            }
        }

        //При загрузке игры раздается 2 карты каждому игроку
        private void Form1_Load(object sender, EventArgs e)
        {   for (int i = 0; i < kolvokart.Length; i++)
            { kolvokart[i] = 0; }

            int kartasopernika = 0;
            kartasopernika = GenerateDigit1(sopernik);
            kartisopernika1[0] = kartasopernika;
            if (kartasopernika <= 10) schetsopernika = schetsopernika + kartasopernika;
            else
            {
                if (kartasopernika == 11) { schetsopernika = schetsopernika + 2; }
                if (kartasopernika == 12) { schetsopernika = schetsopernika + 3; }
                if (kartasopernika == 13) { schetsopernika = schetsopernika + 4; }
                if (kartasopernika == 14) { schetsopernika = schetsopernika + 11; }

            }
            
            int karta = 0;
            karta = GenerateDigit(nomerkarti);

            if (karta == 6) { pictureBox1.Image = Properties.Resources.p_6; schet = schet + karta; }
            if (karta == 7) { pictureBox1.Image = Properties.Resources.p_7; schet = schet + karta; }
            if (karta == 8) { pictureBox1.Image = Properties.Resources.p_8; schet = schet + karta; }
            if (karta == 9) { pictureBox1.Image = Properties.Resources.p_9; schet = schet + karta; }
            if (karta == 10) { pictureBox1.Image = Properties.Resources.p_10; schet = schet + karta; }
            if (karta == 11) { pictureBox1.Image = Properties.Resources.p_val; schet = schet + 2; }
            if (karta == 12) { pictureBox1.Image = Properties.Resources.p_dam; schet = schet + 3; }
            if (karta == 13) { pictureBox1.Image = Properties.Resources.p_kor; schet = schet + 4; }
            if (karta == 14) { pictureBox1.Image = Properties.Resources.p_tuz; schet = schet + 11; }
            
            karta = GenerateDigit(nomerkarti);
            if (karta == 6) { pictureBox2.Image = Properties.Resources.p_6; schet = schet + karta; }
            if (karta == 7) { pictureBox2.Image = Properties.Resources.p_7; schet = schet + karta; }
            if (karta == 8) { pictureBox2.Image = Properties.Resources.p_8; schet = schet + karta; }
            if (karta == 9) { pictureBox2.Image = Properties.Resources.p_9; schet = schet + karta; }
            if (karta == 10) { pictureBox2.Image = Properties.Resources.p_10; schet = schet + karta; }
            if (karta == 11) { pictureBox2.Image = Properties.Resources.p_val; schet = schet + 2; }
            if (karta == 12) { pictureBox2.Image = Properties.Resources.p_dam; schet = schet + 3; }
            if (karta == 13) { pictureBox2.Image = Properties.Resources.p_kor; schet = schet + 4; }
            if (karta == 14) { pictureBox2.Image = Properties.Resources.p_tuz; schet = schet + 11; }
            label1.Text = "Ваш счет: " + schet;
            kartasopernika = GenerateDigit1(sopernik);
            kartasopernika = GenerateDigit1(sopernik);
            kartasopernika = GenerateDigit1(sopernik);
            kartasopernika = GenerateDigit1(sopernik);
            kartasopernika = GenerateDigit1(sopernik);
            kartasopernika = GenerateDigit1(sopernik);
            kartisopernika1[1] = kartasopernika;
            if (kartasopernika <= 10) schetsopernika = schetsopernika + kartasopernika;
            else
            {
                if (kartasopernika == 11) { schetsopernika = schetsopernika + 2; }
                if (kartasopernika == 12) { schetsopernika = schetsopernika + 3; }
                if (kartasopernika == 13) { schetsopernika = schetsopernika + 4; }
                if (kartasopernika == 14) { schetsopernika = schetsopernika + 11; }

            }

            

        }

        //если кнопка "вскрываемся" нажата
        private void button2_Click(object sender, EventArgs e)
        {
            int kartasopernika = 0;
            while (k<6)
            { if (schetsopernika <= 15)
                { 
                    kartasopernika = GenerateDigit1(sopernik);
                    if (kartasopernika <= 10) schetsopernika = schetsopernika + kartasopernika;
                    else
                    {
                        if (kartasopernika == 11) { schetsopernika = schetsopernika + 2; }
                        if (kartasopernika == 12) { schetsopernika = schetsopernika + 3; }
                        if (kartasopernika == 13) { schetsopernika = schetsopernika + 4; }
                        if (kartasopernika == 14) { schetsopernika = schetsopernika + 11; }

                    }
                    kartisopernika1[k] = kartasopernika;
                }
                k++;
            }
            kartasopernika = 0;
            
                    if (kartisopernika1[0] == 6) { pictureBox7.Image = Properties.Resources.p_6;  }
                    if (kartisopernika1[0] == 7) { pictureBox7.Image = Properties.Resources.p_7;  }
                    if (kartisopernika1[0] == 8) { pictureBox7.Image = Properties.Resources.p_8;  }
                    if (kartisopernika1[0] == 9) { pictureBox7.Image = Properties.Resources.p_9;  }
                    if (kartisopernika1[0] == 10) { pictureBox7.Image = Properties.Resources.p_10;  }
                    if (kartisopernika1[0] == 11) { pictureBox7.Image = Properties.Resources.p_val;  }
                    if (kartisopernika1[0] == 12) { pictureBox7.Image = Properties.Resources.p_dam;  }
                    if (kartisopernika1[0] == 13) { pictureBox7.Image = Properties.Resources.p_kor;  }
                    if (kartisopernika1[0] == 14) { pictureBox7.Image = Properties.Resources.p_tuz;  }

                    if (kartisopernika1[1] == 6) { pictureBox8.Image = Properties.Resources.p_6; }
                    if (kartisopernika1[1] == 7) { pictureBox8.Image = Properties.Resources.p_7; }
                    if (kartisopernika1[1] == 8) { pictureBox8.Image = Properties.Resources.p_8; }
                    if (kartisopernika1[1] == 9) { pictureBox8.Image = Properties.Resources.p_9; }
                    if (kartisopernika1[1] == 10) { pictureBox8.Image = Properties.Resources.p_10; }
                    if (kartisopernika1[1] == 11) { pictureBox8.Image = Properties.Resources.p_val; }
                    if (kartisopernika1[1] == 12) { pictureBox8.Image = Properties.Resources.p_dam; }
                    if (kartisopernika1[1] == 13) { pictureBox8.Image = Properties.Resources.p_kor; }
                    if (kartisopernika1[1] == 14) { pictureBox8.Image = Properties.Resources.p_tuz; }

                    if (kartisopernika1[2] == 6) { pictureBox9.Image = Properties.Resources.p_6; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 7) { pictureBox9.Image = Properties.Resources.p_7; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 8) { pictureBox9.Image = Properties.Resources.p_8; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 9) { pictureBox9.Image = Properties.Resources.p_9; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 10) { pictureBox9.Image = Properties.Resources.p_10; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 11) { pictureBox9.Image = Properties.Resources.p_val; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 12) { pictureBox9.Image = Properties.Resources.p_dam; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 13) { pictureBox9.Image = Properties.Resources.p_kor; pictureBox9.Visible = true; }
                    if (kartisopernika1[2] == 14) { pictureBox9.Image = Properties.Resources.p_tuz; pictureBox9.Visible = true; }

            if (kartisopernika1[3] == 6) { pictureBox10.Image = Properties.Resources.p_6; pictureBox10.Visible = true; }
            if (kartisopernika1[3] == 7) { pictureBox10.Image = Properties.Resources.p_7; pictureBox10.Visible = true; }
                if (kartisopernika1[3] == 8) { pictureBox10.Image = Properties.Resources.p_8; pictureBox10.Visible = true; }
            if (kartisopernika1[3] == 9) { pictureBox10.Image = Properties.Resources.p_9; pictureBox10.Visible = true; }
            if (kartisopernika1[3] == 10) { pictureBox10.Image = Properties.Resources.p_10; pictureBox10.Visible = true; }
            if (kartisopernika1[3] == 11) { pictureBox10.Image = Properties.Resources.p_val; pictureBox10.Visible = true; }
            if (kartisopernika1[3] == 12) { pictureBox10.Image = Properties.Resources.p_dam; pictureBox10.Visible = true; }
            if (kartisopernika1[3] == 13) { pictureBox10.Image = Properties.Resources.p_kor; pictureBox10.Visible = true; }
            if (kartisopernika1[3] == 14) { pictureBox10.Image = Properties.Resources.p_tuz; pictureBox10.Visible = true; }

            if (kartisopernika1[4] == 6) { pictureBox11.Image = Properties.Resources.p_6; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 7) { pictureBox11.Image = Properties.Resources.p_7; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 8) { pictureBox11.Image = Properties.Resources.p_8; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 9) { pictureBox11.Image = Properties.Resources.p_9; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 10) { pictureBox11.Image = Properties.Resources.p_10; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 11) { pictureBox11.Image = Properties.Resources.p_val; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 12) { pictureBox11.Image = Properties.Resources.p_dam; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 13) { pictureBox11.Image = Properties.Resources.p_kor; pictureBox11.Visible = true; }
            if (kartisopernika1[4] == 14) { pictureBox11.Image = Properties.Resources.p_tuz; pictureBox11.Visible = true; }

            if (kartisopernika1[5] == 6) { pictureBox12.Image = Properties.Resources.p_6; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 7) { pictureBox12.Image = Properties.Resources.p_7; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 8) { pictureBox12.Image = Properties.Resources.p_8; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 9) { pictureBox12.Image = Properties.Resources.p_9; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 10) { pictureBox12.Image = Properties.Resources.p_10; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 11) { pictureBox12.Image = Properties.Resources.p_val; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 12) { pictureBox12.Image = Properties.Resources.p_dam; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 13) { pictureBox12.Image = Properties.Resources.p_kor; pictureBox12.Visible = true; }
            if (kartisopernika1[5] == 14) { pictureBox12.Image = Properties.Resources.p_tuz; pictureBox12.Visible = true; }

            button1.Enabled = false;
            label3.Visible = true;
            label3.Text = "Счет соперника: " + schetsopernika;
            if (schet < 22 && schetsopernika < 22 && schet > schetsopernika && proverkapobedi == 0) { MessageBox.Show("Вы победили!", "Результат"); proverkapobedi++; }
            if (schet < 22 && schetsopernika < 22 && schet < schetsopernika && proverkapobedi == 0) { MessageBox.Show("Вы проиграли!", "Результат"); proverkapobedi++; }
            if (schet >= 22 && schetsopernika >= 22 && proverkapobedi == 0) { MessageBox.Show("Ничья!", "Результат"); proverkapobedi++; }
            if (schet == schetsopernika  && proverkapobedi == 0) { MessageBox.Show("Ничья!", "Результат"); proverkapobedi++; }
            if (schet >= 22 && schetsopernika < 22 && proverkapobedi == 0) { MessageBox.Show("Вы проиграли!", "Результат"); proverkapobedi++; }
            if (schet < 22 && schetsopernika >= 22 && proverkapobedi == 0) { MessageBox.Show("Вы победили!", "Результат"); proverkapobedi++; }
            /*if (schet < 22 & schetsopernika < 22 && proverkapobedi == 0)
            {
                proverkapobedi++;
                if (schet > schetsopernika)
                { MessageBox.Show("Вы победили!", "Результат"); }
                if (schet < schetsopernika)
                {
                    MessageBox.Show("Вы проиграли!", "Результат");
                }
            }*/
            DialogResult result =  MessageBox.Show("Еще разок?", "Game 21", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { Application.Restart(); }
            else { Close(); }}

        //кнопка "закрыть"
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        //кнопка "правила"
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 brows = new Form2();
            brows.ShowDialog();
        }

        //кнопка "правила" в меню
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form2 brows = new Form2();
                brows.ShowDialog();
            }
        }

        //кнопка "новая игра" в меню
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //кнопка "закрыть" в меню
        private void closeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
