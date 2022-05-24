using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpfOuCpnj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedtxt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radiobtn_cpf_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn_cpf.Checked)
            {
                maskedtxt.Mask = "###.###.###-##";

            }

            else
            {
                if(radiobtn_cnpj.Checked){
                    maskedtxt.Mask = "##.###.###/####-##";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radiobtn_cnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtn_cpf.Checked)
            {
                maskedtxt.Mask = "###.###.###-##";

            }

            else
            {
                if (radiobtn_cnpj.Checked)   //se o radio de cnpj estiver selecionado.
                {
                    maskedtxt.Mask = "##.###.###/####-##"; //o mask ficará desta forma
                }
            }
        }

        private void maskedtxt_Leave(object sender, EventArgs e)
        {
            if (radiobtn_cpf.Checked)
            {
                //MessagegeBox.Show(numero.toString());

                int[] numeros;
                numeros = new int[9];

                numeros[0] = int.Parse(numeros.Substring(0, 1));
                numeros[1] = int.Parse(numeros.Substring(1, 1));
                numeros[2] = int.Parse(numeros.Substring(2, 1));
                numeros[3] = int.Parse(numeros.Substring(4, 1));
                numeros[4] = int.Parse(numeros.Substring(5, 1));
                numeros[5] = int.Parse(numeros.Substring(6, 1));
                numeros[6] = int.Parse(numeros.Substring(8, 1));
                numeros[7] = int.Parse(numeros.Substring(9, 1));
                numeros[8] = int.Parse(numeros.Substring(10, 1));

            }
        }
    }
}
