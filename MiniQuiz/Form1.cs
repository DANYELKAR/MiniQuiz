using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, dogru, yanlis = 0;


        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "C# ne zaman piyasaya sürülmüştür?";
                BtnA.Text = "1996";
                BtnB.Text = "1998";
                BtnC.Text = "2000";
                BtnD.Text = "2002";
                label4.Text = "2002";

            }

            if (soruno == 2)
            {
                richTextBox1.Text = "C# kimin ekibi tarafından geliştirilmiştir?";
                BtnA.Text = "Anders Heljsberg";
                BtnB.Text = "Muhammed Güven";
                BtnC.Text = "Mustafa Orbağ";
                BtnD.Text = "Ali Ünaldı";
                label4.Text = "Anders Heljsberg";

            }

            if (soruno == 3)
            {
                richTextBox1.Text = "C#'ta hangisi bir sınıf üyesi için varsayılan erişim tanımlayıcısıdır?";
                BtnA.Text = "Public";
                BtnB.Text = "Private";
                BtnC.Text = "Internal";
                BtnD.Text = "Protected";
                label4.Text = "Private";

            }

            if (soruno == 4)
            {
                richTextBox1.Text = "C#'ta Enum ile aşağıdaki veri türlerinden hangisi kullanılabilir?";
                BtnA.Text = "String";
                BtnB.Text = "Double";
                BtnC.Text = "Integer";
                BtnD.Text = "Boolean";
                label4.Text = "Integer";

            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Aşağıdaki C # anahtar sözcüklerinden hangisinin çoklu okuma ile ilgisi yoktur?";
                BtnA.Text = "Async";
                BtnB.Text = "Await";
                BtnC.Text = "Sealed";
                BtnD.Text = "Lock";
                label4.Text = "Sealed";

            }

            if (soruno == 6)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                MessageBox.Show("Doğru Sayısı: " + dogru + "\n" + "Yanlış Sayısı: " +yanlis );
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
               yanlis++;
               LblYanlış.Text = yanlis.ToString();
               pictureBox2.Visible = true;
            }

        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlış.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlış.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlış.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

    }
}
