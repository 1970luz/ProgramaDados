using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaDados
{
    public partial class FormCarasdeDados : Form
    {
        public FormCarasdeDados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btrReinicar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //se declaran las dos variables para cada dado

            int dados1 = 0;
            int dados2 = 0;
            //se declara un metodo aleatorio
            Random dadoaleatorio = new Random();

            //se ejecuta   y obtienen los numeros aleatorios para cada dado
            dados1 = dadoaleatorio.Next(1, 7);
            dados2 = dadoaleatorio.Next(1, 7);

            //para dado1
            if (dados1 == 1)
            {

                pictureBox1.Image = Image.FromFile("cara1.jpg");
            }
            if (dados1 == 2)
            {
                pictureBox1.Image = Image.FromFile("cara2.jpg");
            }
            if (dados1 == 3)
            {
                pictureBox1.Image = Image.FromFile("cara3.jpg");
            }
            if (dados1 == 4)
            {
                pictureBox1.Image = Image.FromFile("cara4.jpg");
            }
            if (dados1 == 5)
            {
                pictureBox1.Image = Image.FromFile("cara5.jpg");
            }
            if (dados1 == 6)
            {
                pictureBox1.Image = Image.FromFile("cara6.jpg");
            }

          ;

            //para dado2
            if (dados2 == 1)
            {

                pictureBox2.Image = Image.FromFile("cara1.jpg");
            }
            if (dados2 == 2)
            {
                pictureBox2.Image = Image.FromFile("cara2.jpg");
            }
            if (dados2 == 3)
            {
                pictureBox2.Image = Image.FromFile("cara3.jpg");
            }
            if (dados2 == 4)
            {
                pictureBox2.Image = Image.FromFile("cara4.jpg");
            }
            if (dados2 == 5)
            {
                pictureBox2.Image = Image.FromFile("cara5.jpg");
            }
            if (dados2 == 6)
            {
                pictureBox2.Image = Image.FromFile("cara6.jpg");
            }
            //se agregan los numeros aleatorios generados en la tirada
            ListViewItem item1 = new ListViewItem(dados1.ToString(), listView1.Items.Count - 1);
            item1.SubItems.Add(dados2.ToString());
            listView1.Items.Add(item1);

        }
    }
}
