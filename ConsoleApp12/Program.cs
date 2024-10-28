using ClassLibrary1.Model;

namespace PlanetTask12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            bool stop = true;
            string secim;

            do
            {
                Console.WriteLine("\n1-Sisteme giris\r\n0-Cixis\n");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        bool stop2 = true;

                        do 
                        { 
                        Console.WriteLine("1-planet yarat\r\n2-Butun Planetleri gor\r\n3-Planet sec (planetin adini daxil ederek secilecek)\r\n0.Exit");
                         secim = Console.ReadLine();

                             switch (secim)
                            {
                                case "1":
                                    bool stop3 = true;

                                    do
                                    {
                                        Console.WriteLine("1-olke yarat\r\n2-olke gor\r\n3-olke sil.\r\n0.Exit");
                                        secim = Console.ReadLine();

                                        switch (secim)
                                        {
                                            case "1":
                                                break;

                                            case "2":
                                                break;

                                            case "3":
                                                int id = int.Parse(Console.ReadLine());
                                                AppDbContext.RemoveCountry(id);
                                                break;

                                            case "0":
                                                stop3 = false;
                                                break;
                                            default:
                                                Console.WriteLine("secim duzgun deyil");
                                                break;
                                        }
                                    }
                                    while (stop3);
                                    break;

                                    case "2":
                                        break;

                                    case "3":
                                        break;

                                    case "0":
                                    stop2 = false;
                                        break;
                                    default:
                                    Console.WriteLine("secim duzgun deyil");
                                        break;
                            }
                        }
                        while (stop2);
                        break;




                    case "0":
                        stop = false;
                        break;
                    default:
                        Console.WriteLine("secim duzgun deyil");
                        break;
                }
            }
            while (stop);


        }

        /*
         ***Menu***

1.Sisteme giris
0.Cixis

Sisteme giris oldugu zaman
1.planet yarat 
2.Butun Planetleri gor
3.Planet sec (planetin adini daxil ederek secilecek)
0.Exit

Planet secildikden sonra
1.olke yarat
2.olke gor
4.Evvelki menuya qayit.
0.Exit
















         bool stop = true;
            string secim;

            do
            {
                Console.WriteLine("\n1-Sisteme giris\r\n0-Cixis\n");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        bool stop2 = true;

                        do 
                        { 
                        Console.WriteLine("1-planet yarat\r\n2-Butun Planetleri gor\r\n3-Planet sec (planetin adini daxil ederek secilecek)\r\n0.Exit");
                         secim = Console.ReadLine();

                             switch (secim)
                            {
                                case "1":
                                    bool stop3 = true;

                                    do
                                    {
                                        Console.WriteLine("1-olke yarat\r\n2-olke gor\r\n3-olke sil.\r\n0.Exit");
                                        secim = Console.ReadLine();

                                        switch (secim)
                                        {
                                            case "1":
                                                break;

                                            case "2":
                                                break;

                                            case "3":
                                                break;

                                            case "0":
                                                stop3 = false;
                                                break;
                                            default:
                                                Console.WriteLine("secim duzgun deyil");
                                                break;
                                        }
                                    }
                                    while (stop3);
                                    break;

                                    case "2":
                                        break;

                                    case "3":
                                        break;

                                    case "0":
                                    stop2 = false;
                                        break;
                                    default:
                                    Console.WriteLine("secim duzgun deyil");
                                        break;
                            }
                        }
                        while (stop2);
                        break;




                    case "0":
                        stop = false;
                        break;
                    default:
                        Console.WriteLine("secim duzgun deyil");
                        break;
                }
            }
            while (stop);
         */
    }
}
