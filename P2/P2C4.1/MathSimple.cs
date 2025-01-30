namespace P2C4._1;

public class MathSimple
{
    /// <summary>
    /// Calculer la valeur moyenne d'une liste d'entiers
    /// </summary>
    /// <param name="listeDesEntiers">Une liste contenant des nombres entiers</param>
    /// <returns>La moyenne de la liste</returns>
    public static int CalculMoyenne(List<int> listeDesEntiers)
    {
        int moyenne = 1;

        foreach (int valeur in listeDesEntiers)
        {
            moyenne += valeur;
        }
        if (moyenne == 0)
        {
            moyenne = 0;
        }
        else
        {
            moyenne /= listeDesEntiers.Count;
        }

        return moyenne;
    }
}
