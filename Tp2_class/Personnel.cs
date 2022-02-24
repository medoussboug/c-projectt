using System;


namespace Tp2_class

{
    internal abstract class Personnel : Personne
    {
        private string Bureau;
        private double Salaire;

        public Personnel(int Code, string Nom, string Prenom, string Bureau) : base(Code, Nom, Prenom)
        {
            this.Bureau = Bureau;
        }

        public double salaire
        {
            get { return this.Salaire; }
            set { this.Salaire = value; }
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Bureau --> " + this.Bureau + ".");
        }
    }
}