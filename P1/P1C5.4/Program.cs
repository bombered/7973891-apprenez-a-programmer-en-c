IDictionary<string, int> mois = new Dictionary<string, int>();

// TODO : Remplacer les noms par des constantes de type chaine de caractères
const string juin = "Juin";
const string septembre = "Septembre";
const string mars = "Mars";


mois.Add(juin, 6);
mois.Add(septembre, 9);
mois.Add(mars, 5);

// TODO : Corriger la valeur de Mars avec (3)

mois[mars] = 3;


// TODO : Retirer Juin

mois.Remove(juin);

// Afficher le contenu du dictionnaire
Console.WriteLine("La liste des mois est :");
foreach (KeyValuePair<string, int> clePaire in mois)
{
    Console.WriteLine(clePaire.Key.ToString() + " est le numéro du mois de " + clePaire.Value + " de l'année ");
}