using System;
using System.Collections.Generic;
using TP5_GestionBiblio;

class Program
{
    static void Main(string[] args)
    {
        Bibliotheque biblio = new Bibliotheque();
        // Ajout d'adhérents à la bibliothèque
        Adherent ad1 = new Adherent("Jean", "Dupond");
        biblio.AjouterAdherent(ad1);

        Adherent ad2 = new Adherent("Marie", "Dubois");
        biblio.AjouterAdherent(ad2);

        // Création de deux livres
        Livre livre1 = new Livre("Les Misérables", "Victor Hugo");
        Livre livre2 = new Livre("Systèmes multi-agents", "Jacques Ferber");

        // Ajout de documents à la bibliothèque
        biblio.AjouterDocument(livre1);
        biblio.AjouterDocument(livre2);
        biblio.AjouterDocument(new Journal("Dr. Dobbs", Convert.ToDateTime("12/05/2017")));
        biblio.AjouterDocument(new BD("Thorgal: La galère noire", "Jean Van Hamme", "Grzegorz Rosiński"));
        biblio.AjouterDocument(new Dictionnaire("Petit Robert", "Robert !"));

        // Affiche la liste des documents de la bibliothèque
        Console.WriteLine("------ Liste des documents ------");
        biblio.ListerDocuments();

        // Emprunt d'un livre
        ad1.Emprunter(livre1);

        // Affiche la liste des livres empruntés par l'adhérent
        Console.WriteLine("\nLivres empruntés par " + ad1.Prenom + " " + ad1.Nom + ":");
        ad1.ListerLivresEmpruntes();

        // Rendu du livre
        ad1.Rendre(livre1);

        // Affiche à nouveau la liste des livres empruntés par l'adhérent (maintenant vide)
        Console.WriteLine("\nLivres empruntés par " + ad1.Prenom + " " + ad1.Nom + ":");
        ad1.ListerLivresEmpruntes();

        // Recherche de documents contenant "ob"
        Console.WriteLine("\nRecherche de documents contenant 'ob':");
        List<Document> resultatsRecherche = biblio.ChercherDocument("ob");
        biblio.ListerResultatsRecherche(resultatsRecherche);

        Console.ReadKey();
    }
}