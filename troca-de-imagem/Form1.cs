using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace troca_de_imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            this.DogPicBox.Visible = true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            this.DogPicBox.Visible = false;
        }

        private void buttonMostrar2_Click(object sender, EventArgs e)
        {
            this.CatDogPicBox.Visible = true;
        }

        private void buttonApagar2_Click(object sender, EventArgs e)
        {
            this.CatDogPicBox.Visible = false;
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.CatDogPicBox.Visible = false;
            this.DogPicBox.Visible = false;
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            this.CatDogPicBox.Visible = true;
            this.DogPicBox.Visible = true;

        }
    }
}
