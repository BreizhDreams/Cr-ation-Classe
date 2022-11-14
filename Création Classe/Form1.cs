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
        Structure laStructure = new Structure();
        public Form1()
        {
            InitializeComponent();
        }

        // A FAIRE
        // CONSTRUCTEUR 
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
                laStructure.CollType.Add(item);
            }
            lblNombreVariable.Text = " ";
            lblNomClasseChoisi.Text = " ";

            this.cmbBoxListeType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxListeVariables.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxListeGetterSetter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxDictionnaire.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxDictionnaire.Enabled = false;

        }

        // Ajout de la Variables avec les configurations choisis par l'utilisateur (Getter / Setter)
        private void btnAddVar_Click(object sender, EventArgs e)
        {
            bool varExistante = laStructure.CheckVarExistante(txtBoxNomAttribut.Text);
            string ligneVar, leGetterSetter;
            string nameVar = "_" + txtBoxNomAttribut.Text.ToLower();
            if (txtBoxNomAttribut.Text == "" || cmbBoxListeType.SelectedItem == null)
            {
                // empêcher l'enregistrement si rien n'a été saisie ou sélectionner.
                MessageBox.Show("Veuillez saisir un nom de Variable et un Type avant de Valider", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (varExistante == true)
            {
                MessageBox.Show("Cette Variable existe Déja", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkBoxList.Checked && cmbBoxListeType.SelectedItem != null)
                {
                    ligneVar = "private " + laStructure.CreateList(nameVar, cmbBoxListeType.SelectedItem.ToString());

                }
                else if (checkBoxDictionnaire.Checked && cmbBoxListeType.SelectedItem != null && cmbBoxDictionnaire.SelectedItem != null)
                {
                    ligneVar = "private " + laStructure.CreateDictionnary(nameVar, cmbBoxListeType.SelectedItem.ToString(), cmbBoxDictionnaire.SelectedItem.ToString());
                }
                else
                {
                    ligneVar = "private " + cmbBoxListeType.SelectedItem.ToString() + " " + nameVar + ";";
                }
                cmbBoxListeVariables.Items.Add(ligneVar);
                if (checkBoxDictionnaire.Checked)
                {
                    leGetterSetter = laStructure.CreateGetterSetter(txtBoxNomAttribut.Text, cmbBoxListeType.SelectedItem.ToString(), checkBoxGetter.Checked, checkBoxSetter.Checked, checkBoxList.Checked, checkBoxDictionnaire.Checked, cmbBoxDictionnaire.SelectedItem.ToString());
                }
                else
                {
                    leGetterSetter = laStructure.CreateGetterSetter(txtBoxNomAttribut.Text, cmbBoxListeType.SelectedItem.ToString(), checkBoxGetter.Checked, checkBoxSetter.Checked);
                }
                if (leGetterSetter != null)
                {
                    cmbBoxListeGetterSetter.Items.Add(leGetterSetter);
                }
                laStructure.CollVariables.Add(txtBoxNomAttribut.Text);
                lblNombreVariable.Text = cmbBoxListeVariables.Items.Count.ToString();

            }
            clearData();

        }

        // Apparition du nom de la Classe dans la conf Actuelle
        private void txtBoxNomClasse_TextChanged(object sender, EventArgs e)
        {
            lblNomClasseChoisi.Text = txtBoxNomClasse.Text.ToString();
        }

        // Suppression d'une variable par l'utilisateur
        private void btnSuppVar_Click(object sender, EventArgs e)
        {
            if (cmbBoxListeVariables.SelectedItem != null)
            {
                string laVarAEnlever = cmbBoxListeVariables.SelectedItem.ToString();
                cmbBoxListeVariables.Items.Remove(cmbBoxListeVariables.SelectedItem.ToString());
                lblNombreVariable.Text = cmbBoxListeVariables.Items.Count.ToString();
                foreach(string laVar in laStructure.CollVariables)
                {
                    if (laVarAEnlever.Contains(laVar))
                    {
                        laStructure.CollVariables.Remove(laVar);
                        break;
                    }
                }
            }
        }

        // Suppression d'un Getter Setter par l'utilisateur
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

        // Ajout d'un nouveau Type Objet par l'utilisateur
        private void btnClasseExistante_Click(object sender, EventArgs e)
        {
            string nameClass = txtBoxClasseExistante.Text.ToLower();
            if (laStructure.CheckTypeExistant(txtBoxClasseExistante.Text) == true)
            {
                MessageBox.Show("Typage Déja Existant", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(txtBoxClasseExistante.Text == "")
            {
                MessageBox.Show("Veuillez Saisir un Type avant de Valider", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmbBoxListeType.Items.Add(laStructure.CapitalizeFirstLetter(nameClass));
                cmbBoxDictionnaire.Items.Add(laStructure.CapitalizeFirstLetter(nameClass));
                laStructure.CollType.Add(laStructure.CapitalizeFirstLetter(nameClass));
            }
            txtBoxClasseExistante.Clear();
        }



        // Bloque ou Autorise le checkbox de la Liste si on coche/décoche le checkbox Dico
        private void checkBoxDictionnaire_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDictionnaire.Checked)
            {
                cmbBoxDictionnaire.Enabled = true;
                checkBoxList.Enabled = false;
            }
            else
            {
                cmbBoxDictionnaire.Enabled = false;
                checkBoxList.Enabled = true;
            }
        }

        // Bloque ou Autorise le checkbox du dico si on coche/décoche le checkbox Liste
        private void checkBoxList_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxList.Checked)
            {
                checkBoxDictionnaire.Enabled = false;
            }
            else
            {
                checkBoxDictionnaire.Enabled = true;
            }
        }

        // Efface les données dans le formulaire
        private void clearData()
        {
            txtBoxNomAttribut.Clear();
            checkBoxList.Checked = false;
            cmbBoxListeType.SelectedIndex = -1;
            cmbBoxDictionnaire.SelectedIndex = -1;
        }

        // Création de la Classe
        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            List<string> leFichier = new List<string>();
            if (txtBoxNomClasse.Text != "")
            {
                leFichier.Add(laStructure.CreateUsings());
                leFichier.Add(laStructure.CreateRegion("Attributs"));
                foreach(string element in cmbBoxListeVariables.Items)
                {
                    leFichier.Add("    "+element);
                }
                leFichier.Add(laStructure.CreateEndRegion());
                leFichier.Add(laStructure.CreateRegion("Constructeur"));
                leFichier.Add(laStructure.CreateConstructeur(lblNomClasseChoisi.Text));
                leFichier.Add(laStructure.CreateEndRegion());
                leFichier.Add(laStructure.CreateRegion("Getter Setter"));
                foreach (string element in cmbBoxListeGetterSetter.Items)
                {
                    leFichier.Add("    " + element);
                }
                leFichier.Add(laStructure.CreateEndRegion());
                leFichier.Add(laStructure.CreateRegion("Méthodes"));

                leFichier.Add(laStructure.CreateEndRegion());




                Form2 leForm2 = new Form2(leFichier);
                leForm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nom de classe avant de créer le fichier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameClass = txtBoxNomClasse.Text.ToLower();
            if (laStructure.CheckTypeExistant(txtBoxNomClasse.Text) == true)
            {
                MessageBox.Show("Typage Déja Existant", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtBoxNomClasse.Text == "")
            {
                MessageBox.Show("Veuillez Saisir le nom de la classe avant d'Ajouter", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmbBoxListeType.Items.Add(laStructure.CapitalizeFirstLetter(nameClass));
                cmbBoxDictionnaire.Items.Add(laStructure.CapitalizeFirstLetter(nameClass));
                laStructure.CollType.Add(laStructure.CapitalizeFirstLetter(nameClass));
            }
        }
    }


}
