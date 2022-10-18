using System;

namespace TP2 {
    public class Etudiant: Humain {
        public float moyenne { get; set; }
        public string numEtu { get; set; }
    
        public Etudiant(string nom, string prenom, string anneeNaissance, string numEtu, float moyenne = 0) : base(nom, prenom, anneeNaissance) {
            this.numEtu = numEtu;
            this.moyenne = moyenne;
        }

        public string getEtu() {
            return this.nom + " " + this.prenom + " " + this.numEtu;
        }

        public static bool operator <(Etudiant a, Etudiant b) {
            if(a.moyenne < b.moyenne) {
                return true;
            } else {
                return false;
            }
        }

        public static bool operator >(Etudiant a, Etudiant b) {
            if(a.moyenne > b.moyenne) {
                return true;
            } else {
                return false;
            }
        }
    }
}