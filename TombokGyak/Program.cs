namespace TombokGyak
{
    internal class Program
    {
        static Random r = new Random();
        static int[] tomb = new int[5];
        static void F01()
        {

        }
        static void F02()
        {

        }
        static void F03()
        {

        }
        static void F04()
        {

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
            Console.WriteLine("fForditott");
            for (int i = tomb.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tomb[i]);
            }
        }
        static void F06()
        {

        }
        static void F07()
        {

        }
        static void F08()
        {

        }
        static void F09()
        {

        }
        static void F10()
        {

        }
        static void F11()
        {

        }
        static void F12()
        {

        }
        static void F13()
        {

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
            F14();
        }
    }
}
