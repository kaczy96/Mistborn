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
                
                int chose = int.Parse(Console.ReadLine());
                while(chose !=1 && chose !=2)
                chose = int.Parse(Console.ReadLine() + "Type property value");

            Console.Clear();
                Console.WriteLine("Take your starting gift: ");
                Console.WriteLine();
                Console.WriteLine("1) Flask with allomancy metals");
                Console.WriteLine("2) Kandra companion");
                Console.WriteLine("3) Glass dagger");
                int chose2 = int.Parse(Console.ReadLine());
                while (chose2 != 1 && chose2 != 2 &&
                chose2!=3)
                chose2 = int.Parse(Console.ReadLine() + "Type property value");

            switch (chose)
                {
                    case (1):
                        {
                            switch (chose2)
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

                                        Equipment Glass_dagger = new Equipment();
                                        Glass_dagger.Damage = 3;
                                        Glass_dagger.Endurance = 3;
                                        break;
                                    }
                            }
                            break;
                        }
                    case (2):
                        {
                            switch (chose2)
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

                                        Equipment Glass_dagger = new Equipment();
                                        Glass_dagger.Damage = 3;
                                        Glass_dagger.Endurance = 3;
                                        break;
                                    }
                            }

                            break;
                        }
                }



                Equipment no_weapon = new Equipment();
                no_weapon.Error = 0;

                Console.Clear();
                Console.WriteLine("Your Character: ");
                Console.WriteLine(Character.Name);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Health: {0}", Character.Hp);
                Console.WriteLine("Strength: {0}", Character.Strength);
                Console.WriteLine("Agility: {0}", Character.Agility);
                Console.WriteLine("Defense: {0}", Character.Defense);
                Console.WriteLine("Luck: {0}", Character.Luck);
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("SAZED: ");
                string pause = "------------------------------------------------------";
                Console.WriteLine(pause);
                Console.WriteLine("Witaj {0} musisz znaleźć Zane i dowiedzieć się czego chce i jakie ma plany wobec miasta.", Character.Name);
                Console.ReadKey();
                Console.WriteLine("Szybko!");
                Console.WriteLine("Nie ma czasu do stracenia!");
                Console.ReadKey();
                string character_name;
                if (chose == 1)
                    character_name = "VIN";
                else
                    character_name = "ELEND";
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(character_name);
                Console.WriteLine(pause);
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
                int flask_amount;
                if (chose2 == 1)
                    flask_amount = 2;
                else
                    flask_amount = 1;
                Console.WriteLine("***Posiadasz {0} fiolek z metalami***", flask_amount);
                Console.ReadKey();
                Console.Clear();
                if (chose2 == 2)
                {
                    Console.WriteLine("TENSOON:");
                    Console.WriteLine(pause);
                    Console.WriteLine("Lepszej pogody nie było, prawda?");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine(Character.Name);
                    Console.WriteLine(pause);
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
