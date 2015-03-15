using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CalculadoraRecursiva
{
    public partial class Form1 : Form
    {
        public double b;
        public List<double> list = new List<double>();
        public double numb;

        public Form1()
        {
            InitializeComponent();
        }
       
        public double recursive(double num)
        {
            double result; 

            if (num == 0) return 1;
            
            result = num * recursive(num - 1);
            

            return result;
        }
        
        public void iterativo()
        {
            for (int i = 0; i < numb; i++)
            {
                list.Add(i+1);
            }
            for (int i = 0; i < list.Count; i++)
            {
                list[0] = list[0] * list[i];
                Debug.Print(list[0].ToString());
            }

        }

        /*public void fiboiterativo (num)
        {
        
        }*/

        private void bt_Click(object sender, EventArgs e)
        {
            visor.Text = "";
            double numero = recursive(Double.Parse(visor2.Text));
            visor.Text = "Resultado: " + numero.ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            visor.Text = "";
            numb = Double.Parse(visor2.Text);
            iterativo();
            visor.Text = list[0].ToString();
            list.Clear();
        }

        private void visor2_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !Char.IsNumber(e.KeyChar) && e.KeyChar != 8;

        }
    }
}
