using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static double pb1()
    {
        double a, b;
        Console.WriteLine("Scrie valoarea lui a: ");
        a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Scrie valoarea lui b: ");
        b = Double.Parse(Console.ReadLine());
        double x = -1 * b / a;
        return x;
    }

    private static string pb2()
    {
        double a, b, c;
        Console.WriteLine("Scrie valoarea lui a: ");
        a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Scrie valoarea lui b: ");
        b= Double.Parse(Console.ReadLine());
        Console.WriteLine("Scrie valoarea lui c: ");
        c = Double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;
        if (delta < 0)
            return "Ecuatia nu are solutie";
        else if(delta == 0)
        {
            return ((double)(-b) / (2 * a)).ToString();
        }
        else
        {
            double radDelta = Math.Sqrt(delta);
            double x1 = (-b + radDelta) / (2 * a);
            double x2 = (-b - radDelta) / (2 * a);

            return String.Concat(x1, " ,", x2);
        }
    }
    private static string pb3()
    {
        Console.WriteLine("Scrie numarul n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul k: ");
        int k = int.Parse(Console.ReadLine());

        if(n%k == 0)
        {
            return String.Concat("Numarul ", n, " se divide cu ", k);
        }
        return String.Concat("Numarul ", n, " nu se divide cu ", k);

    }
    private static string pb4()
    {
        Console.WriteLine("Scrie anul: ");
        int an = int.Parse(Console.ReadLine());
        if(an % 4 == 0 && an % 100 != 0)
        {
            return String.Concat("Anul ", an, " este bisect");
        } else if(an % 400 == 0)
        {
            return String.Concat("Anul ", an, " este bisect");
        }
        else
        {
            return String.Concat("Anul ", an, " nu este bisect");
        }

    }
    private static string pb5()
    {
        Console.WriteLine("Scrie numarul: ");
        string numar = Console.ReadLine();
        Console.WriteLine("Scrie numarul cifrei: ");
        int k = int.Parse(Console.ReadLine());
        if(k > numar.Length)
        {
            return String.Concat("Numarul introdus nu are", k.ToString(), " cifre");
        }
        int pozitieCifra = numar.Length - k;
        return String.Concat("Cifra de pe pozitia ", k, " este: ", numar[pozitieCifra]);

    }
    private static string pb6()
    {
        Console.WriteLine("Scrie numarul a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul c: ");
        int c = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (b + c) > a)
        {
            return "Numerele pot sa fie laturile unui triunghi";
        }
        return "Numerele nu pot sa fie laturile unui triunghi";

    }


    // imverseaza valorile a 2 numere
    private static void swap(ref int a, ref int b)
    {
  
        int aux = a;
        a = b; b = aux;
    }
    private static string pb7()
    {
        Console.WriteLine("Scrie numarul a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul b:");
        int b = int.Parse(Console.ReadLine());

        swap(ref a, ref b);

        return String.Concat("Dupa swap a=", a, " si b=", b);

    }
    private static string pb8()
    {

        Console.WriteLine("Scrie numarul a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul b:");
        int b = int.Parse(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        return String.Concat("Dupa swap a=", a, " si b=", b);

    }
    private static string pb9()
    {
        Console.WriteLine("Scrie numarul: ");
        int n = int.Parse(Console.ReadLine());

        List<int> divizori = new List<int>();
        int i;
        for(i = 1; i*i < n; i++)
        {
            if (n % i == 0)
            {
                divizori.Add(i);
                divizori.Add(n / i);
            }
        }

        if (i * i == n)
        {
            divizori.Add(i);
        }

        divizori.Sort();
        return String.Concat("Divizorii numarului ", n, " sunt: " + String.Join(", ",divizori));
    }
    private static string pb10()
    {
        Console.WriteLine("Scrie numarul: ");
        int numar = int.Parse(Console.ReadLine());

        for(int i = 2; i*i<=numar; i++)
        {
            if(numar%i == 0)
            {
                return "Numarul nu este prim";
            }
        }
        return "Numarul este prim";

    }

    private static int oglinditulNumarului(int numar)
    {
        int m = numar;
        int og = 0;

        while (m != 0)
        {
            og = og * 10 + m % 10;
            m /= 10;
        }

        return og;
    }

    private static string pb11()
    {
        Console.WriteLine("Scrie numarul: ");
        int numar = int.Parse(Console.ReadLine());

        return String.Concat("Inversul numarului ", numar, " este: ", oglinditulNumarului(numar));

    }

   // numarul de numere divizibile cu n intr-un interval cu numere naturale
    private static int noNumereDivizibileInInterval(int n, int a, int b)
    {
        return b / n - (a - 1) / n;
    }
    private static int pb12()
    {
        Console.WriteLine("Scrie numarul n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            n = -n;
        }
        Console.WriteLine("Scrie capatul din stanga al intervalului: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie capatul din dreapta al intervalului: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            swap(ref a, ref b);
        }
        if (a > 0 && b > 0)
        {
            return noNumereDivizibileInInterval(n, a, b);
        }
        else if (a < 0 && b > 0)
        {
            return noNumereDivizibileInInterval(n, 0, -a) + noNumereDivizibileInInterval(n, 0, b);
        }
        else
            return noNumereDivizibileInInterval(n, -b, -a);
    }

    // numarul anilor bisecti inainte de un an dat
    private static int noAniBisecti(int an)
    {
        return (an / 4) - (an / 100) + (an / 400);
    }
    private static int pb13()
    {
        Console.WriteLine("Scrie primul an: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie scrie al doilea an: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            swap(ref a,ref b);
        }


        return noAniBisecti(b) - noAniBisecti(a-1);
    }
    private static string pb14()
    {
        Console.WriteLine("Scrie numarul: ");
        int numar = int.Parse(Console.ReadLine());

        if(numar == oglinditulNumarului(numar))
        {
            return String.Concat("Numarul ", numar, " este palindrom");
        }
        return String.Concat("Numarul ", numar, " nu este palindrom");

    }

    // ordoneaza 3 numere fara tablouri
    private static void orderSwap3(ref int a, ref int b, ref int c)
    {
        if (a > b)
        {
            swap(ref a, ref b);
        }
        if(a > c)
        {
            swap(ref a, ref c);
        }
        if(b > c)
        {
            swap(ref b, ref c);
        }
    }
    private static string pb15()
    {
        Console.WriteLine("Scrie numarul a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul c: ");
        int c = int.Parse(Console.ReadLine());
        orderSwap3(ref a, ref b, ref c);
        return a + ", " + b + ", " + c;
    }
    private static string pb16()
    {
        Console.WriteLine("Scrie numarul a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul d: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul e: ");
        int e = int.Parse(Console.ReadLine());

        orderSwap3(ref a, ref b, ref c);
        orderSwap3(ref a, ref d, ref e);
        orderSwap3(ref b, ref c, ref d);
        orderSwap3(ref b, ref c, ref e);
        orderSwap3(ref c, ref d, ref e);

        return a + ", " + b + ", " + c + ", " + d + ", " + e;
    }

    private static int cmmdc(int a, int b)
    {
        while (a != b)
        {
            if(a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }

        return a;
    }

    private static int cmmmc(int a, int b)
    {
        return a * b / cmmdc(a, b);
    }
    private static string pb17()
    {
        Console.WriteLine("Scrie numarul a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numarul b: ");
        int b = int.Parse(Console.ReadLine());

        return String.Concat("Cmmdc: ", cmmdc(a,b), ";\nCmmmc: ", cmmmc(a,b));
    }
    private static string pb18()
    {
        Console.WriteLine("Scrie numarul n: ");
        int n = int.Parse(Console.ReadLine());
        int d = 2, p;
        List<string> descompunere = new List<string>();
        while (n > 1)
        {
            p = 0;
            while (n % d == 0)
            {
                ++p;
                n /= d;
            }

            if (p!=0)
            {
              descompunere.Add(d + "^" + p); 
            }

            d++;

            if(n>1 && d*d > n)
            {
                d = n;
            }
        }
        return "Descompunere in factori primi ai numarului " + n + " este: " + String.Join("x", descompunere);
    }
    private static string pb19()
    {
        Console.WriteLine("Scrie numarul n: ");
        int n = int.Parse(Console.ReadLine());
        int cifra1 = -1, cifra2 = -1;
        while (n != 0)
        {
            if (cifra1 == -1)
            {
                cifra1 = n % 10;
            } else if(cifra1 != n%10 && cifra2 == -1)
            {
                cifra2 = n % 10; 
            } else if(cifra1 != n%10 && cifra2 != n%10)
            {
                return "Numarul nu este format doar cu 2 cifre care se pot repeta";
            }
            n /= 10;
        }
        if(cifra1 == -1 || cifra2 == -1)
        {
            return "Numarul nu este format doar cu 2 cifre care se pot repeta";
        }
        return "Numarul este foarmat doar cu 2 cifre care se repeta";
    }
    private static string pb20()
    {

        Console.WriteLine("Scrie numaratorul fractie: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie numitorul fractie: ");
        int n = int.Parse(Console.ReadLine());

        int parteIntreaga = m / n;
        int parteFractionara = m % n;
        int rest;
        bool periodic = false;
        List<int> cifre = new List<int>();
        List<int> resturi = new List<int>();
        resturi.Add(parteFractionara);
        do
        {
            cifre.Add(parteFractionara * 10 / n);
            rest = parteFractionara * 10 % n;
            if (!resturi.Contains(rest))
            {
                resturi.Add(rest);
            }
            else
            {
                periodic = true;
                break;
            }

            parteFractionara = rest;
        } while (rest != 0);

        if (!periodic)
        {
            return parteIntreaga + "." + String.Join("", cifre);
        }
        else
        {
            string perioada = ".";
            for(int i = 0; i < cifre.Count; i++)
            {
                if (resturi[i] == rest)
                {
                    perioada += "(";
                }
                perioada += cifre[i];
            }
            perioada += ")";
            
            return parteIntreaga + perioada;
        }

    }
    private static void pb21()
    {
        Random r = new Random();
        int number = r.Next(1, 1025);
        int c = 0;
        while(number != c)
        {
            Console.WriteLine("Scrie numarul: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Numarul este mai mare sau egal decat {0}?", c);
            if(number >= c)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Nu");
            }
        }

        Console.WriteLine("Felicitari ai ghicit numarul", number);
    }


    private static void menu()
    {
        Console.WriteLine("1.Rezolvare ecuatia de gradul 1 (ax + b = 0; a,b sunt date de intrare)");
        Console.WriteLine("2.Rezolvare ecuatia de gradul 2 (ax^2 + bx + c = 0; a,b,c date de intrare)");
        Console.WriteLine("3.Verifica daca n se divide cu k");
        Console.WriteLine("4.Verificare daca un an este an bisect");
        Console.WriteLine("5.Extrage a k-a cifra de la finalul unui numar");
        Console.WriteLine("6.Verifica daca 3 numere pot fi lungimile laturilor unui triunghi");
        Console.WriteLine("7.Inversarea valorilor a 2 numere");
        Console.WriteLine("8.Inversarea valorilor a 2 numere fara variabile suplimentare");
        Console.WriteLine("9.Afisarea tututor divizorilor unui numar");
        Console.WriteLine("10.Verifica daca un numar este prim sau nu");
        Console.WriteLine("11.Afisarea in ordine inversa a cifrelor unui numar");
        Console.WriteLine("12.Determinati cate numere intregi divizibile cu n se afla in intervalul dat");
        Console.WriteLine("13.Determinati cati ani bisecti sunt intre ani dati");
        Console.WriteLine("14.Determinati daca un numar dat este palindrom");
        Console.WriteLine("15.Afisarea a 3 numere in ordine crescatoare");
        Console.WriteLine("16.Afisarea a 5 numere in ordine crescatoare");
        Console.WriteLine("17.Cel mai mare divizor comun si cel mai mic multiplu comun a doua numere");
        Console.WriteLine("18.Descompunere in factori primi ai unui numar");
        Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta");
        Console.WriteLine("20.Afisati fractia m/n in format zecimal");
        Console.WriteLine("21.Ghiciti un numar intre 1 si 1024 prin intrebari de format \"numarul este mai mare sau egal decat x\"");
        Console.WriteLine("x. Inchide programul");
    }
    private static void Main(string[] args)
    {

        bool flag = true;
        while (flag)
        {
            string choice = "";
            menu(); 
            Console.WriteLine("\n");
            Console.WriteLine("Scrie numarul optiunii:");
            choice  = Console.ReadLine().ToLower();
            Console.WriteLine("\n");
            switch (choice){
                case "1":
                    Console.WriteLine("Raspuns: {0}", pb1());
                    break;
                case "2":
                    Console.WriteLine("Raspuns: {0}", pb2());
                    break;
                case "3":
                    Console.WriteLine("Raspuns: {0}", pb3());
                    break;
                case "4":
                    Console.WriteLine("Raspuns: {0}", pb4());
                    break;
                case "5":
                    Console.WriteLine("Raspuns: {0}", pb5());
                    break;
                case "6":
                    Console.WriteLine("Raspuns: {0}", pb6());
                    break;
                case "7":
                    Console.WriteLine("Raspuns: {0}", pb7());
                    break;
                case "8":
                    Console.WriteLine("Raspuns: {0}", pb8());
                    break;
                case "9":
                    Console.WriteLine("Raspuns: {0}", pb9());
                    break;
                case "10":
                    Console.WriteLine("Raspuns: {0}", pb10());
                    break;
                case "11":
                    Console.WriteLine("Raspuns: {0}", pb11());
                    break;
                case "12":
                    Console.WriteLine("Raspuns: {0}", pb12());
                    break;
                case "13":
                    Console.WriteLine("Raspuns: {0}", pb13());
                    break;
                case "14":
                    Console.WriteLine("Raspuns: {0}", pb14());
                    break;
                case "15":
                    Console.WriteLine("Raspuns: {0}", pb15());
                    break;
                case "16":
                    Console.WriteLine("Raspuns: {0}", pb16());
                    break;
                case "17":
                    Console.WriteLine("Raspuns: {0}", pb17());
                    break;
                case "18":
                    Console.WriteLine("Raspuns: {0}", pb18());
                    break;
                case "19":
                    Console.WriteLine("Raspuns: {0}", pb19());
                    break;
                case "20":
                    Console.WriteLine("Raspuns: {0}", pb20());
                    break;
                case "21":
                    pb21();
                    break;
                case "x":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Comanda inexistenta reincercati!");
                    break;
            }
            Console.WriteLine("\n");

        }
    }
}