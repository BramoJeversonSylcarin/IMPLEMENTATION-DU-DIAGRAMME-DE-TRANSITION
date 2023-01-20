using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPLEMENTATION_DU_DIAGRAMME_DE_TRANSITION
{
    using System;

    enum EtatLivre
    {
        Commandé,
        Réceptionné,
        Enregistré,
        Disponible,
        Emprunté,
        Prolongé,
        Réservé,
        Endommagé,
        Restauré,
        Archivé
    }

    class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string ISBN { get; set; }
        public EtatLivre Etat { get; set; }
        public DateTime DateAcquisition { get; set; }

        // Méthode pour commander un livre
        public void Commander()
        {
            Etat = EtatLivre.Commandé;
        }

        // Méthode pour réceptionner un livre
        public void receptionner()
        {
            Etat = EtatLivre.Réceptionné;
        }

        // Méthode pour enregistrer un livre
        public void enregistrer()
        {
            Etat = EtatLivre.Enregistré;
        }

        // Méthode pour mettre un livre à disposition des usagers
        public void mettreDisposition()
        {
            Etat = EtatLivre.Disponible;
        }

        // Méthode pour emprunter un livre
        public void emprunter()
        {
            Etat = EtatLivre.Emprunté;
        }

        // Méthode pour prolonger un livre
        public void prolonger()
        {
            Etat = EtatLivre.Prolongé;
        }

        // Méthode pour réserver un livre
        public void reserver()
        {
            Etat = EtatLivre.Réservé;
        }

        // Méthode pour endommager un livre
        public void endommager()
        {
            Etat = EtatLivre.Endommagé;
        }

        // Méthode pour restaurer un livre
        public void restaurer()
        {
            Etat = EtatLivre.Restauré;
        }

        // Méthode pour archiver un livre
        public void archiver()
        {
            Etat = EtatLivre.Archivé;
        }

        public override string ToString()
        {
            return $"
    
}
