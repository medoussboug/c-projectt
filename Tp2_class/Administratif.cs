using System;

namespace Tp2_class
{
    internal class Administratif : Personnel
    {
        public Administratif(int Code, string Nom, string Prenom, string
            Bureau, double Salaire) : base(Code, Nom, Prenom, Bureau)
        {
            this.salaire = Salaire;
        }

        public override void Afficher()
        {
            Console.WriteLine("Administratif :");
            base.Afficher();
            Console.WriteLine("Salaire Total --> " + this.salaire + ".");
        }
    }
} 