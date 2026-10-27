namespace TombokGyak
{
    internal class Program
    {
        static Random r = new Random();
        static int[] tomb = new int[5];
        static void F01()
        {
            int[] tomb1 = new int[10];
            for (int i = 0; i < tomb1.Length; i++)
            {
                tomb1[i] = r.Next(5, 11);
            }
            foreach (int item in tomb1)
            {
                Console.WriteLine(item);
            }

        }
        static void F02()
        {
            int[] tomb2 = new int[15];
            for (int i = 0; i < tomb2.Length; i++)
            {
                tomb2[i] = r.Next(1, 3);
            }
            foreach (int item in tomb2)
            {
                if (item == 1)
                {
                    Console.WriteLine("IGAZ");
                }
                else
                {
                    Console.WriteLine("HAMIS");
                }
            }
        }
        static void F03()
        {
            double[] tomb3 = new double[20];
            for (int i = 0; i < tomb3.Length; i++)
            {
                tomb3[i] = r.NextDouble() + r.Next(1, 21);
            }
            foreach (double item in tomb3)
            {
                Console.WriteLine(Math.Round(item, 2));
            }
        }
        static void F04()
        {
            double[] tomb4 = new double[25];
            for (int i = 0; i < tomb4.Length; i++)
            {
                tomb4[i] = r.NextDouble() + r.Next(1, 21);
            }
            for (int i = 0; i < tomb4.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(Math.Pow(tomb4[i], 2));
                }
            }
        }
        static void F05()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("Kérek egy számot: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Forditott");
            for (int i = tomb.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine("Minden 2. elem:");
            for (int i = 1; i < tomb.Length; i += 2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine("1 - 5 ig adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Megadott elem: {tomb[szam - 1]}");
        }
        static void F06()
        {
            double[] tomb4 = new double[5];
            for (int i = 0; i < tomb4.Length; i++)
            {
                tomb4[i] = r.NextDouble() + r.Next(1, 21);
            }
            double[] tomb5 = new double[5];
            for (int i = 0; i < tomb5.Length; i++)
            {
                tomb5[i] = r.NextDouble() + r.Next(1, 21);
            }
            double[] tomb6 = new double[5];

            Console.WriteLine("Megegyező indexű elemek összeadása: ");
            for (int i = 0; i < tomb6.Length; i++)
            {
                tomb6[i] = tomb4[i] + tomb5[i];
                Console.WriteLine($"{i + 1}. {tomb6[i]}");
            }
        }
        static void F07()
        {
            int[] tomb7 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Merre szeretnéd léptetni az elemeket? (balra - b, jobbra - j): ");
            char irany = Convert.ToChar(Console.ReadLine());
            switch (irany)
            {
                case 'b':
                    int elsoszam = tomb7[0];
                    for (int i = 0; i < tomb7.Length - 1; i++)
                    {
                        tomb7[i] = tomb7[i + 1];
                    }
                    tomb7[tomb7.Length - 1] = elsoszam;
                    break;
                case 'j':
                    int utolsoszam = tomb7[tomb7.Length - 1];
                    for (int i = tomb7.Length - 1; i > 0; i--)
                    {
                        tomb7[i] = tomb7[i - 1];
                    }
                    tomb7[0] = utolsoszam;
                    break;
            }
            foreach (int item in tomb7)
            {
                Console.WriteLine(item);
            }
        }
        static void F08()
        {
            int[] tomb8 = { 1, 2, 3, 4, 5 };
            foreach (int item in tomb8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Tömb elemei megfordítva: ");
            for (int i = tomb8.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tomb8[i]);
            }
        }
        static void F09()
        {
            double[] tomb9 = { 1.352, 2.5227, 3.9536, 4.11, 5.23653 };
            double osszeg = 0;
            foreach (double item in tomb9)
            {
                osszeg += item;
            }
            Console.WriteLine($"A tömb elemeinek összege: {osszeg}");
        }
        static void F10()
        {
            double[] tomb9 = { 1.352, 2.5227, 3.9536, 4.11, 5.23653 };
            foreach (double item in tomb9)
            {
                Console.WriteLine(item);
            }
            for (int i = 1; i < tomb9.Length; i += 2)
            {
                tomb9[i] += tomb9[i + 1];
            }
            Console.WriteLine("A tömb elemei utána: ");
            foreach (double item in tomb9)
            {
                Console.WriteLine(item);
            }
        }
        static void F11()
        {
            double[] tomb9 = { 1.352, -2.5227, -3.9536, 4.11, -5.23653 };
            int hanyszor = 0;
            for (int i = 0; i < tomb9.Length; i++)
            {
                if (tomb9[i] >= 0 && tomb9[i + 1] < 0)
                {
                    hanyszor++;
                }
            }
            Console.WriteLine($"A tömbben ennyiszer van pozitív szám után negatív szám: {hanyszor}");


        }
        static void F12()
        {
            int[] tomb10 = new int[5];
            for (int i = 0; i < tomb10.Length; i++)
            {
                int szam = r.Next(10, 100);
                bool benneVan = false;
                foreach (int item in tomb10)
                {
                    if (item == szam)
                    {
                        benneVan = true;
                        break;
                    }
                }
                if (!benneVan)
                {
                    tomb10[i] = szam;
                }
            }
            Console.WriteLine("Ötös lottó számok: ");
            foreach (int item in tomb10)
            {
                Console.Write($"{item} ");
            }
        }
        static void F13()
        {
            int[] tomb11 = new int[20];
            for (int i = 0; i < tomb11.Length; i++)
            {
                tomb11[i] = r.Next(-100, 101);
            }
            foreach (int item in tomb11)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            for (int i = 0; i < tomb11.Length; i++)
            {
                string elojel = "+";
                if (tomb11[i] < 0)
                {
                    elojel = "-";
                }
                Console.WriteLine($"{i + 1}. | {tomb11[i]} | {elojel}");
            }
            Console.WriteLine();
            for (int i = 2; i < tomb11.Length; i += 3)
            {
                tomb11[i] += 1;
            }
            foreach (int item in tomb11)
            {
                Console.Write($"{item}, ");

            }
            Console.WriteLine();
            for (int i = 1; i < tomb11.Length; i += 2)
            {
                tomb11[i] -= tomb11[i - 1];
            }
            foreach (int item in tomb11)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        static void F14()
        {
            Console.Write("Adj meg egy egész számot: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] tomb2 = new int[N];
            Console.Write("Add meg az első intervallumot (legyen kisebb mint a 2.): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a második intervallumot: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                tomb2[i] = r.Next(a, b);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{i + 1}. {tomb2[i]}");
            }
            char cselekves;
            do
            {
                Console.Write("Mit szeretnél csinálni a tömb elemeivel (Növelni - a, Csökkenteni - b, Szorozni - c, Kilépni - d): ");
                cselekves = Convert.ToChar(Console.ReadLine());
                switch (cselekves)
                {
                    case 'a':
                        Console.Write("Mennyivel akarod növelni az értékeket: ");
                        int novel = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            tomb2[i] += novel;
                            Console.WriteLine($"{i + 1}. {tomb2[i]}");
                        }
                        break;
                    case 'b':
                        Console.Write("Mennyivel akarod csökkenteni az értékeket: ");
                        int csokkent = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            tomb2[i] -= csokkent;
                            Console.WriteLine($"{i + 1}. {tomb2[i]}");
                        }
                        break;
                    case 'c':
                        Console.Write("Mennyivel akarod szorozni az értékeket: ");
                        int szorzando = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            tomb2[i] *= szorzando;
                            Console.WriteLine($"{i + 1}. {tomb2[i]}");
                        }
                        break;
                    case 'd':
                        Console.WriteLine("Kiléptél!");
                        break;
                    default:
                        Console.WriteLine("Nem megfelelő betű!");
                        break;
                }
            }
            while (cselekves != 'd');
        }
        static void Main(string[] args)
        {
            //F01();
            //F02();
            //F03();
            //F04();
            //F05();
            //F06();
            //F07();
            //F08();
            //F09();
            //F10();
            //F11();
            //F12();
            //F13();
            //F14();
        }
    }
}
