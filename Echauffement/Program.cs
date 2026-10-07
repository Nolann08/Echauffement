namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour je m'appelle Nolann et mon jeu préféré du moment c'est World of Warcraft");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quelle est votre prénom et votre âge ? ");
        string prenom = Console.ReadLine();
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bonjour "+prenom+" Tu as "+age+" ans");

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age > 17)
        {
            Console.WriteLine("Tu es majeur");
        }
        else
        {
            Console.WriteLine("Tu es mineur");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'argent as-tu en euro ?");
        int euro = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tu as gagner " + euro + " Euro");

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("Choissisez une arme parmi ces 4 armes ci dessous :");
        Console.WriteLine("1. AK47      50 euro");
        Console.WriteLine("2. Pistolet  35 euro");
        Console.WriteLine("3. épée      30 euro");
        Console.WriteLine("4. Bâton     20 euro");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.Write("Votre choix (1-4) : ");
        int choix = Convert.ToInt32(Console.ReadLine());
        int prix = 0;

        if (choix == 1)
        {
            prix = 50;
        }
        else if (choix == 2)
        {
            prix = 35;
        }
        else if (choix == 3)
        {
            prix = 30;
        }
        else if (choix == 4)
        {
            prix = 20;
        }


        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (choix >= 1 && choix <= 4 && euro >= prix && age>=18) // aide d'internet
        {
            euro = euro - prix;
            Console.WriteLine("Achat effectué ! Il vous reste " + euro + " euro");
        }
        else
        {
            Console.WriteLine("Action pas possible");
        }


        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}