using System;

int val1; // déclaration d'une variable val1 qui permettra a l'utilisateur plus tard de saisir la première valeur et l'enregistrer dedans
int val2; // déclaration d'une variable val2 qui permettra a l'utilisateur plus tard de saisir la seconde valeur et l'enregistrer dedans
int valeurMenu = 0; // déclaration d'une variable valeurMenu qui permettra a l'utilisateur plus tard de garder sa valeur afin de parcourir le menu dans le switch case

//Fonction/méthode qui permet d'afficher le menu en l'appelant 'affichagemenu()'
static void affichageMenu()
{
    Console.ForegroundColor = ConsoleColor.White; // On initialise la couleur de la police a la couleur blanche
    Console.Clear(); // Efface tout ce qui se trouve d'afficher sur la console
    Console.WriteLine("--- Calculatrice by JUSTIN ---"); // Affiche une chaine de caractère dans la console pur afficher la section
    Console.WriteLine("\n 1--- Multiplication"); // Affiche une chaine de caractère dans la console pour afficher l'option pour la multiplication
    Console.WriteLine("\n 2--- Addition"); // Affiche une chaine de caractère dans la console pour afficher l'option pour l'addition
    Console.WriteLine("\n 3--- Soustraction"); // Affiche une chaine de caractère dans la console pour afficher l'option pour la soustraction
    Console.WriteLine("\n 4--- Division\n"); // Affiche une chaine de caractère dans la console pour afficher l'option pour la division
    // info : le \n permet de créer un espace et donc de passer une ligne entre chaque message afficher dans la console

    Console.Write("\nEntrez le mode : "); // Affiche une chaine de caractère dans la console qui invite l'utilisateur a entrer une option
}

//Fonction/méthode qui permet d'effectuer une multiplication en l'appelant 'multiplication()'
void multiplication()
{
    Console.Clear(); // Efface tout ce qui se trouve d'afficher sur la console
    Console.ForegroundColor = ConsoleColor.Green; // On initialise la couleur de la police a la couleur verte
    Console.WriteLine("--- SECTION MULTIPLICATION---\n"); // Affiche une chaine de caractère dans la console pour afficher la section multiplication
    Console.Write("\nEntrez la première valeur : "); // Affiche une chaine de caractère qui va demander la première valeur a l'utilisateur
    val1 = int.Parse(Console.ReadLine()); // Lit et convertir la première valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val1
    Console.Write("\nEntrez la seconde valeur : "); // Affiche une chaine de caractère qui va demander la seconde valeur a l'utilisateur
    val2 = int.Parse(Console.ReadLine()); // Lit et convertir la seconde valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val2
    int v = val1 * val2; // Effectue la multiplication entre val1 et val2 puis la stocke dans la variable nommé 'v' pour l'afficher plus tard
    Console.WriteLine("\nVotre valeur est : " + v + "."); // Affichage le résultat de la variable 'v' dans laquelle on effectue le calcul juste avant
    Console.ForegroundColor = ConsoleColor.Red; // On initialise la couleur de la police a la couleur rouge
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); // Affiche une chaine de caractère dans la console pour guider l'utilisateur a revenir au menu
    Console.ReadKey(); // Attend une touche pour continuer
};

//Fonction/méthode qui permet d'effectuer une addition en l'appelant 'addition()'
void addition()
{
    Console.Clear(); // Efface tout ce qui se trouve d'afficher sur la console
    Console.ForegroundColor = ConsoleColor.Blue; // On initialise la couleur de la police a la couleur bleu
    Console.WriteLine("--- SECTION ADDITION---\n"); // Affiche une chaine de caractère dans la console pour afficher la section addition
    Console.Write("\nEntrez la première valeur : "); // Affiche une chaine de caractère qui va demander la première valeur a l'utilisateur
    val1 = int.Parse(Console.ReadLine()); // Lit et convertir la première valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val1
    Console.Write("\nEntrez la seconde valeur : "); // Affiche une chaine de caractère qui va demander la seconde valeur a l'utilisateur
    val2 = int.Parse(Console.ReadLine()); // Lit et convertir la seconde valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val2
    int v = val1 + val2; // Effectue l'addition entre val1 et val2 puis la stocke dans la variable nommé 'v' pour l'afficher plus tard
    Console.WriteLine("\nVotre valeur est : " + v + ".");// Affichage le résultat de la variable 'v' dans laquelle on effectue le calcul juste avant
    Console.ForegroundColor = ConsoleColor.Red; // On initialise la couleur de la police a la couleur rouge
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); // Affiche une chaine de caractère dans la console pour guider l'utilisateur a revenir au menu
    Console.ReadKey(); // Attend une touche pour continuer
}

