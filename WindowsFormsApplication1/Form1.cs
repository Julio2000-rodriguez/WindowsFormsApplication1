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

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            sbyte num1 = sbyte.Parse(txtNum1.Text);
            sbyte num2 = sbyte.Parse(txtNum2.Text);
            sbyte respuesta = 0;

            if (optSuma.Checked {
                respuesta = num1+num2;
            }
               if(optResta.Checked {
                respuesta = num1 - num2;
            }
            if (optMult.Checked {
                respuesta = num1 * num2; 
            }
            if (optDivis.Checked){
                respuesta = num1 / num2;
            }
            lblRespuesta.Text = "respuesta: " + respuesta;
        }
    }
}
