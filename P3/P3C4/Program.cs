using P3C4;
// TODO : créer deux méthodes

public class MathMagiques
{
    public static int Somme(int a, int b)
    {
        return a + b;
    }

    public static int Soustraction(int a, int b)
    {
        return a - b;
    }
    public static void Main()
    {
        Console.WriteLine("" + Somme(1, 5));
        Console.WriteLine("" + Soustraction(10, 8));

        // TODO : exécuter les méthodes de test pour les deux méthodes de la classe Program.cs

        Test.TestSomme();
        Test.TestSoustraction();
    }
}


// TODO : afficher le resultat de ces deux méthodes ici