//Fonction/méthode qui permet d'effectuer une soustraction en l'appelant 'soustraction()'
void soustraction()
{
    Console.Clear();// Efface tout ce qui se trouve d'afficher sur la console
    Console.ForegroundColor = ConsoleColor.Yellow; // On initialise la couleur de la police a la couleur jaune
    Console.WriteLine("--- SECTION SOUSTRACTION---\n"); // Affiche une chaine de caractère dans la console pour afficher la section soustraction
    Console.Write("\nEntrez la première valeur : ");// Affiche une chaine de caractère qui va demander la première valeur a l'utilisateur
    val1 = int.Parse(Console.ReadLine());// Lit et convertir la première valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val1
    Console.Write("\nEntrez la seconde valeur : ");// Affiche une chaine de caractère qui va demander la seconde valeur a l'utilisateur
    val2 = int.Parse(Console.ReadLine());// Lit et convertir la seconde valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val2
    int v = val1 - val2;// Effectue la soustraction entre val1 et val2 puis la stocke dans la variable nommé 'v' pour l'afficher plus tard
    Console.WriteLine("\nVotre valeur est : " + v + ".");// Affichage le résultat de la variable 'v' dans laquelle on effectue le calcul juste avant
    Console.ForegroundColor = ConsoleColor.Red; // On initialise la couleur de la police a la couleur rouge
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); // Affiche une chaine de caractère dans la console pour guider l'utilisateur a revenir au menu
    Console.ReadKey(); // Attend une touche pour continuer
}

//Fonction/méthode qui permet d'effectuer une division en l'appelant 'division()'
void division()
{
    Console.Clear();// Efface tout ce qui se trouve d'afficher sur la console
    Console.ForegroundColor = ConsoleColor.Magenta; // On initialise la couleur de la police a la couleur violet
    Console.WriteLine("--- SECTION DIVISION---\n");// Affiche une chaine de caractère dans la console pour afficher la section division
    Console.Write("\nEntrez la première valeur : ");// Affiche une chaine de caractère qui va demander la première valeur a l'utilisateur
    val1 = int.Parse(Console.ReadLine());// Lit et convertir la première valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val1
    Console.Write("\nEntrez la seconde valeur : ");// Affiche une chaine de caractère qui va demander la seconde valeur a l'utilisateur
    val2 = int.Parse(Console.ReadLine());// Lit et convertir la seconde valeur entrée par l'utilisateur a l'aide du 'Console.ReadLine()' pour ensuite la stocker dans val2

    if (val2 != 0)// Vérifie que la seconde valeur 'v2' n'est pas zéro pour éviter la division par zéro
    {
        int v = val1 / val2; // Si la valeur 'v2' n'est pas égal a 0 alors on effectue la division
        Console.WriteLine("\nVotre valeur est : " + v + "."); // Affiche une chaine de caractère dans la console qui va afficher le resultat 
    }
    else
    {
        Console.WriteLine("\nErreur : Division par zéro !");//Si la valeur 'v2' est égal a 0 alors il affiche un message d'erreur si division par zéro
    }
    Console.ForegroundColor = ConsoleColor.Red; // On initialise la couleur de la police a la couleur rouge
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); // Affiche une chaine de caractère dans la console pour guider l'utilisateur a revenir au menu
    Console.ReadKey(); // Attend une touche pour continuer
}

// Boucle principale du programme 'do while'
do
{
    affichageMenu(); // Affiche le menu en appelant la fonction/méthode créer au préalable

    bool Menu = int.TryParse(Console.ReadLine(), out valeurMenu); // Lit l'option choisie par l'utilisateur et la convertit en entier (la valeur sera celle qui permet de naviguer dans le switch)

    switch (valeurMenu) //Démarrage du switch en fonction de la valeur 'valeurMenu' rentré par l'utilisateur
    {
        case 1:
            multiplication();// Appelle la méthode multiplication
            break; // Quitte le bloc switch après avoir exécuté l'opératio

        case 2:
            addition(); // Appelle la méthode addition
            break; // Quitte le bloc switch après avoir exécuté l'opératio

        case 3:
            soustraction(); // Appelle la méthode soustraction
            break; // Quitte le bloc switch après avoir exécuté l'opératio

        case 4:
            division(); // Appelle la méthode division
            break; // Quitte le bloc switch après avoir exécuté l'opératio

        default:
            Console.ForegroundColor = ConsoleColor.Red;// On initialise la couleur de la police a la couleur rouge
            Console.WriteLine("\n\terreur Saisie, appuyer sur entrée pour ressaisir");// Message d'erreur pour une option invalide
            Console.ReadKey();// Attend une touche pour continuer
            break; // Quitte le bloc switch après avoir exécuté l'opératio
    }
} while (true); // Boucle infinie pour permettre à l'utilisateur de continuer à utiliser la calculatrice