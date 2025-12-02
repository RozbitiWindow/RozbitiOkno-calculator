using System;
Console.Clear();

string ver = "1.0.4"; // everything was made by RozbitiOkno 24.11.2025
// HEADER
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("=== " + DateTime.Now + " ===");
Console.WriteLine("RozitiOkno operators v." + ver);
Console.WriteLine("=============================");
Console.ResetColor();

// MAIN MENU
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("To perform calculations press 1, to generate random numbers press 2, to convert units press 3");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("Your choice: ");
Console.ResetColor();

if (!int.TryParse(Console.ReadLine(), out int whattodo))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR: Not a number! - " + whattodo + " - try something else!");
    Console.ResetColor();
    return;
}

switch (whattodo)
{
    // ----------------------------------------- //
    // CALCULATOR
    // ----------------------------------------- //
    case 1:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=== " + DateTime.Now + " ===");
        Console.WriteLine("RozitiOkno calculator v." + ver);
        Console.WriteLine("=============================");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Do you need multiple operations? (y/n)");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Your choice: ");
        Console.ResetColor();
        string multiple = Console.ReadLine().ToLower();

        switch (multiple)
        {
            // MULTIPLE OPERATIONS
            case "y":
            case "yes":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter your first number:");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice ");
                    Console.ResetColor();
                    double result = double.Parse(Console.ReadLine());

                    string continueCalc = "y";

                    while (continueCalc == "y")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter operation (+,-,*,/):");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Your choice ");
                        Console.ResetColor();
                        string oper = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter next number:");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Your choice ");
                        Console.ResetColor();
                        double next = double.Parse(Console.ReadLine());

                        switch (oper)
                        {
                            case "+": result += next; break;
                            case "-": result -= next; break;
                            case "*": result *= next; break;
                            case "/": result /= next; break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid operation!");
                                Console.ResetColor();
                                continue;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Current result: " + result);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Do you want to continue? (y/n)");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Your choice ");
                        Console.ResetColor();
                        continueCalc = Console.ReadLine().ToLower();
                    }

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Final result: " + result);
                    Console.ResetColor();
                    Console.WriteLine("Thanks for using multiple-operations calculator!");
                    break;
                }

            // SINGLE OPERATION
            case "n":
            case "no":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter first number:");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice ");
                    Console.ResetColor();
                    double num1 = double.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter operation (+,-,*,/):");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice ");
                    Console.ResetColor();
                    string oper = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Enter second number:");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice ");
                    Console.ResetColor();
                    double num2 = double.Parse(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Result:");
                    Console.ResetColor();

                    switch (oper)
                    {
                        case "+": Console.WriteLine(num1 + num2); break;
                        case "-": Console.WriteLine(num1 - num2); break;
                        case "*": Console.WriteLine(num1 * num2); break;
                        case "/": Console.WriteLine(num1 / num2); break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid operation!");
                            Console.ResetColor();
                            break;
                    }

                    Console.WriteLine("Thanks for using RozbitiOkno calculator " + ver);
                    break;
                }

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Unknown operation " + multiple);
                Console.ResetColor();
                break;
        }
        break;

    // ----------------------------------------- //
    // RANDOM NUMBER GENERATOR
    // ----------------------------------------- //
    case 2:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("=== Random Number Generator ===");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Do you want to generate only YES or NO answers? (y/n)");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Your choice ");
        Console.ResetColor();
        string rngMode = Console.ReadLine().ToLower();
        Random rng = new Random();

        switch (rngMode)
        {
            // YES / NO MODE
            case "y":
            case "yes":
                while (true)
                {
                    string answer = rng.Next(2) == 0 ? "YES" : "NO";

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Generated: " + answer);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Generate again? (y/n)");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("Your choice ");
                    Console.ResetColor();
                    if (Console.ReadLine().ToLower() != "y")
                        break;
                }
                Console.WriteLine("Thanks for using YES/NO RNG " + ver);
                break;

            // NUMBER MODE
            case "n":
            case "no":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter FROM number:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice ");
                Console.ResetColor();
                int from = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter TO number:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Your choice ");
                Console.ResetColor();
                int to = int.Parse(Console.ReadLine());

                while (true)
                {
                    int rndNum = rng.Next(from, to + 1);

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Generated number: " + rndNum);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Generate again? (y/n)");
                    Console.ResetColor();

                    if (Console.ReadLine().ToLower() != "y")
                        break;
                }

                Console.WriteLine("Thanks for using RNG " + ver);
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Unknown mode \"" + rngMode + "\"");
                Console.ResetColor();
                break;
        }
        break;

    // ----------------------------------------- //
    // UNFINISHED UNIT CONVERTER
    // ----------------------------------------- //
    case 3:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("====== " + DateTime.Now + " ======");
        Console.WriteLine("RozitiOkno Unit Convertor v." + ver);
        Console.WriteLine("===================================");
        Console.ResetColor();
        Console.WriteLine("Select your unit");
        Console.WriteLine("1 → KM to M");
        Console.WriteLine("2 → M to CM");
        Console.WriteLine("3 → CM to MM");
        Console.WriteLine("------------");
        Console.WriteLine("4 → M to KM"); //opak
        Console.WriteLine("5 → CM to M");
        Console.WriteLine("6 → MM to CM");
        Console.WriteLine("============");
        Console.WriteLine("7 → T to KG");
        Console.WriteLine("8 → KG to G");
        Console.WriteLine("9 → G to mG");
        Console.WriteLine("-----------"); //opak
        Console.WriteLine("10 → KG to T");
        Console.WriteLine("11 → G to KG");
        Console.WriteLine("12 → mG to G");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Your choice: ");
        Console.ResetColor();
        double yourUnit = double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.DarkRed;    
        Console.WriteLine("How much units do you want to convert?");
        Console.ResetColor();
        double HOWMUCH = double.Parse(Console.ReadLine());
        double RESULTUNITS = yourUnit switch
        {
            1 => HOWMUCH * 1000, //KM
            2 => HOWMUCH * 100,
            3 => HOWMUCH * 10,
            4 => HOWMUCH / 1000, //opak
            5 => HOWMUCH / 1000,
            6 => HOWMUCH / 1000,
            7 => HOWMUCH * 1000, //KG
            8 => HOWMUCH * 1000,
            9 => HOWMUCH * 1000,
            10 => HOWMUCH / 1000, //opak
            11 => HOWMUCH / 1000,
            12 => HOWMUCH / 1000,
            _ => double.NaN,
        };

        if (yourUnit != 1 && yourUnit != 3 && yourUnit != 2 && yourUnit != 4 && yourUnit != 5 && yourUnit != 6 && yourUnit != 7 && yourUnit != 8 && yourUnit != 9 && yourUnit != 10 && yourUnit != 11 && yourUnit != 12) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NOT VALID OPTION! - " + yourUnit + " - try something else!");
            Console.ResetColor();
        }

        else
        {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (yourUnit == 1) //normal
        {
            Console.WriteLine("Result: " + RESULTUNITS + " M");
        }
                if (yourUnit == 2)
        {
            Console.WriteLine("Result: " + RESULTUNITS + " CM");
        }
                if (yourUnit == 3)
        {
            Console.WriteLine("Result: " + RESULTUNITS + " MM");
        }   
                if (yourUnit == 4) //opak
        {
                Console.WriteLine("Result: " + RESULTUNITS + " KM"); 
        }
                if (yourUnit == 5)
        {
            Console.WriteLine("Result: " + RESULTUNITS + " M");
        }   
                if (yourUnit == 6)
        {
                Console.WriteLine("Result: " + RESULTUNITS + " CM");
        }
                if (yourUnit == 7) //normal
        {
                Console.WriteLine("Result: " + RESULTUNITS + " KG");
        }
                if (yourUnit == 8)
        {
            Console.WriteLine("Result: " + RESULTUNITS + " G");
        }   
                if (yourUnit == 9)
        {
                Console.WriteLine("Result: " + RESULTUNITS + " mG");
        }
                if (yourUnit == 10)
        {
                Console.WriteLine("Result: " + RESULTUNITS + " T");
        }
                if (yourUnit == 11)
        {
                Console.WriteLine("Result: " + RESULTUNITS + " KG");
        }
                if (yourUnit == 12)
        {
                Console.WriteLine("Result: " + RESULTUNITS + " G");
        }
        }
        
        Console.ResetColor();
        break;

    // SECRET OPTION - sreggin - ODEBRAT after vydání/nikdy
    case 67:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("SIXXXX SEVENNNN!");
        Console.WriteLine("Stupid peoples are NOT allowed to use this program!");
        Console.WriteLine("STFU you little nigga . . .");
        Console.ResetColor();
        break;

    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR: Not an option! Try 1,2,3");
        Console.ResetColor();
        break;
}


Console.ResetColor();
Console.WriteLine("See more on github.com/rozbitiwindow");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Press ENTER to exit...");
Console.ReadLine();
Console.ResetColor();
Console.WriteLine("Thx for using RozbitiOkno operators!");
Console.ResetColor();
