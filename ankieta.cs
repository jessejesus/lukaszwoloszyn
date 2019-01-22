static void Main(string[] args)
        {
            int kucharz = 0;
            int nauczyciel = 0;
            int ogrodnik = 0;
            int strazak = 0;
            int mechanik = 0;
            int nr_pyt = 0;

            Console.SetWindowSize(60, 30);
            Console.Title = "Program";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Hello World");
            Console.WriteLine("To okno nazywa się " + Console.Title);

            string[] lines = File.ReadAllLines("Pytania.txt");

            for (int i = 0; i < 10; i++)
            {
                string odp;

                Console.WriteLine(lines[nr_pyt]);
                nr_pyt++;

                do
                {
                    odp = Console.ReadLine();
                    if (odp != "t" && odp != "T" && odp != "n" && odp!="N")
                  {
                      Console.Beep(300, 200);
                      Console.WriteLine("Twoja odpowiedź była inna niż t lub n! Spróbuj jeszcze raz:");
                  }

                } while (odp != "t" && odp != "T" && odp != "n" && odp != "N");


                if (nr_pyt == 1 || nr_pyt == 2)
                    {
                        if (odp == "t" || odp == "T") ++kucharz;
                    }

                    if (nr_pyt == 3 || nr_pyt == 4)
                    {
                        if (odp == "t" || odp == "T") ++nauczyciel;
                    }

                    if (nr_pyt == 5 || nr_pyt == 6)
                    {
                        if (odp == "t" || odp == "T") ++ogrodnik;
                    }

                    if (nr_pyt == 7 || nr_pyt == 8)
                    {
                        if (odp == "t" || odp == "T") ++strazak;
                    }

                    if (nr_pyt == 9 || nr_pyt == 10)
                    {
                        if (odp == "t" || odp == "T") ++mechanik;
                    }

                }


            if (kucharz > nauczyciel && kucharz > ogrodnik && kucharz > strazak && kucharz > mechanik) Console.WriteLine("Zostaniesz kucharzem!");
            if (nauczyciel > kucharz && nauczyciel > ogrodnik && nauczyciel > strazak && nauczyciel > mechanik) Console.WriteLine("Zostaniesz nauczycielem");
            if (ogrodnik > kucharz && ogrodnik > nauczyciel && ogrodnik > strazak && ogrodnik > mechanik) Console.WriteLine("Zostaniesz ogrodnikiem");
            if (strazak > kucharz && strazak > nauczyciel && strazak > ogrodnik && strazak > mechanik) Console.WriteLine("Zostaniesz strażakiem");
            if (mechanik > kucharz && mechanik > nauczyciel && mechanik > ogrodnik && mechanik > strazak) Console.WriteLine("Zostaniesz mechanikiem");

            Console.ReadLine();

        }
