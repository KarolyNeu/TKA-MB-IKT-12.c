using System;
using System.Threading;
using SzimulacioTKAMBSLib;

Console.WriteLine("Hello, World!");

// menu itemek
string[] MenuElemek = { "Start", "Beállítások", "Kilépés" };
string[] NehezsegiSzintek = { "Normál", "Nehéz" };

int Menuindex = 0;
int DifficultyIndex = 0;

// ablak mérete
Console.SetWindowSize(100, 35);
Console.Title = "Fejlesztői Konzol";

// menu loop
bool startgomb = false;
while (startgomb == false)
{
    // Clear the console
    Console.Clear();

    // középre igazít
    int centerY = Console.WindowHeight / 3;
    int xtengely = Console.WindowWidth / 3;
    int SzelessegMenu = 35;
    int MagassagMenu = MenuElemek.Length;

    int menuX = xtengely - (SzelessegMenu / 3);
    int menuY = centerY - (MagassagMenu / 3);

    for (int i = 0; i < MenuElemek.Length; i++)
    {
        Console.SetCursorPosition(menuX, menuY + i);

        if (i == Menuindex)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        Console.Write(MenuElemek[i]);
    }

    Console.ResetColor();

    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

    switch (keyInfo.Key)
    {
        case ConsoleKey.UpArrow:
            if (Menuindex <= 0)
            {
                Menuindex = MenuElemek.Length - 1;
            }
            else
            {
                Menuindex--;
            }
            break;

        case ConsoleKey.DownArrow:
            if (Menuindex == MenuElemek.Length - 1)
            {
                Menuindex = 0;
            }
            else
            {
                Menuindex++;
            }
            break;

        case ConsoleKey.Enter:
            // Menu pontok

            switch (Menuindex)
            {
                case 0:
                    Console.Clear();
                    Console.ReadLine();
                    startgomb = true;
                    break;

                case 1:
                    // Beállítások menü
                    xtengely = Console.WindowWidth / 2;
                    centerY = Console.WindowHeight / 2;
                    SzelessegMenu = 20;

                    menuX = xtengely - (SzelessegMenu / 2);
                    menuY = centerY - (MagassagMenu / 2);

                    bool exitSettings = false;
                    while (!exitSettings)
                    {
                        Console.Clear();
                        for (int i = 0; i < NehezsegiSzintek.Length; i++)
                        {
                            if (i == DifficultyIndex)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Blue;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Black;
                            }

                            Console.WriteLine(NehezsegiSzintek[i]);
                        }

                        keyInfo = Console.ReadKey(true);
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow:
                                if (DifficultyIndex <= 0)
                                {
                                    DifficultyIndex = NehezsegiSzintek.Length - 1;
                                }
                                else
                                {
                                    DifficultyIndex--;
                                }
                                break;

                            case ConsoleKey.DownArrow:
                                if (DifficultyIndex >= NehezsegiSzintek.Length - 1)
                                {
                                    DifficultyIndex = 0;
                                }
                                else
                                {
                                    DifficultyIndex++;
                                }
                                break;

                            case ConsoleKey.Enter:
                                string difficultySetting;
                                switch (DifficultyIndex)
                                {
                                    case 0:
                                        difficultySetting = "10 10,10,2";
                                        break;

                                    case 1:
                                        difficultySetting = "15 15,6,6";
                                        break;
                                    default:
                                        difficultySetting = "10 10,10,2";
                                        break;
                                }

                                System.IO.File.WriteAllText(@"C:\Temp\difficulty.txt", difficultySetting);
                                exitSettings = true;
                                break;

                            case ConsoleKey.Escape:
                                exitSettings = true;
                                break;

                        }

                        Console.ResetColor();
                    }
                    break;

                case 2:
                    Environment.Exit(0);
                    return;

            }
            break;

    }

}

// Olvassa be a difficulty.txt fájlt
string difficultyData = System.IO.File.ReadAllText(@"C:\Temp\difficulty.txt");
string[] parameterek = difficultyData.Split(',');

// Mátrix mérete
string[] MatrixMeret = parameterek[0].Split(' ');
int Sorok = int.Parse(MatrixMeret[0]);
int Oszlopok = int.Parse(MatrixMeret[1]);

// Játéktér inicializálása
Entity[,] JatekMezo = new Entity[Sorok, Oszlopok];

// Nyulak és rókák száma
int NyulMennyiseg = int.Parse(parameterek[1]);
int RokaMennyisegRoka = int.Parse(parameterek[2]);

Random veletlen = new Random();
for (int i = 0; i < NyulMennyiseg; i++)
{
    int x, y;
    do
    {
        x = veletlen.Next(Sorok);
        y = veletlen.Next(Oszlopok);
    } while (JatekMezo[x, y] != null);
    JatekMezo[x, y] = new Nyul(4);
}

for (int i = 0; i < RokaMennyisegRoka; i++)
{
    int x, y;
    do
    {
        x = veletlen.Next(Sorok);
        y = veletlen.Next(Oszlopok);
    } while (JatekMezo[x, y] != null);
    JatekMezo[x, y] = new Roka(8);
}

// Körök száma
Console.WriteLine("Kérem adja meg a körszámot:");
int BealitottKorok = int.Parse(Console.ReadLine());



