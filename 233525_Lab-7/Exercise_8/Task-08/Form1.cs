using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_08
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentImageIndex= 0;
        private Timer slideshowTimer;

        public Form1()
        {
            InitializeComponent();
            slideshowTimer = new Timer();
            slideshowTimer.Interval = 1000; 
            slideshowTimer.Tick += SlideshowTimer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                textBox1.Text = folderPath;

                // Get all image files in the selected folder
                imageFiles = Directory.GetFiles(folderPath, "*.png"); // You can add more image formats as needed

                if (imageFiles.Length > 0)
                {
                    label2.Text = "Total Photos: " + imageFiles.Length;
                    pictureBox1.Image = Image.FromFile(imageFiles[0]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                // Move to the next image
                currentImageIndex = (currentImageIndex + 1) % imageFiles.Length;
                pictureBox1.Image = Image.FromFile(imageFiles[currentImageIndex]);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                if (slideshowTimer.Enabled)
                {
                    slideshowTimer.Stop();
                    button4.Text = "Start Slideshow";
                }
                else
                {
                    slideshowTimer.Start();
                    button4.Text = "Stop Slideshow";
                }
            }
        }

        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            button2_Click(sender, e); // Trigger the next image button click
        }


    }
}
