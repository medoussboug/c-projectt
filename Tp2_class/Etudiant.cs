using System;

namespace Tp2_class
{
    internal class Etudiant : Personne
    {
        private string Niveau;
        private double Moyenne;

        public Etudiant(int Code, string Nom, string Prenom, string Niveau, double Moyenne)
            : base(Code, Nom, Prenom)
        {
            this.Niveau = Niveau;
            this.Moyenne = Moyenne;
        }

        public override void Afficher()
        {
            Console.WriteLine("Etudiant :");
            base.Afficher();
            Console.WriteLine("Niveau --> " + this.Niveau + ".");
            Console.WriteLine("Moyenne --> " + this.Moyenne + ".");
        }
    }
}