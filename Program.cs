using System;

int val1;
int val2;
int valeurMenu = 0;
int resultat = 0;

static void affichageMenu()
{
Console.Clear();
Console.WriteLine("--- Calculatrice by JUSTIN ---");
Console.WriteLine("\n 1--- Multiplication");
Console.WriteLine("\n 2--- Addition");
Console.WriteLine("\n 3--- Soustraction");
Console.WriteLine("\n 4--- Division\n");

Console.Write("\nEntrez le mode : ");
}
void multiplication()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("--- SECTION MULTIPLICATION---\n");
    Console.Write("\nEntrez la première valeur : ");
    val1 = int.Parse(Console.ReadLine());
    Console.Write("\nEntrez la seconde valeur : ");
    val2 = int.Parse(Console.ReadLine());
    int v = val1 * val2;
    Console.WriteLine("\nVotre valeur est : " + v + ".");
    Console.ReadKey();
    Console.Clear();
};


affichageMenu();
bool Menu = int.TryParse(Console.ReadLine(), out valeurMenu);

do
{
    switch (valeurMenu)
    {
        case 0:
            affichageMenu();
            break;
        case 1:
            multiplication();
            break;

        default:
            Console.WriteLine("erreur Saisie");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (!Menu);