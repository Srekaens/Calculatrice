# Calculatrice en C#

Cette application est une simple calculatrice en console qui permet de réaliser des opérations arithmétiques de base : addition, soustraction, multiplication et division.

## Fonctionnalités

- **Multiplication**
- **Addition**
- **Soustraction**
- **Division**

## Utilisation

1. Clonez le dépôt ou téléchargez le fichier source.

2. Ouvrez le projet dans votre IDE C# préféré (comme Visual Studio).

3. Compilez et exécutez le programme.

4. Vous serez accueilli par un menu qui vous permettra de choisir l'opération que vous souhaitez effectuer.

5. Entrez les valeurs pour effectuer l'opération choisie et le résultat sera affiché.

## Code Source

```csharp
using System;

int val1; 
int val2; 
int valeurMenu = 0; 

// Fonction/méthode qui permet d'afficher le menu en l'appelant 'affichagemenu()'
static void affichageMenu()
{
    Console.ForegroundColor = ConsoleColor.White; 
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
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); 
    Console.ReadKey(); 
}

void addition()
{
    Console.Clear(); 
    Console.ForegroundColor = ConsoleColor.Blue; 
    Console.WriteLine("--- SECTION ADDITION---\n"); 
    Console.Write("\nEntrez la première valeur : "); 
    val1 = int.Parse(Console.ReadLine()); 
    Console.Write("\nEntrez la seconde valeur : "); 
    val2 = int.Parse(Console.ReadLine()); 
    int v = val1 + val2; 
    Console.WriteLine("\nVotre valeur est : " + v + "."); 
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); 
    Console.ReadKey(); 
}

void soustraction()
{
    Console.Clear(); 
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.WriteLine("--- SECTION SOUSTRACTION---\n"); 
    Console.Write("\nEntrez la première valeur : "); 
    val1 = int.Parse(Console.ReadLine()); 
    Console.Write("\nEntrez la seconde valeur : "); 
    val2 = int.Parse(Console.ReadLine()); 
    int v = val1 - val2; 
    Console.WriteLine("\nVotre valeur est : " + v + "."); 
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); 
    Console.ReadKey(); 
}

void division()
{
    Console.Clear(); 
    Console.ForegroundColor = ConsoleColor.Magenta; 
    Console.WriteLine("--- SECTION DIVISION---\n"); 
    Console.Write("\nEntrez la première valeur : "); 
    val1 = int.Parse(Console.ReadLine()); 
    Console.Write("\nEntrez la seconde valeur : "); 
    val2 = int.Parse(Console.ReadLine()); 

    if (val2 != 0) 
    {
        int v = val1 / val2; 
        Console.WriteLine("\nVotre valeur est : " + v + "."); 
    }
    else
    {
        Console.WriteLine("\nErreur : Division par zéro !"); 
    }
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("\n\nAppuyez sur entrée pour revenir au menu"); 
    Console.ReadKey(); 
}

do
{
    affichageMenu(); 

    bool Menu = int.TryParse(Console.ReadLine(), out valeurMenu); 

    switch (valeurMenu) 
    {
        case 1:
            multiplication(); 
            break; 

        case 2:
            addition(); 
            break; 

        case 3:
            soustraction(); 
            break; 

        case 4:
            division(); 
            break; 

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\terreur Saisie, appuyer sur entrée pour ressaisir");
            Console.ReadKey(); 
            break; 
    }
} while (true); 
