using System.Collections.Generic;
using System;
namespace Tp2_class
{
    internal class Enseignant : Personnel
    {
        private int NbreDeDeplaParMois;
        private string Grade;
        private int VolumeHoraire;
        private Dictionary<string, Groupe> EnsembleGroupe;
        private const double PrimeDeDeplacement = 100.0;
        public Enseignant(int Code, string Nom, string Prenom, string Bureau, int
            Nbre,string Grade,int Vol) : base(Code, Nom, Prenom, Bureau)
        {
            this.NbreDeDeplaParMois = Nbre;
            this.Grade = Grade;
            this.VolumeHoraire = Vol;
            EnsembleGroupe = new Dictionary<string, Groupe>();
        }
        public void SetSalaire()
        {
            if (this.Grade.Equals("PA"))this.salaire = this.VolumeHoraire * 300+
                                                       this.NbreDeDeplaParMois * Enseignant.PrimeDeDeplacement;
            else if (this.Grade.Equals("PH")) this.salaire =
                this.NbreDeDeplaParMois * Enseignant.PrimeDeDeplacement+this.VolumeHoraire * 350;
            else this.salaire = this.VolumeHoraire *
                400+this.NbreDeDeplaParMois*Enseignant.PrimeDeDeplacement;
        }
        public void CreateGroupe(Groupe Grp)
        {
            EnsembleGroupe.Add(Grp.name, Grp); ;
        }
        public override void Afficher()
        {
            Console.WriteLine("Enseignant:");
            base.Afficher();
            Console.WriteLine("Salaire Total --> " + this.salaire + ".");
            Console.WriteLine("Ses groupes :");
            foreach(KeyValuePair<string,Groupe> m in EnsembleGroupe)
            {
                Console.WriteLine("Groupe --> " + m.Key);
                m.Value.Afficher();
            }
        } }
}