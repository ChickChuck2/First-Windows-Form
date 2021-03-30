using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer somzao = new SoundPlayer(@"c:\Windows\Media\chimes.wav");

            MessageBox.Show("Botão foi clicado caralho");

            somzao.Play();

            texto1.Text = "Procuro sexo";

            progressBar1.Value = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            progressBar1.Value =  76;

            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x);


            foreach (int num in squares)
            {
                Console.WriteLine(num);

                Control control = (Control)sender;
                var name = control.Name;


                DialogResult resultado = MessageBox.Show($"Eu cliquei no {name} E mostrei essa porra aqui {num}", "SEXO ANAL",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign, false);

                //MessageBox.Show(String.Format("Eu cliquei no {0} E mostrei essa porra aqui {1}", name, num));

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("Parabéns viu, seu coco");
                    break;
                }
                else
                {
                    MessageBox.Show("VAI TOMAR NO TEU CU");
                }
            }
            MessageBox.Show($"PRONTO PORRA, VOCÊ FEZ TUDO CERTO", "FASE 1 COMPLETA");

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
