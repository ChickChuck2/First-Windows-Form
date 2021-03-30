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
            somzao.Play();

            MessageBox.Show("Botão foi clicado caralho");

            texto1.Text = "Procuro sexo";

            barradeprogresso.Value = 50;

            if (sexoradio.Checked)
            {
                MessageBox.Show(String.Format("Você clicou no {0}", sexoradio.Name));
            }
            if (loboradio2.Checked)
            {
                MessageBox.Show(String.Format("Traga a champanhe, o cara aqui e um filha da puta, e esse filha da puta clicou em {0}", loboradio2.Text));
            }
            if (pairado.Checked)
            {
                MessageBox.Show(String.Format("PARA CAMINHAR NO {0}", pairado.Name));
            }
            if (atumakkkk.Checked)
            {
                MessageBox.Show(String.Format("ATUMALACA KKK {0}", atumakkkk.Name));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            barradeprogresso.Value =  76;

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

        private void radioButton1_CheckedChanged(Object sender,EventArgs e)
        {

        }


    }
}
