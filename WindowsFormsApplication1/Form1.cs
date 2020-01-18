using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }
        Bitmap bmp = null;
        private void M_sifrele_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;

            if(AlgoritmaTur.SelectedIndex == 0)
            {
                //Helper.embedText(mesaj.Text, bmp);
                Steganography.embedText(mesaj.Text, bmp);
                
              //  Steganography.extractText(bmp);
            }else if(AlgoritmaTur.SelectedIndex == 1)
            {

            }

            
        }

        private void Decorator_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
            Steganography.extractText(bmp);
        }
    }
}
