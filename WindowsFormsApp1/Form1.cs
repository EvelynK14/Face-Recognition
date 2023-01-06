using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FaceRec faceRec= new FaceRec();

        private void button2_Click(object sender, EventArgs e) //open camera
        {
            faceRec.openCamera(pictureBox2, pictureBox1);

        }

        private void button3_Click(object sender, EventArgs e) //save image
        {
            faceRec.Save_IMAGE(textBox1.Text);
            MessageBox.Show("Image saved.");

            //faceRec.Save_IMAGE("Image_withoutfileextension");
        }

        private void button1_Click(object sender, EventArgs e) //detec face
        {
            faceRec.isTrained= true;
        }
    }
}
