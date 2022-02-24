using System.Collections.Generic;

namespace Tp2_class
{
    internal class Groupe
    {
        private string Name;
        private List<Etudiant> Grp;

        public Groupe(string Name)
        {
            this.Name = Name;
            Grp = new List<Etudiant>();
        }

        public void Ajouter(Etudiant etu)
        {
            this.Grp.Add(etu);
        }

        public string name
        {
            get { return this.Name; }
            set { this.Name = name; }
        }

        public void Afficher()
        {
            foreach (Etudiant etu in Grp)
            {
                etu.Afficher();
            }
        }
        
    }
}