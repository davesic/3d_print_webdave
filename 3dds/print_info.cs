using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3dds
{
    public partial class print_info : Form
    {
        public print_info(string data, string data_model, string data_scale, string data_matherial, string data_count, string data_image)
        {
            InitializeComponent();
            this.data = data;
            this.data_model = data_model;
            this.data_scale = data_scale;
            this.data_matherial = data_matherial;
            this.data_count = data_count;
            this.data_image = data_image;



            pictureBox1.Image = Image.FromFile(data_image);


            label1.Text = data;
            label3.Text = data_count;
            label8.Text = data_matherial;
            label9.Text = data_scale;
            label10.Text = data_model;
        }
        string data;
        string data_model;
        string data_scale;
        string data_matherial;
        string data_count;
        string data_image;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
