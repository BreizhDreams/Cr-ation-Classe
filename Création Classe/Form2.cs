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
            codeLines = laListe;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Multiline = true;
            foreach (string line in codeLines)
            {
                richTextBox1.AppendText(Environment.NewLine + line);
            }
        }

    }
}
