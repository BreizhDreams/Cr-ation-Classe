using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Création_Classe
{
    public class Structure
    {
        #region Attribut
        private List<string> _collType = new List<string>();
        private List<string> _collVariables = new List<string>();
        private List<string> _collGetSet = new List<string>();

        #endregion

        #region Constructeur
        public Structure()
        {

        }
        #endregion

        #region Getter Setter
        public List<string> CollType { get => _collType; set => _collType = value; }
        public List<string> CollVariables { get => _collVariables; set => _collVariables = value; }
        public List<string> CollGetSet { get => _collGetSet; set => _collGetSet = value; }

        #endregion

        #region Methodes

        // Met en Majuscule la Première lettre du mot ou bien la seconde si la première est un _
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
        // Créer les différentes variantes des GETTER SETTER
        public string CreateGetterSetter(string nameVar, string typeVar, bool getter, bool setter,bool checkList = false , bool checkDico = false , string typeVar2 = null)
        {
            typeVar = getType(checkDico, checkList,typeVar, typeVar2);
            if (getter && setter)
            {
                string getters_setter = "public " + typeVar + " " + CapitalizeFirstLetter(nameVar) + " { get => _" + nameVar + "; set => _" + nameVar + "= value; }";
                return getters_setter;
            }
            else if (getter && setter == false)
            {
                string leGetter = "public " + typeVar + " " + CapitalizeFirstLetter(nameVar) + " { get => _" + nameVar + ";}";
                return leGetter;
            }
            else if (setter && getter == false)
            {
                string leSetter = "public " + typeVar + " " + CapitalizeFirstLetter(nameVar) + "{ set => _" + nameVar + "= value; }";
                return leSetter;
            }
            return null;
        }
        

        public string CreateRegion(string nameRegion)
        {
            string region = "#region " + nameRegion;
            return region;
        }

        public string CreateEndRegion()
        {
            string endregion = "#endregion";
            return endregion;
        }
        //Ajout du Constructeur
        public string CreateConstructeur(string nameClasse)
        {
            string constructeur = "public " + nameClasse + "() {}";
            return constructeur;
        }

        // Ajout des Usings au début du Fichier
        public string CreateUsings()
        {
            string usings = "using System;\n" +
                "using System.Collections.Generic; \n" +
                "using System.Linq;\n" +
                "using System.Text;\n" +
                "using System.Threding.Tasks; \n \n";
            return usings;
        }

        // Créer l'Attribut List
        public string CreateList(string nameVar, string typeVar)
        {
            string nameList = "List<" + typeVar + "> " + nameVar + " = new List<" + typeVar + ">();";
            return nameList;
        }

        // Créer l'Attribut Dictionnaire
        public string CreateDictionnary(string nameVar, string typeKey, string typeValue)
        {
            string nameDico = "Dictionary<" + typeKey + "," + typeValue + "> " + nameVar + " = new Dictionary<" + typeKey + "," + typeValue + ">();";
            return nameDico;
        }


        // Renvoie le Type d'une Variable pour les List, Dico et Variables Classiques
        public string getType(bool checkDico, bool checkList, string typeN1, string typeN2 = null)
        {
            string leType;
            if (checkDico)
            {
                return leType = "Dictionary<" + typeN1 + "," + typeN2 + ">";
            }
            else if (checkList)
            {
                return leType = "List<" + typeN1 + ">";
            }
            return leType = typeN1;
        }

        // Vérification si l'utilisateur à saisie un variable déja Existante
        public bool CheckVarExistante(string laVariable)
        {
            foreach(string laVar in CollVariables)
            {
                if(laVar.ToLower() == laVariable.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        // Vérification si l'utilisateur à saisie un type déja Existant
        public bool CheckTypeExistant(string leType)
        {
            foreach (string leTypage in CollType)
            {
                if (leType.ToLower() == leTypage.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }


    #endregion

}
