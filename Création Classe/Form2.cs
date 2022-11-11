using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Création_Classe
{
    public partial class Form2 : Form
    {

        List<string> codeLines = new List<string>();

        public Form2(List<string> laListe)
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach(string codeLine in codeLines)
            {
                textBox1.Text = string.Join(Environment.NewLine,codeLine);
            }
        }
    }
}
