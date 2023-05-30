using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbenteuerSpiel
{
    internal class EinTagFrankfurt
        {
            public string userInput;
            public bool wahl1 = false;
            public bool wahl2 = false;
            public bool wahl3 = false;
            public bool wahl4 = false;
            public bool wahl5 = false;
            public bool wrongInput = false;
            public bool wiederSpielen = false;



            public void Wahl2()
            {

                do
                {
                    wahl1=false; wahl2=false;  
                    Console.Write("\t\tUser Eingabe:");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            wahl1 = true;
                            return;
                        case "2":
                            wahl2 = true;
                            return;


                        default:
                            Console.WriteLine("\t\tFalsche Eingabe");
                            wrongInput = true;
                            continue;
                    }
                } while (wrongInput);

            }

            public void Wahl3()
            {

                do
                {
                wahl1 = false; wahl2 = false; wahl3 = false;   
                Console.Write("\t\tUser Eingabe:");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            wahl1 = true;
                            return;
                        case "2":
                            wahl2 = true;
                            return;
                        case "3":
                            wahl3 = true;
                            return;


                        default:
                            Console.WriteLine("\t\tFalsche Eingabe");
                            wrongInput = true;
                            continue;
                    }
                } while (wrongInput);

            }

            public void Wahl4()
            {

                do
                {
                wahl1 = false; wahl2 = false; wahl3 = false;wahl4=false;
                Console.Write("\t\tUser Eingabe:");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            wahl1 = true;
                            return;
                        case "2":
                            wahl2 = true;
                            return;
                        case "3":
                            wahl3 = true;
                            return;
                        case "4":
                            wahl4 = true;
                            return;

                        default:
                            Console.WriteLine("\t\tFalsche Eingabe");
                            wrongInput = true;
                            continue;
                    }
                } while (wrongInput);
            }

            public void Wahl5()
            {

                do
                {
                wahl1 = false; wahl2 = false; wahl3 = false; wahl4 = false;

                Console.Write("\t\tUser Eingabe:");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            wahl1 = true;
                            return;
                        case "2":
                            wahl2 = true;
                            return;
                        case "3":
                            wahl3 = true;
                            return;
                        case "4":
                            wahl4 = true;
                            return;
                        case "5":
                            wahl5 = true;
                            return;

                        default:
                            Console.WriteLine("\t\tFalsche Eingabe");
                            wrongInput = true;
                            continue;
                    }
                } while (wrongInput);









            }
            public void Wilkommen()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("Hallo User =) Willkommen in neue Abenteuerspiel!\n");
                Console.WriteLine("*Ein Tag in Frankfurt*\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("............................................................................................\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Wir werden dir verschiedene Möglichkeiten zum Auswahl stellen.\nDu muss Nummer neben Auswahl eingeben und mit ENTER bestätigen, um weiter zu kommen.\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("............................................................................................\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Du kommst mit dem Zug am Samstag, 12 Uhr am Hauptbahnhof und bleibst dort genau 24 Stunden.\n\nHeute ist viel los in Stadt .. .. ..\n ");
                Console.WriteLine("Bist du bereit? Zum Starten druck eine beliebige Taste und ENTER, um Eingabe zu bestätigen.\n ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("............................................................................................\n");
                Console.ReadLine();
        }
            public void Scene1()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Du bist Gerade an Frankfurter Hauptbahnhof angekommen.\nWas willst du machen?\n");
                Console.WriteLine("\t(1)Mit dem Zug zur Zeil ins Shopping gehen");
                Console.WriteLine("\t(2)Zum Fuß durch Bahnofsvirtel gehen");
                Console.WriteLine("\t(3)Mit Taxi zum Museumsuferfest gehen");
                Console.WriteLine("\t(4)Bahn zur Messe");
                Console.WriteLine("\t(5)Taxi/Bahn zum Waldstadion\n");


            }
            public void SceneShopping()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Bravo, Du hast deine erst Schritte durch Frankfurt gemacht.\nWo willst du Shoppen gehen? ");
                Console.WriteLine("\t(1)Billige Laden wie New Yorker in Zeil Galerie");
                Console.WriteLine("\t(2)Teuere Laden wie Gucci neben Rathenau Platz ");

            }
            public void SceneShoppingZeil()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Nice, Du bist fertig mit dem Shopping.\nIn Frankfurt Zeit geht schnell vorbei, es ist schon 20 Uhr.\n");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");
            }
            public void SceneShoppingGucci()
            {
                Console.Clear(); 
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Wow das war teuer, Du bist fertig mit Shopping.\nIn Frankfurt Zeit geht schnell vorbei, es ist schon 20 Uhr.");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");
            }
            public void Bahnofsvirtel()
            {
                Console.Clear(); 
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Alter, das war schlechte Auswahl, hier alles stinkt nach Pinkel, sieht sehr gefährlich aus");
                Console.WriteLine("Jede 2 meter Fragt dich ein obdachloser ob du was kleingeld für Ihn hasst, du bist Schokiert");
                Console.WriteLine("Du rennst schnell zurück zum Hauptbahnhof, dein Leben ist dir wichtiger, du trinkst schnell ein Binding.");
                Console.WriteLine("und übelegst was willst du weiter machen.");
                Console.WriteLine("\t(1)Mit dem Zug zur Zeil ins Shopping gehen");
                Console.WriteLine("\t(2)Taxi zum Museumsuferfest gehen");
                Console.WriteLine("\t(3)Bahn zur Messe");
                Console.WriteLine("\t(4)Taxi/Bahn zum Waldstadion");
            }
            public void Museumsufer()
            {
                Console.Clear();    
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Bravo, Du hast deine erst Schritte durch Frankfurt gemacht.\nDu bist an Museumsuferfest angekommen.");
                Console.WriteLine("Was willst du machen?");
                Console.WriteLine("\t(1)Party Buhnen neben Main besuchen");
                Console.WriteLine("\t(2)Museen besuchen");
            }
            public void Partymachen()
            {
                Console.Clear();
                Console.WriteLine("Geil, du hast ganze Tag Party gemacht und am Ende geile Feuerwerk gesehen.");
                Console.WriteLine("In Frankfurt Zeit geht schnell vorbei, es ist schon 23Uhr.");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");
            }
            public void MuseenBesuchen()
            {
                Console.Clear(); 
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Wow, du kannst nicht glauben, wie viele Museen dort gibt, du hast so viele besucht.");
                Console.WriteLine("In Frankfurt Zeit geht schnell vorbei, es ist schon 21Uhr.");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");
            }
            public void Messe()
            {
                Console.Clear(); 
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Bravo, Du hast deine erst Schritte durch Frankfurt gemacht.\nDu bist an der Messe angekommen.");
                Console.WriteLine("Gerade ist Prolight und Sound Messe, was wilst du machen?");
                Console.WriteLine("\t(1)Lautersprecher presentationen ansehen");
                Console.WriteLine("\t(2)LichtShows anschauen");
            }
            public void Lautsprecher()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Wow, was für geile Klang, du bist überrascht mit Präsentationen.\nIn Frankfurt Zeit geht schnell vorbei, es ist schon 21Uhr.");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");
            }
            public void Licht()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Wow was für geile Lichtshow, du bist überrascht mit presentationen.\nIn Frankfurt Zeit geht schnell vorbei, es ist schon 21Uhr");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");
            }
            public void Stadion()
            {
                Console.Clear(); 
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Bravo, Du hast deine erst Schritte durch Frankfurt gemacht.\nDu bist an Stadion angekommen.");
                Console.WriteLine("Bald spielt Eintracht gegen Bayern, was wilst du machen?");
                Console.WriteLine("\t(1)Stadion Museum besuchen");
                Console.WriteLine("\t(2)Fußbal spiel anschauen");
            }
            public void StadionMuseum()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Wow, tolle Museum, du bist überrascht mit verein Geschichte.\nIn Frankfurt Zeit geht schnell vorbei, es ist schon 18Uhr.");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");

            }
            public void StadionSpiel()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Wow, was für ein Spiel am Ende war unentschieden 3-3.\nIn Frankfurt Zeit geht schnell vorbei, es ist schon 19Uhr.");
                Console.WriteLine("Bist du schon müde?\nOder du hast Bock noch was Leckeres zu esssen?");
                Console.WriteLine("\t(1)Schlafplatz Suchen");
                Console.WriteLine("\t(2)Essen gehen");

            }
            public void Schlafplatz()
            {
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Du bist in die Suche nach einem Schlafplatz.\n Wo willst du schlafen?");
                Console.WriteLine("\t(1)Hotel Buchnen");
                Console.WriteLine("\t(2)Auf der strase");
                wahl1 = false;
            wahl2 = false;
            Wahl2();
                if (wahl1)
                {
                    wahl1 = false;
                    Hotel();
                }
                else if (wahl2)
                {
                    wahl1 = false;
                    Strasse();
                    Wahl2();
                    if (wahl1)
                    {
                        Hotel();
                    }
                    else if (wahl2)
                    {
                        StrasseBleiben();
                    }
                }
            }
            public void Hotel()
            {
                wiederSpielen = false;
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Bravo du hast ein Zimmer gebucht.\nGute Nacht =)");
                Console.WriteLine("Morgen um 12 Fährt deine Zug nach Hause.");
                Console.WriteLine("Spiel ist beendet. Danke für das spielen.");
                Console.WriteLine("Mochtest du noch mal spielen?\n\t(1)Ja (2)Nein");
                Wahl2();
            if (wahl1)
            {
                wiederSpielen = true;
            }
        }
            public void Strasse()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Bist du sicher?? Hier ist sehr Gefährlich.\nEs gibt noch genug Zeit um eine Zimmer zu Buchen!");
                Console.WriteLine("(1)Hotel Buchnen");
                Console.WriteLine("(2)Hier Bleiben");

            }
            public void StrasseBleiben()
            {
                wiederSpielen = false;
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Wow das war eine kalte Nacht, was für eine Dumme Idee.\nBald fährt dein Zug nach Hause. ");
                Console.WriteLine("Spiel ist beendet. Danke für das spielen.");
                Console.WriteLine("Mochtest du noch mal spielen?(1)Ja (2)Nein");
                Wahl2();
                if (wahl1)
                {
                wiederSpielen = true;
                }
        }
            public void Essen()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n"); 
                Console.WriteLine("Du bist in Suche nach einem Restaurant\nWo willst du gehen?");
                Console.WriteLine("(1)Balkanische Essen");
                Console.WriteLine("(2)Pizza bei Italiener");
                Console.WriteLine("(3)Deutsche Spezialitäten");
                Wahl3();
                if (wahl1 || wahl2 || wahl3)
                {
                    EssenFertig();
                }
            }
            public void EssenFertig()
            {
                Console.Clear();
                Console.WriteLine("............................................................................................\n");
                Console.WriteLine("Umm das Essen war sehr lecker, es ist zu spät und Zeit für Schlafen.");
                Schlafplatz();
            }
            public void Menu1()
            {
                SceneShopping();
                Wahl2();
                if (wahl1)
                {
                    wahl1 = false;
                    SceneShoppingZeil();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                        Console.Clear();
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }
                else if (wahl2)
                {
                    wahl2 = false;
                    SceneShoppingGucci();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                        Console.Clear();
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }

            }
            public void Menu3()
            {
                Museumsufer();
                Wahl2();
                if (wahl1)
                {
                    wahl1 = false;
                    Partymachen();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                        Console.Clear();
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }
                else if (wahl2)
                {
                    wahl2 = false;
                    MuseenBesuchen();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                    Console.Clear();
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }


            }
            public void Menu4()
            {
                Messe();
                Wahl2();
                if (wahl1)
                {
                    wahl1 = false;
                    Lautsprecher();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                        Console.Clear();
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }
                else if (wahl2)
                {
                    wahl2 = false;
                    Licht();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }


            }
            public void Menu5()
            {
                Stadion();
                Wahl2();
                if (wahl1)
                {
                    wahl1 = false;
                    StadionMuseum();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                        Console.Clear();
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }
                else if (wahl2)
                {
                    wahl2 = false;
                    StadionSpiel();
                    Wahl2();
                    if (wahl1)
                    {
                        wahl1 = false;
                        Console.Clear();
                        Schlafplatz();


                    }
                    else if (wahl2)
                    {
                        Essen();
                    }
                }


            }

        }
    }


