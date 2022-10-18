using System;

namespace TP2 {
    public class Humain {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }
        public string anneeNaissance { get; set; }

        public Humain(string nom, string prenom, string anneeNaissance) {
            this.nom = nom;
            this.prenom = prenom;
            this.anneeNaissance = anneeNaissance;
            this.age = calculAge(anneeNaissance);
        }

        public int calculAge(string dateNaissance) {
            var utcDateTime = DateTime.UtcNow;
            var localDateTime = utcDateTime.ToLocalTime().ToString("yyyy");
            return Convert.ToInt32(localDateTime) - Convert.ToInt32(dateNaissance);
        }

        public string getIdentite() {
            return this.nom + " " + this.prenom + " " + this.age;
        }
    }
}