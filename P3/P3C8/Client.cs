namespace P3C8;
public class Client
{
    string nom;
    int numeroCompte;

    public Client(string nom, int numeroCompte)
    {
        this.nom = nom;
        this.numeroCompte = numeroCompte;
    }

    public string getNom()
    {
        return this.nom;
    }
    public int getNumero()
    {
        return this.numeroCompte;
    }
    public int AfficherSoldeCompteCourrant()
    {
        return Courrant.AfficherSoldeCompteCourrant();
    }
    public int AfficherSoldeCompteEpargne()
    {
        return Epargne.AfficherSoldeCompteEpargne();
    }
    public void DeposerSoldeCompteCourrant(int somme)
    {
        Courrant.DeposerSoldeCompteCourrant(somme);
    }
    public void RetirerSoldeCompteCourrant(int somme)
    {
        Courrant.RetirerSoldeCompteCourrant(somme);
    }
    public void DeposerSoldeCompteEpargne(int somme)
    {
        Epargne.DeposerSoldeCompteEpargne(somme);
    }
    public void RetirerSoldeCompteEpargne(int somme)
    {
        Epargne.RetirerSoldeCompteEpargne(somme);
    }
}