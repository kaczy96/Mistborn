using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mistborn
{
    class Program
    {
        static void Main(string[] args)
        {
            Stats Character = new Stats();
            Console.WriteLine("Based on:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Brandon Sanderson book:");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("''Mistborn''");
            Console.ReadKey();
            Console.Clear();

            
                Console.WriteLine("Choose character: ");
                Console.WriteLine("1) Vin - female");
                Console.WriteLine("2) Elend - male ");
                
                int wybor = int.Parse(Console.ReadLine());
                while(wybor !=1 && wybor !=2)
                wybor = int.Parse(Console.ReadLine() + "Type property value");

            Console.Clear();
                Console.WriteLine("Take your starting gift: ");
                Console.WriteLine();
                Console.WriteLine("1) Flask with allomancy metals");
                Console.WriteLine("2) Kandra companion");
                Console.WriteLine("3) Glass dagger");
                int wybor2 = int.Parse(Console.ReadLine());
                while (wybor2 != 1 && wybor2 != 2 &&
                wybor2!=3)
                wybor2 = int.Parse(Console.ReadLine() + "Type property value");

            switch (wybor)
                {
                    case (1):
                        {
                            switch (wybor2)
                            {
                                case (1): //Vin/Flask
                                    {
                                        Character.Name = "Vin";
                                        Character.Hp = 15;
                                        Character.Strength = 1;
                                        Character.Agility = 2;
                                        Character.Defense = 1;
                                        Character.Luck = 2;
                                        Character.Metal_bottle = 2;
                                        break;
                                    }
                                case (2): //Vin/Companion
                                    {
                                        Character.Name = "Vin";
                                        Character.Hp = 25;
                                        Character.Strength = 2;
                                        Character.Agility = 3;
                                        Character.Defense = 2;
                                        Character.Luck = 2;
                                        Character.Metal_bottle = 1;
                                        break;
                                    }
                                case (3): //Vin/Dagger
                                    {
                                        Character.Name = "Vin";
                                        Character.Hp = 15;
                                        Character.Strength = 1;
                                        Character.Agility = 2;
                                        Character.Defense = 1;
                                        Character.Luck = 1;

                                        Ekwipunek Glass_dagger = new Ekwipunek();
                                        Glass_dagger.Damage = 3;
                                        Glass_dagger.Endurance = 3;
                                        break;
                                    }
                            }
                            break;
                        }
                    case (2):
                        {
                            switch (wybor2)
                            {
                                case (1): //Elend/FFlask
                                    {
                                        Character.Name = "Elend";
                                        Character.Hp = 20;
                                        Character.Strength = 2;
                                        Character.Agility = 1;
                                        Character.Defense = 1;
                                        Character.Luck = 1;
                                        Character.Metal_bottle = 2;
                                        break;
                                    }
                                case (2): //Elend/Companion
                                    {
                                        Character.Name = "Elend";
                                        Character.Hp = 30;
                                        Character.Strength = 2;
                                        Character.Agility = 3;
                                        Character.Defense = 2;
                                        Character.Luck = 2;
                                        Character.Metal_bottle = 1;
                                        break;
                                    }
                                case (3): //Elend/Dagger
                                    {
                                        Character.Name = "Elend";
                                        Character.Hp = 20;
                                        Character.Strength = 1;
                                        Character.Agility = 2;
                                        Character.Defense = 1;
                                        Character.Luck = 2;
                                        Character.Metal_bottle = 1;

                                        Ekwipunek Glass_dagger = new Ekwipunek();
                                        Glass_dagger.Damage = 3;
                                        Glass_dagger.Endurance = 3;
                                        break;
                                    }
                            }

                            break;
                        }
                }



                Ekwipunek brak_broni = new Ekwipunek();
                brak_broni.Error = 0;

                Console.Clear();
                Console.WriteLine("Twoja postać: ");
                Console.WriteLine(Character.Name);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Zdrowie: {0}", Character.Hp);
                Console.WriteLine("Siła: {0}", Character.Strength);
                Console.WriteLine("Zręczność: {0}", Character.Agility);
                Console.WriteLine("Defense: {0}", Character.Defense);
                Console.WriteLine("Szczęście: {0}", Character.Luck);
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("SAZED: ");
                string przerywnik = "------------------------------------------------------";
                Console.WriteLine(przerywnik);
                Console.WriteLine("Witaj {0} musisz znaleźć Zane i dowiedzieć się czego chce i jakie ma plany wobec miasta.", Character.Name);
                Console.ReadKey();
                Console.WriteLine("Szybko!");
                Console.WriteLine("Nie ma czasu do stracenia!");
                Console.ReadKey();
                string ime_bohatera;
                if (wybor == 1)
                    ime_bohatera = "VIN";
                else
                    ime_bohatera = "ELEND";
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ime_bohatera);
                Console.WriteLine(przerywnik);
                Console.WriteLine("Wyruszam natychmiast!");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("***W grze posiadasz  kilka podstawowych statystyk, siłę, zręczność, obronę i szczęście***");
                Console.WriteLine("***Gdy miernik doświadczenia osiągnie 100 % możesz zdecydować w co przydzielisz dodatkowy punkt umiejętności***");
                Console.WriteLine("***Powodzenia!***");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Pada deszcz,");
                Console.WriteLine("stoisz na dachu w ubogiej dzielnicy miasta. Twój mgielny płaszcz powiewa swoimi luźnymi ");
                Console.WriteLine("pasami na wietrze, przed zmoknięciem chroni Cię jedynie kaptur");
                Console.ReadKey();
                Console.WriteLine("Nie wykrywasz w okolicy żadnych allomantów, podobnych tobie ludzi o naturalnej zdolności");
                Console.WriteLine("do spalania opiłków metali w swoim organiźmie aby uzuskać dodatkowe zdolności.");
                Console.ReadKey();
                Console.WriteLine("Jednak ty jesteś wyjątkowy, jesteś z mgły zrodzonym.");
                Console.WriteLine("Kiedy inni posiadają umiejętność spalania jednego rodzaju metalu, ty potrafisz korzystać z każdego.");
                Console.ReadKey();
                Console.WriteLine("Rozpalanie, uspokajanie, przyciąganie, odpychanie i wzmocnienie. ");
                Console.WriteLine("Twoim jedynym limitem jest ilość metali, które posiadasz w żołądku.");
                Console.ReadKey();
                Console.Clear();
                int liczba_fiolek;
                if (wybor2 == 1)
                    liczba_fiolek = 2;
                else
                    liczba_fiolek = 1;
                Console.WriteLine("***Posiadasz {0} fiolek z metalami***", liczba_fiolek);
                Console.ReadKey();
                Console.Clear();
                if (wybor2 == 2)
                {
                    Console.WriteLine("TENSOON:");
                    Console.WriteLine(przerywnik);
                    Console.WriteLine("Lepszej pogody nie było, prawda?");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine(Character.Name);
                    Console.WriteLine(przerywnik);
                    Console.WriteLine("Nie marudź, ty jak chcesz to zmienisz sobie ciało, ja nie mam takiego komfortu");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Kandra tylko parsknął.");
                    Console.WriteLine("Jako ta tajemnicza istota stworzona jeszcze przed rozbiciem ");
                    Console.ReadKey();
                    Console.WriteLine("mógł przybierać formę każdego stworzenia do jakiego ciała miał dostęp.");
                    Console.ReadKey();
                    Console.WriteLine(" Przez tą umiejętność jego rodzaj budził odrazę wśród ludzi, którzy nie rozumieją ich natury.");
                    Console.ReadKey();
                    Console.WriteLine("Tylko nieliczni widzieli prawdziwą formę kandra,");
                    Console.WriteLine(" bezkształtna masa wspierana na sztucznych lub naturalnych kościach aby formować jakiś kształt.");

                }


















            }





        }
    }
