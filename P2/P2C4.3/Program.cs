using P2C4._3;

//- Ouvrez le fichier Program.cs. Entourez le code (à partir de List<int>...) avec un bloc try.
//- Ajoutez un bloc catch qui prend en paramètre l'exception mentionnée dans la trace d'appel à l'étape précédente.
//- À l'intérieur du bloc catch, ajoutez une instruction Console.WriteLine avec un message pertinent pour l'utilisateur, lui demandant de fournir des arguments numériques de type entier.
//- Compilez et exécutez votre programme avec et sans fournir d'arguments.
//- La trace d'appel devrait maintenant être remplacée par le message que vous avez écrit à l'intérieur de votre bloc catch.
//- Bonus : ajoutez une autre instruction catch pour vous protéger contre les arguments non numériques, comme indiqué dans le cours.

try
{
    List<int> temperaturesEnregistreDegresCelcius = new List<int>();

    // remplir la liste à partir des valeurs fournies comme arguments en ligne de commande
    foreach (string stringRepresentationTemperature in args)
    {
        int temperature = int.Parse(stringRepresentationTemperature);
        temperaturesEnregistreDegresCelcius.Add(temperature);
    }

    // Calculer et afficher la température moyenne
    int moyenneTemperature = MathSimple.CalculMoyenne(temperaturesEnregistreDegresCelcius);
    Console.WriteLine("La température moyenne est " + moyenneTemperature);
}
catch (System.DivideByZeroException)
{
    Console.WriteLine("impossible de diviser par zéro, il nous faut au moins 1 argument de type entier");
}
catch (System.FormatException)
{
    Console.WriteLine("il faut que ce soit un chiffre");
}