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

        // A FAIRE
        // GETTER SETTER DICO ET LIST
        // CONSTRUCTEUR 
        // GESTION D'EXCEPTION ?
        // CREATION FICHIER ?
        // ATTRIBUT PRIVATE OU PUBLIC 
        // SUPPRESSION VARIABLE ET GETTER SETTER A TESTER


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
                cmbBoxDictionnaire.Items.Add(item);
            }
            lblNomClasse.Text = " ";
            lblNombreVariable.Text = " ";
            lblNomClasseChoisi.Text = " ";

            this.cmbBoxListeType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxListeVariables.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxListeGetterSetter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxDictionnaire.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxDictionnaire.Enabled = false;

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

        public string CreateGetterSetter(string nameVar, string typeVar, bool getter, bool setter)
        {
            if (getter && setter)
            {
                string getters_setter = "public " + typeVar + " " + CapitalizeFirstLetter(nameVar) + " { get => _" + nameVar + "; set => _" + nameVar + "= value; }";
                return getters_setter;
            }
            else if (getter && setter == false)
            {
                string getters_setter = "public " + typeVar + " " + CapitalizeFirstLetter(nameVar) + " { return _" + nameVar + "}";
                return getters_setter;
            }
            else if (setter && getter == false)
            {
                string getters_setter = "public " + typeVar + " " + CapitalizeFirstLetter(nameVar) + "(string param) { _" + nameVar + "= param; }";
                return getters_setter;
            }
            return null;
        }
        public string CreateRegion(string nameRegion)
        {
            string region = "#region "+nameRegion;
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

        public string CreateUsings()
        {
            string usings = "using System;\n" +
                "using System.Collections.Generic; \n" +
                "using System.Linq;\n" +
                "using System.Text;\n" +
                "using System.Threding.Tasks \n \n";
            return usings;
        }

        public string CreateList(string nameVar, string typeVar)
        {
            string nameList = "List<"+typeVar+"> "+nameVar+" = new List<"+typeVar+">();";
            return nameList;
        }

        public string CreateDictionnary(string nameVar, string typeKey, string typeValue)
        {
            string nameDico = "Dictionary<" + typeKey + "," + typeValue + "> " + nameVar + " = new Dictionary<" + typeKey + "," + typeValue + ">();";
            return nameDico;
        }



        private void btnAddVar_Click(object sender, EventArgs e)
        {
            string ligneVar;
            string nameVar = "_"+txtBoxNomAttribut.Text.ToLower();
            if (txtBoxNomAttribut.Text == "" || cmbBoxListeType.SelectedItem == null)
            {
                // empêcher l'enregistrement si rien n'a été saisie ou sélectionner.
                MessageBox.Show("Veuillez saisir un nom de Variable et un Type avant de Valider", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (checkBoxDictionnaire.Checked && checkBoxList.Checked)
            {   // empêcher l'enregistrement si rien n'a été saisie ou sélectionner.
                MessageBox.Show("Veuillez ne saisir qu'un seul type de Collection avant de Valider", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkBoxList.Checked && cmbBoxListeType.SelectedItem != null)
                {
                    ligneVar = "private " + CreateList(nameVar, cmbBoxListeType.SelectedItem.ToString());

                }
                else if (checkBoxDictionnaire.Checked && cmbBoxListeType.SelectedItem != null && cmbBoxDictionnaire.SelectedItem != null)
                {
                    ligneVar = "private " + CreateDictionnary(nameVar, cmbBoxListeType.SelectedItem.ToString(), cmbBoxDictionnaire.SelectedItem.ToString());
                }
                else
                {
                    ligneVar = "private " + cmbBoxListeType.SelectedItem.ToString() + " " + nameVar;
                }
                cmbBoxListeVariables.Items.Add(ligneVar);

                string leGetterSetter = CreateGetterSetter(txtBoxNomAttribut.Text, cmbBoxListeType.SelectedItem.ToString(), checkBoxGetter.Checked, checkBoxSetter.Checked);

                if (leGetterSetter != null)
                {
                    cmbBoxListeGetterSetter.Items.Add(leGetterSetter);
                }
                lblNombreVariable.Text = cmbBoxListeVariables.Items.Count.ToString();
            }


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

        private void btnDeleteGetterSetter_Click(object sender, EventArgs e)
        {
            foreach (string leGetterSetter in cmbBoxListeGetterSetter.Items)
            {
                if (leGetterSetter.Contains(txtBoxNomAttribut.Text))
                {
                    cmbBoxListeGetterSetter.Items.Remove(leGetterSetter);
                    break;
                }
            }
            cmbBoxListeGetterSetter.SelectedItem = null;
        }

        private void btnClasseExistante_Click(object sender, EventArgs e)
        {
            string nameClass = txtBoxClasseExistante.Text.ToLower();
            int compteur = 0;
            foreach (string element in cmbBoxListeType.Items)
            {

                if (CapitalizeFirstLetter(element) == CapitalizeFirstLetter(nameClass))
                {
                    MessageBox.Show("Typage Déja Existant", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    compteur++;
                }
            }
            if (compteur == 0)
            {
                cmbBoxListeType.Items.Add(CapitalizeFirstLetter(nameClass));
                cmbBoxDictionnaire.Items.Add(CapitalizeFirstLetter(nameClass));
            }
            txtBoxClasseExistante.Clear();
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            List<string> leFichier = new List<string>();
            if(txtBoxNomClasse.Text != "")
            {
                leFichier.Add("public class " + txtBoxNomClasse.Text + "{");
                // CREATION DE LA REGION ATTRIBUTS
                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateRegion("Attributs"));


                foreach (string attributs in cmbBoxListeVariables.Items)
                {
                    leFichier.Add(attributs + ";");
                }



                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateEndRegion());
                // FIN REGION ATTRIBUTS



                // CREATION REGION CONSTRUCTEUR
                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateRegion("Constructeur"));

                if (checkBoxConstructeur.Checked == true)
                {
                    leFichier.Add(CreateConstructeur(txtBoxNomClasse.Text));
                }

                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateEndRegion());
                // CREATION FIN REGION CONSTRUCTEUR





                // CREATION REGION GETTER SETTER
                if (checkBoxRegion.Checked == true)
                    leFichier.Add(CreateRegion("Getter Setter"));

                if (checkBoxGetter.Checked == true)
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
                    leFichier.Add(CreateRegion("Méthodes"));



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

        private void checkBoxDictionnaire_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDictionnaire.Checked)
            {
                cmbBoxDictionnaire.Enabled = true;
            }
            else
            {
                cmbBoxDictionnaire.Enabled = false;
            }
        }
    }
}
