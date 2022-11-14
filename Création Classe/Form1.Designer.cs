namespace Création_Classe
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNomClasse = new System.Windows.Forms.Label();
            this.txtBoxNomClasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNomAttribut = new System.Windows.Forms.TextBox();
            this.cmbBoxListeType = new System.Windows.Forms.ComboBox();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.lblListeVariables = new System.Windows.Forms.Label();
            this.cmbBoxListeVariables = new System.Windows.Forms.ComboBox();
            this.btnSuppVar = new System.Windows.Forms.Button();
            this.checkBoxGetter = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreVariable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNomClasseChoisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxListeGetterSetter = new System.Windows.Forms.ComboBox();
            this.btnDeleteGetterSetter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClasseExistante = new System.Windows.Forms.Label();
            this.txtBoxClasseExistante = new System.Windows.Forms.TextBox();
            this.checkBoxSetter = new System.Windows.Forms.CheckBox();
            this.btnClasseExistante = new System.Windows.Forms.Button();
            this.checkBoxList = new System.Windows.Forms.CheckBox();
            this.checkBoxDictionnaire = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBoxDictionnaire = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(195, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(453, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "FORMULAIRE DE CREATION DE CLASSE";
            // 
            // lblNomClasse
            // 
            this.lblNomClasse.AutoSize = true;
            this.lblNomClasse.Location = new System.Drawing.Point(42, 145);
            this.lblNomClasse.Name = "lblNomClasse";
            this.lblNomClasse.Size = new System.Drawing.Size(98, 13);
            this.lblNomClasse.TabIndex = 1;
            this.lblNomClasse.Text = "Nom de la Classe : ";
            // 
            // txtBoxNomClasse
            // 
            this.txtBoxNomClasse.Location = new System.Drawing.Point(43, 169);
            this.txtBoxNomClasse.Name = "txtBoxNomClasse";
            this.txtBoxNomClasse.Size = new System.Drawing.Size(140, 20);
            this.txtBoxNomClasse.TabIndex = 2;
            this.txtBoxNomClasse.TextChanged += new System.EventHandler(this.txtBoxNomClasse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom de la Variable :";
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Location = new System.Drawing.Point(643, 388);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(104, 37);
            this.btnCreateClass.TabIndex = 4;
            this.btnCreateClass.Text = "Générer le Code";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type de la Variable : ";
            // 
            // txtBoxNomAttribut
            // 
            this.txtBoxNomAttribut.Location = new System.Drawing.Point(265, 169);
            this.txtBoxNomAttribut.Name = "txtBoxNomAttribut";
            this.txtBoxNomAttribut.Size = new System.Drawing.Size(124, 20);
            this.txtBoxNomAttribut.TabIndex = 9;
            // 
            // cmbBoxListeType
            // 
            this.cmbBoxListeType.FormattingEnabled = true;
            this.cmbBoxListeType.Location = new System.Drawing.Point(265, 279);
            this.cmbBoxListeType.Name = "cmbBoxListeType";
            this.cmbBoxListeType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxListeType.TabIndex = 11;
            // 
            // btnAddVar
            // 
            this.btnAddVar.Location = new System.Drawing.Point(269, 388);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(121, 23);
            this.btnAddVar.TabIndex = 12;
            this.btnAddVar.Text = "Ajouter la Variable";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // lblListeVariables
            // 
            this.lblListeVariables.AutoSize = true;
            this.lblListeVariables.Location = new System.Drawing.Point(467, 234);
            this.lblListeVariables.Name = "lblListeVariables";
            this.lblListeVariables.Size = new System.Drawing.Size(145, 13);
            this.lblListeVariables.TabIndex = 13;
            this.lblListeVariables.Text = "Liste des Variables Ajoutées :";
            // 
            // cmbBoxListeVariables
            // 
            this.cmbBoxListeVariables.FormattingEnabled = true;
            this.cmbBoxListeVariables.Location = new System.Drawing.Point(470, 249);
            this.cmbBoxListeVariables.Name = "cmbBoxListeVariables";
            this.cmbBoxListeVariables.Size = new System.Drawing.Size(277, 21);
            this.cmbBoxListeVariables.TabIndex = 14;
            // 
            // btnSuppVar
            // 
            this.btnSuppVar.Location = new System.Drawing.Point(670, 278);
            this.btnSuppVar.Name = "btnSuppVar";
            this.btnSuppVar.Size = new System.Drawing.Size(77, 21);
            this.btnSuppVar.TabIndex = 15;
            this.btnSuppVar.Text = "Supprimer";
            this.btnSuppVar.UseVisualStyleBackColor = true;
            this.btnSuppVar.Click += new System.EventHandler(this.btnSuppVar_Click);
            // 
            // checkBoxGetter
            // 
            this.checkBoxGetter.AutoSize = true;
            this.checkBoxGetter.Location = new System.Drawing.Point(268, 339);
            this.checkBoxGetter.Name = "checkBoxGetter";
            this.checkBoxGetter.Size = new System.Drawing.Size(107, 17);
            this.checkBoxGetter.TabIndex = 16;
            this.checkBoxGetter.Text = "Génerer le Getter";
            this.checkBoxGetter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "NOUVELLE CLASSE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 93);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "NOUVELLES VARIABLES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nom de Classe Choisie :";
            // 
            // lblNombreVariable
            // 
            this.lblNombreVariable.AutoSize = true;
            this.lblNombreVariable.Location = new System.Drawing.Point(695, 199);
            this.lblNombreVariable.Name = "lblNombreVariable";
            this.lblNombreVariable.Size = new System.Drawing.Size(52, 13);
            this.lblNombreVariable.TabIndex = 22;
            this.lblNombreVariable.Text = "leNombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nombre de Variable Créer :";
            // 
            // lblNomClasseChoisi
            // 
            this.lblNomClasseChoisi.AutoSize = true;
            this.lblNomClasseChoisi.Location = new System.Drawing.Point(695, 169);
            this.lblNomClasseChoisi.Name = "lblNomClasseChoisi";
            this.lblNomClasseChoisi.Size = new System.Drawing.Size(37, 13);
            this.lblNomClasseChoisi.TabIndex = 24;
            this.lblNomClasseChoisi.Text = "leNom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Liste des Getter Setter Ajoutés :";
            // 
            // cmbBoxListeGetterSetter
            // 
            this.cmbBoxListeGetterSetter.FormattingEnabled = true;
            this.cmbBoxListeGetterSetter.Location = new System.Drawing.Point(470, 322);
            this.cmbBoxListeGetterSetter.Name = "cmbBoxListeGetterSetter";
            this.cmbBoxListeGetterSetter.Size = new System.Drawing.Size(277, 21);
            this.cmbBoxListeGetterSetter.TabIndex = 26;
            // 
            // btnDeleteGetterSetter
            // 
            this.btnDeleteGetterSetter.Location = new System.Drawing.Point(670, 349);
            this.btnDeleteGetterSetter.Name = "btnDeleteGetterSetter";
            this.btnDeleteGetterSetter.Size = new System.Drawing.Size(77, 21);
            this.btnDeleteGetterSetter.TabIndex = 27;
            this.btnDeleteGetterSetter.Text = "Supprimer";
            this.btnDeleteGetterSetter.UseVisualStyleBackColor = true;
            this.btnDeleteGetterSetter.Click += new System.EventHandler(this.btnDeleteGetterSetter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 93);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(212, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "CONFIGURATION ACTUELLE";
            // 
            // lblClasseExistante
            // 
            this.lblClasseExistante.AutoSize = true;
            this.lblClasseExistante.Location = new System.Drawing.Point(42, 259);
            this.lblClasseExistante.Name = "lblClasseExistante";
            this.lblClasseExistante.Size = new System.Drawing.Size(79, 13);
            this.lblClasseExistante.TabIndex = 29;
            this.lblClasseExistante.Text = "Nom Du Type :";
            // 
            // txtBoxClasseExistante
            // 
            this.txtBoxClasseExistante.Location = new System.Drawing.Point(43, 280);
            this.txtBoxClasseExistante.Name = "txtBoxClasseExistante";
            this.txtBoxClasseExistante.Size = new System.Drawing.Size(140, 20);
            this.txtBoxClasseExistante.TabIndex = 30;
            // 
            // checkBoxSetter
            // 
            this.checkBoxSetter.AutoSize = true;
            this.checkBoxSetter.Location = new System.Drawing.Point(269, 362);
            this.checkBoxSetter.Name = "checkBoxSetter";
            this.checkBoxSetter.Size = new System.Drawing.Size(106, 17);
            this.checkBoxSetter.TabIndex = 31;
            this.checkBoxSetter.Text = "Génerer le Setter";
            this.checkBoxSetter.UseVisualStyleBackColor = true;
            // 
            // btnClasseExistante
            // 
            this.btnClasseExistante.Location = new System.Drawing.Point(43, 313);
            this.btnClasseExistante.Name = "btnClasseExistante";
            this.btnClasseExistante.Size = new System.Drawing.Size(140, 37);
            this.btnClasseExistante.TabIndex = 33;
            this.btnClasseExistante.Text = "Ajouter le Type Aux Types Possibles";
            this.btnClasseExistante.UseVisualStyleBackColor = true;
            this.btnClasseExistante.Click += new System.EventHandler(this.btnClasseExistante_Click);
            // 
            // checkBoxList
            // 
            this.checkBoxList.AutoSize = true;
            this.checkBoxList.Location = new System.Drawing.Point(268, 215);
            this.checkBoxList.Name = "checkBoxList";
            this.checkBoxList.Size = new System.Drawing.Size(48, 17);
            this.checkBoxList.TabIndex = 34;
            this.checkBoxList.Text = "Liste";
            this.checkBoxList.UseVisualStyleBackColor = true;
            this.checkBoxList.CheckedChanged += new System.EventHandler(this.checkBoxList_CheckedChanged);
            // 
            // checkBoxDictionnaire
            // 
            this.checkBoxDictionnaire.AutoSize = true;
            this.checkBoxDictionnaire.Location = new System.Drawing.Point(268, 236);
            this.checkBoxDictionnaire.Name = "checkBoxDictionnaire";
            this.checkBoxDictionnaire.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDictionnaire.TabIndex = 35;
            this.checkBoxDictionnaire.Text = "Dictionnaire";
            this.checkBoxDictionnaire.UseVisualStyleBackColor = true;
            this.checkBoxDictionnaire.CheckedChanged += new System.EventHandler(this.checkBoxDictionnaire_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Collections :";
            // 
            // cmbBoxDictionnaire
            // 
            this.cmbBoxDictionnaire.FormattingEnabled = true;
            this.cmbBoxDictionnaire.Location = new System.Drawing.Point(265, 306);
            this.cmbBoxDictionnaire.Name = "cmbBoxDictionnaire";
            this.cmbBoxDictionnaire.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDictionnaire.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Ajout en Tant que Type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBoxDictionnaire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxDictionnaire);
            this.Controls.Add(this.checkBoxList);
            this.Controls.Add(this.btnClasseExistante);
            this.Controls.Add(this.checkBoxSetter);
            this.Controls.Add(this.txtBoxClasseExistante);
            this.Controls.Add(this.lblClasseExistante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteGetterSetter);
            this.Controls.Add(this.cmbBoxListeGetterSetter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNomClasseChoisi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNombreVariable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxGetter);
            this.Controls.Add(this.btnSuppVar);
            this.Controls.Add(this.cmbBoxListeVariables);
            this.Controls.Add(this.lblListeVariables);
            this.Controls.Add(this.btnAddVar);
            this.Controls.Add(this.cmbBoxListeType);
            this.Controls.Add(this.txtBoxNomAttribut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNomClasse);
            this.Controls.Add(this.lblNomClasse);
            this.Controls.Add(this.lblTitre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNomClasse;
        private System.Windows.Forms.TextBox txtBoxNomClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNomAttribut;
        private System.Windows.Forms.ComboBox cmbBoxListeType;
        private System.Windows.Forms.Button btnAddVar;
        private System.Windows.Forms.Label lblListeVariables;
        private System.Windows.Forms.ComboBox cmbBoxListeVariables;
        private System.Windows.Forms.Button btnSuppVar;
        private System.Windows.Forms.CheckBox checkBoxGetter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreVariable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNomClasseChoisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxListeGetterSetter;
        private System.Windows.Forms.Button btnDeleteGetterSetter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClasseExistante;
        private System.Windows.Forms.TextBox txtBoxClasseExistante;
        private System.Windows.Forms.CheckBox checkBoxSetter;
        private System.Windows.Forms.Button btnClasseExistante;
        private System.Windows.Forms.CheckBox checkBoxList;
        private System.Windows.Forms.CheckBox checkBoxDictionnaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBoxDictionnaire;
        private System.Windows.Forms.Button button1;
    }
}

