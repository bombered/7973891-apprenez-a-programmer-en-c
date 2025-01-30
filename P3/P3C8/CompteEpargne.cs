

namespace P3C8;

public class Epargne
{
    static int solde;

    public static int AfficherSoldeCompteEpargne()
    {
        return getSolde();
    }
    public static void DeposerSoldeCompteEpargne(int somme)
    {
        solde += somme;
    }
    public static void RetirerSoldeCompteEpargne(int somme)
    {
        solde -= somme;
    }

    private static int getSolde()
    {
        return solde;
    }
}