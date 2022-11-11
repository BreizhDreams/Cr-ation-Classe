using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Création_Classe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CapitalizeFirstLetter(string varName)
        {
            if (varName[0] != '_')
            {
                string var = $"{varName[0].ToString().ToUpper()}{varName.Substring(1)}";
                return var;
            }
            else
            {
                string var = $"{varName[1].ToString().ToUpper()}{varName.Substring(2)}";
                return var;
            }

        }

        public string CreateGetterSetter(string nameVar, string typeVar)
        {
            string getters_setter = "public " + typeVar + " " + CapitalizeFirstLetter(nameVar) +" { get => "+nameVar+"; set => "+nameVar + "= value; }";
            return getters_setter;
        }
        public string CreateRegion()
        {
            string region = "#region";
            return region;
        }

        public string CreateEndRegion()
        {
            string endregion = "#endregion";
            return endregion;
        }
        public string CreateConstructeur(string nameClasse)
        {
            string constructeur = "public " + nameClasse + "() {}";
            return constructeur;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataSource = new List<string>();

            dataSource.Add("string");
            dataSource.Add("int");
            dataSource.Add("double");
            dataSource.Add("bool");
            dataSource.Add("DateTime");

            foreach (string item in dataSource)
            {
                cmbBoxListeType.Items.Add(item);
            }
            lblNomClasse.Text = " ";
            lblNombreVariable.Text = " ";

            this.cmbBoxListeType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxListeVariables.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxListeGetterSetter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAddVar_Click(object sender, EventArgs e)
        {
            string nameVar = "_"+txtBoxNomAttribut.Text;
            if (txtBoxNomAttribut.Text != "" && cmbBoxListeType.SelectedItem != null)
            {
                string ligneVar = "private "+cmbBoxListeType.SelectedItem.ToString() + " " + nameVar;
                cmbBoxListeVariables.Items.Add(ligneVar);
            }
            else 
            {   // empêcher l'enregistrement si rien n'a été saisie ou sélectionner.
                MessageBox.Show("Veuillez saisir un nom de Variable et un Type avant de Valider", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(checkBoxGetterSetter.Checked == true)
            {
                string leGetterSetter=CreateGetterSetter(txtBoxNomAttribut.Text, cmbBoxListeType.SelectedItem.ToString());
                cmbBoxListeGetterSetter.Items.Add(leGetterSetter);
            }
            lblNombreVariable.Text = cmbBoxListeVariables.Items.Count.ToString();

        }

        private void txtBoxNomClasse_TextChanged(object sender, EventArgs e)
        {
            lblNomClasseChoisi.Text = txtBoxNomClasse.Text.ToString();
        }

        private void btnSuppVar_Click(object sender, EventArgs e)
        {
            if (cmbBoxListeVariables.SelectedItem != null)
            {
                cmbBoxListeVariables.Items.Remove(cmbBoxListeVariables.SelectedItem.ToString());
                lblNombreVariable.Text = cmbBoxListeVariables.Items.Count.ToString();
                cmbBoxListeVariables.SelectedItem = null;
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            List<string> leFichier = new List<string>();
            if(txtBoxNomClasse.Text != "")
            {
                leFichier.Add("public class " + txtBoxNomClasse.Text + "{");
                // CREATION DE LA REGION ATTRIBUTS
                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateRegion() + " Attributs");


                foreach (string attributs in cmbBoxListeVariables.Items)
                {
                    leFichier.Add(attributs + ";");
                }



                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateEndRegion());
                // FIN REGION ATTRIBUTS



                // CREATION REGION CONSTRUCTEUR
                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateRegion() + " Constructeur");

                if (checkBoxConstructeur.Checked == true)
                {
                    leFichier.Add(CreateConstructeur(txtBoxNomClasse.Text));
                }

                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateEndRegion());
                // CREATION FIN REGION CONSTRUCTEUR





                // CREATION REGION GETTER SETTER
                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateRegion() + " Getter/Setter");

                if (checkBoxGetterSetter.Checked == true)
                {
                    foreach (string getterSetter in cmbBoxListeGetterSetter.Items)
                    {
                        leFichier.Add(getterSetter);
                    }
                }

                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateEndRegion());
                // CREATION FIN REGION GETTER SETTER






                // CREATION REGION METHODES
                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateRegion() + " Méthodes");



                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateEndRegion());
                // CREATION FIN REGION METHODES


                // MOUSTACHE FERMANT LA CLASSE
                leFichier.Add("}");

                Form2 leForm2 = new Form2(leFichier);
                leForm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nom de classe avant de créer le fichier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDeleteGetterSetter_Click(object sender, EventArgs e)
        {
            foreach(string leGetterSetter in cmbBoxListeGetterSetter.Items)
            {
                if (leGetterSetter.Contains(txtBoxNomAttribut.Text))
                {
                    cmbBoxListeGetterSetter.Items.Remove(leGetterSetter);
                    break;
                }
            }
            cmbBoxListeGetterSetter.SelectedItem = null;
        }
    }
}
