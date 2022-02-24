using System;
using System.Collections.Generic;

namespace Tp2_class
{
    internal class RessourcesHumaines
    {
        private List<Personnel> GRH;

        public RessourcesHumaines()
        {
            GRH = new List<Personnel>();
        }

        public void ajouter(Personnel prs)
        {
            if (GRH.Contains(prs))
            {
                Console.WriteLine("personnel deja existe");
                return;
            }

            GRH.Add(prs);
        }

        public void Afficher_Enseignants()
        {
            foreach (Personnel prs in GRH)
            {
                if (prs is Enseignant) prs.Afficher();
            }
        }

        public void Afficher()
        {
            foreach (Personnel prs in GRH)
            {
                prs.Afficher();
            }
        }

        public int Rechercher_Ens(int Code)
        {
            foreach (Personnel prs in GRH)
            {
                if (prs is Enseignant && prs.code == Code) return GRH.IndexOf(prs);
            }

            return -1;
        }
    }
}