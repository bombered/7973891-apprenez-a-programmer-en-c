

namespace P3C8;

public class Courrant
{
    static int solde;

    public static int AfficherSoldeCompteCourrant()
    {
        return getSolde();
    }
    public static void DeposerSoldeCompteCourrant(int somme)
    {
        solde += somme;
    }
    public static void RetirerSoldeCompteCourrant(int somme)
    {
        solde -= somme;
    }
    private static int getSolde()
    {
        return solde;
    }

}