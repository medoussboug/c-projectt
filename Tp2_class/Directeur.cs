using System;
namespace Tp2_class
{
    internal class Directeur : Personnel
    {
        private int NbreDeDeplaParMois;
        private const double PrimeDeDeplacement = 100.0;
        private static Directeur D = null;
        
        public static Directeur NvDir(int code, string nom, string prenom, string bureau, double salaire, int Nbre)
        {
            if (D == null)
                D = new Directeur(code, nom, prenom, bureau, salaire, Nbre);
            else
                Console.WriteLine("l’école a déjà un directeur");
            return D;
        }

        private Directeur(int Code, string Nom, string Prenom, string Bureau,
            double Salaire, int Nbre) : base(Code, Nom, Prenom, Bureau)
        {
            this.NbreDeDeplaParMois = Nbre;
            this.salaire = Salaire + this.NbreDeDeplaParMois * Directeur.PrimeDeDeplacement;
        }

        public override void Afficher()
        {
            Console.WriteLine("Directeur :");
            base.Afficher();
            Console.WriteLine("Salaire Total --> " + this.salaire + ".");
        }
    }
}

