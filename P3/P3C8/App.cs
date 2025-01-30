namespace P3C8;
public class App
{
    string text;
    public App(){
        this.text = "";

        Client client = new("Marine", 506);
        start(client);

        var contenu = RecupererContenu(text);

        try
        {
            EcrireFichier.Ecrire(contenu, "output.txt");
        }
        catch (IOException e)
        {
            Console.WriteLine("Impossible d'écrire dans le fichier - " + e.ToString());
        }
    }
private void start(Client client)
    {
        string choice = "";
        do
        {
            Console.WriteLine("Appuyez sur Entrée pour afficher le menu.");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Acceuil();
            }
            choice = ("" + Console.ReadLine()).ToUpper();
            ChoixCompte(choice, client);
        } while (choice != "X");
    }

    public void ChoixCompte(string choice, Client client)
    {
        //[I] Voir les informations sur le titulaire du compte
        //[CS] Compte courant - Consulter le solde
        //[CD] Compte courant - Déposer des fonds
        //[CR] Compte courant - Retirer des fonds
        //[ES] Compte épargne - Consulter le solde
        //[ED] Compte épargne - Déposer des fonds
        //[ER] Compte épargne - Retirer des fonds
        switch (choice)
        {
            case "I":
                Console.WriteLine("Le nom titulaire du compte est " + client.getNom() + " votre numéro de compte est " + client.getNumero());
                break;
            case "CS":
                Console.WriteLine("Compte courant - Votre solde est: " + client.AfficherSoldeCompteCourrant() + "€");
                break;
            case "CD":
                CourrantDepot(client);
                break;
            case "CR":
                CourrantRetrait(client);
                break;
            case "ES":
                Console.WriteLine("Compte épargne - Votre solde est: " + client.AfficherSoldeCompteEpargne() + "€");
                break;
            case "ED":
                EpargneDepot(client);
                break;
            case "ER":
                EpargneRetrait(client);
                break;
            case "X":
                Console.WriteLine("Adieu");
                break;
        }
    }
    private string RecupererContenu(string text){
        return text;
    }

    private void Acceuil()
    {
        Console.WriteLine("[I]  Voir les informations sur le titulaire du compte");
        Console.WriteLine("[CS] Compte courant - Consulter le solde");
        Console.WriteLine("[CD] Compte courant - Déposer des fonds");
        Console.WriteLine("[CR] Compte courant - Retirer des fonds");
        Console.WriteLine("[ES] Compte épargne - Consulter le solde");
        Console.WriteLine("[ED] Compte épargne - Déposer des fonds");
        Console.WriteLine("[ER] Compte épargne - Retirer des fonds");
        Console.WriteLine("[X]  Quitter");

    }

    private int recup()
    {
        string depot = "" + Console.ReadLine();
        int egg = 0;
        if (veryfy(depot))
        {
            egg = Int32.Parse(depot);
        }
        return egg;
    }
    private void CourrantDepot(Client client)
    {
        Console.WriteLine("Compte courant - Quel montant souhaitez-vous déposer ?");
        int egg = recup();
        client.DeposerSoldeCompteCourrant(egg);
        this.text += "Courrant - Vous avez déposé : " + egg + " €.";
        Console.WriteLine("Vous avez déposé : " + egg + " €.");
    }
    private void CourrantRetrait(Client client)
    {
        Console.WriteLine("Compte courant - Quel montant souhaitez-vous retirer ?");
        int egg = recup();
        client.RetirerSoldeCompteCourrant(egg);
        this.text += "Courrant - Vous avez retiré : " + egg + " €.";
        Console.WriteLine("Vous avez retiré : " + egg + " €.");
    }

    private void EpargneDepot(Client client)
    {
        Console.WriteLine("Compte Epargne - Quel montant souhaitez-vous déposer ?");
        int egg = recup();
        client.DeposerSoldeCompteEpargne(egg);
        this.text += "Epargne - Vous avez déposé : " + egg + " €.";
        Console.WriteLine("Vous avez déposé : " + egg + " €.");
    }
    private void EpargneRetrait(Client client)
    {
        Console.WriteLine("Compte Epargne - Quel montant souhaitez-vous retirer ?");
        int egg = recup();
        client.RetirerSoldeCompteEpargne(egg);
        this.text += "Epargne - Vous avez retiré : " + egg + " €.";
        Console.WriteLine("Vous avez retiré : " + egg + " €.");
    }
    private static bool veryfy(string depot)
    {
        if (depot != null)
        {
            return true;
        }
        return false;
    }
}
