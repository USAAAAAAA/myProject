int menuChoice;

Console.WriteLine("Please enter a choice from the menu from 1 do 6, or 7 for exit: ");
menuChoice = int.Parse(Console.ReadLine());

do
{
    if (menuChoice == 1)
    {
        double bitcoin = double.Parse(Console.ReadLine());
        double yoana = double.Parse(Console.ReadLine());
        double komisionna = double.Parse(Console.ReadLine());

        const double BTC_BGN = 1168;
        const double CNY_USD = 0.15;
        const double USD_BGN = 1.76;
        const double EUR_BGN = 1.95;
        const double BGN_EUR = 1 / EUR_BGN;

        double levs = 0;
        levs += bitcoin * BTC_BGN;
        levs += (yoana * CNY_USD) * USD_BGN;

        double euros = levs * BGN_EUR;

        double comission = euros * komisionna / 100;

        double total = euros - comission;

        Console.WriteLine($"{total:F2}");
    }
    else if (menuChoice == 2)
    {
        int minutes = int.Parse(Console.ReadLine());
        int btoirazhodkidnewno = int.Parse(Console.ReadLine());
        int kalorii = int.Parse(Console.ReadLine());

        int obstominuti = minutes * btoirazhodkidnewno;
        int obstoizgorenikalorii = obstominuti * 5;
        double izgarq = 0.5 * kalorii;

        if (obstoizgorenikalorii > izgarq)
        {
            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day {obstoizgorenikalorii}");
        }
        else if (izgarq > obstoizgorenikalorii)
        {
            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day {obstoizgorenikalorii}");
        }
    }
    else if (menuChoice == 3)
    {
        int x1 = int.Parse(Console.ReadLine()); 
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (((x == x1 || x == x2) && y >= y1 && y <= y2) ||
            ((y == y1 || y == y2) && x >= x1 && y <= x2))
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
    else if (menuChoice == 4)
    {
        int grupi = int.Parse(Console.ReadLine());
        double musalaCount = 0;
        double monblanCount = 0;
        double kilimanjdaroCount = 0;
        double k2Count = 0;
        double everestCount = 0;
        for (int i = 0; i < grupi; i++)
        {
            int katerachi = int.Parse(Console.ReadLine());
            if (katerachi <= 5)
            {
                musalaCount += katerachi;
            }
            else if (katerachi <= 12)
            {
                monblanCount += katerachi;
            }
            else if (katerachi <= 25)
            {
                kilimanjdaroCount += katerachi;
            }
            else if (katerachi <= 40)
            {
                k2Count += katerachi;
            }
            else
            {
                everestCount += katerachi;
            }
        }

        double total = musalaCount + monblanCount + kilimanjdaroCount + k2Count + everestCount;
        double musalaPercent = musalaCount / total * 100;
        Console.WriteLine($"{musalaPercent:f2}");
        double monblanPercent = monblanCount / total * 100;
        Console.WriteLine($"{monblanPercent:f2}");
        double kilimandjaroPercent = kilimanjdaroCount / total * 100;
        Console.WriteLine($"{kilimandjaroPercent:f2}");
        double k2Percent = k2Count / total * 100;
        Console.WriteLine($"{k2Percent:f2}");
        double everestPercent = everestCount / total * 100;
        Console.WriteLine($"{everestPercent:f2}");
    }
    else if (menuChoice == 5)
    {
        double space = double.Parse(Console.ReadLine());
        int count = 0;
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                break;
            }

            double volume = double.Parse(command);
            
            if (count % 3 == 0)
            {
                volume *= 1.1;
            }

            if (space < volume)
            {
                Console.WriteLine("No more space!");
                break;
            }
            count++;
            space -= volume;
        }
        Console.WriteLine($"Statistic: {count} suitcases loaded.");
    }
    else if (menuChoice == 6)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());
        int count = 0;
        bool hasCombination = false;
        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                count++;
                if (i + j == magicNumber)
                {
                    hasCombination = true;
                    Console.WriteLine($"Combination N:{count}({i} + {j} = {i+j})");
                    break;

                }
            }
            if (hasCombination)
            {
                break;
            }
        }

        if (!hasCombination)
        {
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
        
    }

    Console.WriteLine("Please enter a choice from the menu from 1 do 6, or 7 for exit: ");
    menuChoice = int.Parse(Console.ReadLine());
} while (menuChoice != 7);
