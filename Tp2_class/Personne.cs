
using System;

namespace Tp2_class

{
    internal abstract class Personne
    {
        private int Code;
        private string Nom;
        private string Prenom;

        public Personne(int Code, string Nom, string Prenom)
        {
            this.Code = Code;
            this.Nom = Nom;
            this.Prenom = Prenom;
        }

        public int code
        {
            get { return this.Code; }
        }

        public virtual void Afficher()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Code --> " + this.Code+".");
            Console.WriteLine("Nom --> " + this.Nom + ".");
            Console.WriteLine("Prénom --> " + this.Prenom + ".");
        }
    }
}