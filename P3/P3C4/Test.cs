namespace P3C4;
using P3C4;

public class Test
{
    // TODO : créer deux méthodes de test correspondant à la méthode Test en respectant la convention de nommage appropriée
    // Tester la somme
    public static void TestSomme()
    {
        if (MathMagiques.Somme(1, 5) == 6)
        {
            Console.WriteLine("La somme est correcte");
        }
        else
        {
            Console.WriteLine("La somme est incorrecte");
        }
    }

    public static void TestSoustraction()
    {
        if (MathMagiques.Soustraction(10, 8) == 2)
        {
            Console.WriteLine("La soustraction est correcte");
        }
        else
        {
            Console.WriteLine("La soustraction est incorrecte");
        }
    }
}
