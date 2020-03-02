using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appframe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClickFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files(*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"Desktop";

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBox.ImageLocation = textBoxFilePath.Text;
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);
            
            for(int i = 0; i < img.Width; i++)
            {
                for(int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < textBoxMessage.TextLength)
                    {
                        Console.WriteLine("R = [" +i + "][" +j + "] = ” +pixel.R");
                        Console.WriteLine("G = [" +i + "][" +j + "] = ” +pixel.G");
                        Console.WriteLine("G = [" +i + "][" +j + "] = ” +pixel.B");

                        char letter = Convert.ToChar(textBoxMessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter: " +letter + "value: " +value);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                    if(i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.B, textBoxMessage.TextLength));
                    }
                }   
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.png,*.jpg) | *.png; *.jpg";
            saveFile.InitialDirectory = @"Desktop";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = saveFile.FileName.ToString();
                pictureBox.ImageLocation = textBoxFilePath.Text;
                img.Save(textBoxFilePath.Text);
            }

        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);
            string message = "";

            Color lastPixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int messageLength = lastPixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < messageLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }

            textBoxMessage.Text = message;

        }
    }
}
