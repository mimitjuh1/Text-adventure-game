using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inventory = new string[3];
            inventory[0] = "Leeg";
            inventory[1] = "Leeg";
            inventory[2] = "Leeg";

            string naam = "";
            naam = start(naam);
            kamerEen(inventory, naam);
        }

        static string start(string naam)
        {
            string ready = "";

            Console.WriteLine("Welkom in de wereld van Fesca!\nWat is jouw naam?: ");
            naam = Console.ReadLine();

            Console.WriteLine("Hallo {0}, wat heb jij toch een mooie naam!\nBen je klaar voor je avontuur? [y/N]", naam);
            ready = Console.ReadLine();
            while (true)
            {
                if (ready.Equals("y") || ready.Equals("Y") || ready.Equals(""))
                {
                    return naam;
                }
                else
                {
                    Console.WriteLine("Alsjeblieft laten we op een avontuur gaan {0}! [y/N]", naam);
                    ready = Console.ReadLine();
                }
            }
        }

        static string[] menu(string[] inventory)
        {
            string awnser;

            Console.WriteLine("\nInventory: [{0}] [{1}] [{2}]\nType help om hulp te krijgen.", inventory[0], inventory[1], inventory[2]);
            while (true)
            {
                 awnser = Console.ReadLine();

                if (awnser == "help")
                {
                    Console.WriteLine("gebruik [object name] or [item name]\nkijk [object name] or [item name]\npraat [object name] or [item name]\ngooi [object name] or [item name]");
                }
                else
                {
                    string[] awnsers = awnser.Split(' ');
                    
                    return awnsers;
                }
            }
        }

        static void kamerEen(string[] inventory, string naam)
        {
            string[] antwoord;
            int computer = 0;
            int deur = 0;

            Console.Clear();
            Console.WriteLine("Je wordt wakker op de grond van een kamer zonder ramen.\nDe hele kamer is leeg op een computer en een deur na.");

            while (true)
            {
                antwoord = menu(inventory);

                if (antwoord[0].ToLower() == "gebruik")
                {
                    if (antwoord[1].ToLower() == "computer" && computer.Equals(0))
                    {
                        Console.WriteLine("Jij loopt naar de computer toe en zet hem aan.\nEen knipperend groen licht komt van de monitor af.\nDe Computer vraagt om een gebruikersnaam en wachtwoord.");
                        computer++;
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(1))
                    {
                        Console.WriteLine("Jij begint zeer ingewikkelde algeritmes te gebruiken om het wachtewoord van de computer te kraken.\nDaarna drukte je op de knop: ENTER.\nUit het niets hoor je een stem.\nHet lijkt wel uit de luidsprekers van de computer te komen.\n*U fockin wot m8!!1!\nIll bash ur fockin aed in, I swear on me mom!11!!");
                        Console.WriteLine("De computer blaast zichzelf op!\nOnder de opgeblazen stukjes PC vind je een sleutel!");
                        inventory[0] = "sleutel van een deur ofzo";
                        computer = 2;
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(2))
                    {
                        Console.WriteLine("De computer is weg.");
                    }
                    else if (antwoord[1].ToLower() == "deur" && deur.Equals(0))
                    {
                        Console.WriteLine("Je loopt naar de deur toe.\nProbeert de deur open te maken.\nHij gaat open.\nWow dat ging makkelijk!");
                        Thread.Sleep(5000);
                        kamerTwee(inventory, naam);
                    }

                    try
                    {
                        if (antwoord[1].ToLower() == "sleutel" && antwoord[2].ToLower() == "deur")
                        {
                            Console.WriteLine("Huh apart de deur lijkt niet op slot te zijn.");
                        }
                    }
                    catch
                    {
                        if (antwoord[1].ToLower() == "sleutel")
                        {
                            Console.WriteLine("Je gebruikt de sleutel op niets...");
                        }
                    }
                }
                else if (antwoord[0].ToLower() == "kijk")
                {
                    if (antwoord[1].ToLower() == "computer" && computer.Equals(0))
                    {
                        Console.WriteLine("Jij kijkt in de richting van de computer.\nHet ziet er naar uit dat de computer uit is.");
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(1))
                    {
                        Console.WriteLine("Jij kijkt naar de computer.\nHoe langer je kijkt, hoe intimer het wordt.\nDe computer begint te blozen.\nDe computer geeft je een sleutel en zegt: ALSJEBLIEFT SSS-SENPAI!");
                        Console.WriteLine("Nadat je de sleutel aan neemt verdwijnt de computer en zie je het nooit meer terug.");
                        inventory[0] = "sleutel van een deur ofzo";
                        computer = 2;
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(2))
                    {
                        Console.WriteLine("De computer is weg.");
                    }
                    else if (antwoord[1].ToLower() == "deur" && deur.Equals(0))
                    {
                        Console.WriteLine("Jij kijkt richting de deur.\nWow wat een prachtige deur!");
                    }
                }
                else if (antwoord[0].ToLower() == "praat")
                {
                    if (antwoord[1].ToLower() == "computer" && computer.Equals(0))
                    {
                        Console.WriteLine("Jij begint te praten tegen de computer en zegt: ");
                        Console.ReadLine();
                        Console.WriteLine("Om 1 of andere reden lijkt de computer niet te reageren.\nMisschien staat de computer wel uit.");
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(1))
                    {
                        Console.WriteLine("Jij begint te praten tegen de computer en zegt: ");
                        Console.ReadLine();
                        Console.WriteLine("Ja heel leuk jij vleeshoofd, antwoord de computer.\nAls jij hier zo graag wilt zijn ga ik maar lekker weg.\n Howdo!\nDe computer doet de deur van de kamer open en is weg.\nNiemand heeft hem ooit nog terug gevonden.");
                        Console.WriteLine("Op de plek waar de computer stond ligt nu een sleutel.\nJij besluit de sleutel in je rugzak te stoppen.");
                        inventory[0] = "sleutel van een deur ofzo";
                        computer = 2;
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(2))
                    {
                        Console.WriteLine("De computer is weg.");
                    }
                    else if (antwoord[1].ToLower() == "deur" && deur.Equals(0))
                    {
                        Console.WriteLine("Je begint tegen de deur te praten.\nDeuren hebben kennelijk niet zoveel te zeggen.");
                    }
                }
                else if (antwoord[0].ToLower() == "gooi")
                {
                    if (antwoord[1].ToLower() == "computer" && computer.Equals(0))
                    {
                        Console.WriteLine("Je loopt naar de computer toe.\nPakt hem op en gooit hem tegen de muur aan.\nOp de plek waar de computer stond ligt nu een sleutel.\nJij besluit de sleutel in je rugzak te stoppen.");
                        inventory[0] = "sleutel van een deur ofzo";
                        computer = 2;
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(1))
                    {
                        Console.WriteLine("Je loopt naar de computer toe.\nPakt hem op en gooit hem tegen de muur aan.\nOp de plek waar de computer stond ligt nu een sleutel.\nJij besluit de sleutel in je rugzak te stoppen.");
                        inventory[0] = "sleutel van een deur ofzo";
                        computer = 2;
                    }
                    else if (antwoord[1].ToLower() == "computer" && computer.Equals(2))
                    {
                        Console.WriteLine("De computer is weg.");
                    }
                    else if (antwoord[1].ToLower() == "deur" && deur.Equals(0))
                    {
                        Console.WriteLine("Je loopt naar de deur toe.\nProbeert hem op te pakken.\nHelaas zit de deur goed vast.");
                    }
                }
            }
        }

        static void kamerTwee(string[] inventory, string naam)
        {
            string[] antwoord;
            int koning = 0;
            int honger = 5;
            int spruitjes = 0;

            Console.Clear();
            Console.WriteLine("Je loopt de kamer binnen.");
            Thread.Sleep(2000);
            Console.WriteLine("Het is een bizarre kamer.");
            Thread.Sleep(2000);
            Console.WriteLine("In het midden van de kamer zit een grote plas water met een koning er in.");
            Thread.Sleep(2000);
            Console.WriteLine("Om de koning heen zie je een groep vissen zwemmen.");
            Thread.Sleep(2000);
            Console.WriteLine("In de hoek van de kamer ligt een grote stapel met Iphones.");
            Thread.Sleep(2000);
            Console.WriteLine("De deur waar jij uit kwam verdwijnt.");
            Thread.Sleep(2000);
            Console.WriteLine("Gelukkig zie je aan het einde van deze kamer ook een deur.");
            Thread.Sleep(2000);

            while (true)
            {
                antwoord = menu(inventory);
                if (antwoord[0].ToLower() == "gebruik")
                {
                    try
                    {
                        if (antwoord[1].ToLower() == "koning" && antwoord[2].ToLower() == "spruitjes")
                        {
                            Console.WriteLine("Hey je moet de spruitjes aan mij voeren niet mij aan de spruitjes!");
                            Thread.Sleep(2000);
                        }
                    }
                    catch
                    {
                        if (antwoord[1].ToLower() == "koning")
                        {
                            Console.WriteLine("Hey geen gekke dingen in je hoofd halen he?");
                            Thread.Sleep(2000);
                        }
                    }
                    
                    try
                    {
                        if (antwoord[1].ToLower() == "spruitjes" && antwoord[2].ToLower() == "koning")
                        {
                            if (spruitjes == 0)
                            {
                                Console.WriteLine("Ik zei dat je me spruitjes moet voeren!");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                for (int i = 0; i < spruitjes; i++)
                                {
                                    Console.WriteLine("NOMNOMNOM!");
                                    honger--;
                                    Thread.Sleep(1000);
                                }

                                spruitjes = 0;
                                inventory[1] = "leeg";

                                if (honger != 0)
                                {
                                    Console.WriteLine("Dankjewel voor de spruitjes maar ik heb nog steeds honger.");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Ik heb nog {0} spruitjes nodig!", honger);
                                }
                                else
                                {
                                    Console.WriteLine("Dankjewel mijn kleine hulp!");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Ik zal je nu belonen!");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Er komt een vel wit licht bij de koning vandaan.");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Wanneer het licht verdwenen is zie je een cavia in het water liggen waar de koning zat.");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("De cavia begint te spreken en zegt:");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Ik koning Willie ben nu een cavia!");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Nou dit was een super cadeau...");
                                    Thread.Sleep(2000);
                                    koning = 2;
                                    inventory[1] = "Potentie";
                                }
                            }
                        }
                    }
                    catch
                    {
                        if (antwoord[1].ToLower() == "spruitjes")
                        {
                            if (spruitjes == 0)
                            {
                                Console.WriteLine("Je probeert een spruitje te eten.");
                                Thread.Sleep(2000);
                                Console.WriteLine("Maar je hebt geen spruitjes...");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Je eet een spruitje!");
                                Thread.Sleep(2000);
                                Console.WriteLine("Het volgende antwoord kan ja of nee zijn, want dat ligt er aan of je spruitjes lust.");
                                Thread.Sleep(2000);
                                spruitjes--;
                            }
                        }
                    }
                    
                    if (antwoord[1].ToLower() == "water")
                    {
                        Console.WriteLine("Je drintk wat water.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Het smaakt naar spruitjes...");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "vissen")
                    {
                        Console.WriteLine("Je gebruikt de vissen.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Misschien is dit te veel informatie...");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "iphone")
                    {
                        Console.WriteLine("Je gebruikt de Iphone.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oh laat maar het is een Iphone 3G.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Die wilt niemand gebruiken.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "deur")
                    {
                        Console.WriteLine("Je loopt naar de deur toe.\nProbeert de deur open te maken.\nHij gaat open.\nWow dat ging makkelijk!");
                        Thread.Sleep(5000);
                        kamerDrie(inventory, naam);
                    }
                }
                else if (antwoord[0].ToLower() == "kijk")
                {
                    if (antwoord[1].ToLower() == "koning" && koning < 2)
                    {
                        Console.WriteLine("De koning lijkt verdomt erg op Koning Willem-Alexander.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "koning" && koning == 2)
                    {
                        Console.WriteLine("De koning is nu een cavia.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Raar genoeg draagt de cavia nu een kroon.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "water" && koning != 2)
                    {
                        Console.WriteLine("Je kijkt in het water.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Raar genoeg liggen er allemaal spruitjes in het water.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Je haalt een spruitje uit het water.");
                        Thread.Sleep(2000);

                        spruitjes++;
                        if (inventory[1] != "spruitjes")
                        {
                            inventory[1] = "spruitjes";
                        }
                    }
                    else if (antwoord[1].ToLower() == "water" && koning == 2)
                    {
                        Console.WriteLine("Je kijkt in het water.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Raar genoeg liggen er allemaal spruitjes in het water.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Je hoeft geen spruitjes mee hebben.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "vissen")
                    {
                        Console.WriteLine("Je kijkt naar de vissen");
                        Thread.Sleep(2000);
                        Console.WriteLine("Wow het zijn een paar prachtige vissen.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Zo veel kleuren!");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "iphone")
                    {
                        Console.WriteLine("Je kijkt naar de Iphone.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oh laat maar het is een Iphone 3G.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Daar wilt niemand naar kijken.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "deur")
                    {
                        Console.WriteLine("Jij kijkt richting de deur.\nWow wat een prachtige deur!");
                    }
                }
                else if (antwoord[0].ToLower() == "praat")
                {
                    if (antwoord[1].ToLower() == "koning" && koning == 0)
                    {
                        Console.WriteLine("Hallo mijn naam is Koning Willie.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Antwoord de koning voordat je wat kan zeggen.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Ik heb honger, breng mij 10 spruitjes en dan zal ik je rijkelijk belonen!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Kennelijk moet je wat doen voor de koning en hij reageert niet als je wat zegt.");
                        Thread.Sleep(2000);
                        koning++;
                    }
                    else if (antwoord[1].ToLower() == "koning" && koning == 1)
                    {
                        Console.WriteLine("Heb je al mijn spruitjes al?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Ik heb honger!");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "koning" && koning == 2)
                    {
                        Console.WriteLine("Ik ben nu een cavia!");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "water")
                    {
                        Console.WriteLine("Je praat tegen het water.");
                        Thread.Sleep(2000);
                        Console.WriteLine("De vissen lachen je uit!");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "vissen")
                    {
                        Console.WriteLine("Je praat met de vissen.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Als je in het water kijkt zie je allemaal spruitjes!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Zeggen de vissen.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "iphone")
                    {
                        Console.WriteLine("Je praat tegen de Iphone.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oh laat maar het is een Iphone 3G.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Die heeft nog geen Siri.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "deur")
                    {
                        Console.WriteLine("Jij begint tegen de deur te praten.\nDeuren hebben kennelijk niet zoveel te zeggen.");
                    }
                }
                else if (antwoord[0].ToLower() == "gooi")
                {
                    if (antwoord[1].ToLower() == "koning" && koning < 2)
                    {
                        Console.WriteLine("De koning is te groot om hem te gooien.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "koning" && koning == 2)
                    {
                        Console.WriteLine("Je pakt de koning op en gooit hem uit het water!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Hey laat me lekker in het water liggen!");
                        Thread.Sleep(2000);
                        Console.WriteLine("De koning rent snel terug het water in.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "water")
                    {
                        Console.WriteLine("Je gooit met water!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Je voelt je weer 10 jaar oud.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "vissen")
                    {
                        Console.WriteLine("Je probeert een vis uit het water te pakken en weg te gooien.");
                        Thread.Sleep(2000);
                        Console.WriteLine("De vissen zwemmen snel weg.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "iphone")
                    {
                        Console.WriteLine("Je gooit de Iphone weg");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oh nee dat was een Iphone 6S");
                        Thread.Sleep(2000);
                        Console.WriteLine("Shit, die had ik willen hebben...");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "deur")
                    {
                        Console.WriteLine("Je loopt naar de deur toe.\nProbeert hem op te pakken.\nHelaas zit de deur goed vast.");
                    }
                }
            }
        }

        static void kamerDrie(string[] inventory, string naam)
        {
            string[] antwoord;

            Console.Clear();
            Console.WriteLine("Achter de deur licht een kleine pilaar met daar op een goudklomp");
            Thread.Sleep(2000);
            Console.WriteLine("Onder de goudklomp staat een bordje met niet aankomen.");
            Thread.Sleep(2000);

            while (true)
            {
                antwoord = menu(inventory);
                if (antwoord[0].ToLower() == "gebruik")
                {
                    if (antwoord[1].ToLower() == "goudklomp")
                    {
                        Console.WriteLine("Je pakt de goudklomp van het pilaar af.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oppeens komt er een groot wit licht van de grond af.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Je valt bewusteloos neer.");
                        inventory[2] = "goudklomp";
                        epilog(inventory, naam);
                    }
                    else if (antwoord[1].ToLower() == "bordje")
                    {
                        Console.WriteLine("Je pakt het bordje van het pilaar af.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Oppeens komt er een groot wit licht van de grond af.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Je valt bewusteloos neer.");
                        inventory[2] = "bordje";
                        epilog(inventory, naam);
                    }
                }
                else if (antwoord[0].ToLower() == "kijk")
                {
                    if (antwoord[1].ToLower() == "goudklomp")
                    {
                        Console.WriteLine("Wat een prachtige klomp goud!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Had ik die maar in mijn bezit.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "bordje")
                    {
                        Console.WriteLine("Wow dat is een vreselijk handschrift.");
                        Thread.Sleep(2000);
                        Console.WriteLine("De persoon had vast geen nut voor de goudklomp.");
                        Thread.Sleep(2000);
                    }
                }
                else if (antwoord[0].ToLower() == "praat")
                {
                    if (antwoord[1].ToLower() == "goudklomp")
                    {
                        Console.WriteLine("Je praat tegen de goudklomp.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Je hoort niks terug maar je zou die goudklomp toch graag willen hebben!");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "bordje")
                    {
                        Console.WriteLine("Je praat tegen het bordje.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Je zou willen dat het bordje er niet was zodat je de goudklomp kon hebben.");
                        Thread.Sleep(2000);
                    }
                }
                else if (antwoord[0].ToLower() == "gooi")
                {
                    if (antwoord[1].ToLower() == "goudklomp")
                    {
                        Console.WriteLine("Je probeert de goudklomp te gooien.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Maar het is te mooi om weg te gooien.");
                        Thread.Sleep(2000);
                    }
                    else if (antwoord[1].ToLower() == "bordje")
                    {
                        Console.WriteLine("Je probeert het bordje te gooien.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Het bordje is te lelijk om weg te gooien.");
                        Thread.Sleep(2000);
                    }
                }
            }
        }

        static void epilog(string[] inventory, string naam)
        {
            int punten = 0;

            Console.WriteLine("Welkom {0}, jij hebt de uitdagingen overleeft.", naam);
            Thread.Sleep(2000);
            Console.WriteLine("Nu word je beoordeeld op hoe jij het gedaan hebt.");
            Thread.Sleep(2000);

            if (inventory[0] == "sleutel van een deur ofzo")
            {
                Console.WriteLine("Jij hebt de sleutel van de computer gekregen, hopelijk heeft hij het overleeft!");
                Thread.Sleep(4000);
                punten++;
            }
            else
            {
                Console.WriteLine("Zonder sleutel kan jij niet verwachten de eerste uitdaging te kunnen overleven, maar toch sta je hier?");
                Thread.Sleep(4000);
            }

            if (inventory[1] == "Potentie")
            {
                Console.WriteLine("Door het helpen van Koning Willie de Cavia heb je laten zien dat jij de Potentie hebt om iedereen te helpen!");
                Thread.Sleep(4000);
                punten++;
            }
            else
            {
                Console.WriteLine("Je hebt de Koning niet geholpen, ik snap het wel maar jammer dit...");
                Thread.Sleep(4000);
            }

            if (inventory[2] == "goudklomp")
            {
                Console.WriteLine("Helaas het goede antwoord was het bordje, die moest je op pakken...");
                Thread.Sleep(4000);
            }
            else if (inventory[2] == "bordje")
            {
                Console.WriteLine("Goedzo je hebt het bordje mee genomen!");
                Thread.Sleep(2000);
                Console.WriteLine("Hopelijk vond je mijn handschrift mooi!");
                Thread.Sleep(4000);
            }

            Console.WriteLine("Oke nu ga ik kijken welk einde je krijgt.");
            Thread.Sleep(2000);
            Console.WriteLine("Ja ik snap het dit is ontzettend META...");
            Thread.Sleep(2000);

            if (punten == 3)
            {
                Console.WriteLine("Oke super jij krijgt het beste einde!");
                Thread.Sleep(2000);
                Console.WriteLine("Je word beloond met 20.000.000 euro in hondenvoer.");
                Thread.Sleep(4000);
            }
            else if (punten == 2)
            {
                Console.WriteLine("Oke super jij krijgt het goede einde!");
                Thread.Sleep(2000);
                Console.WriteLine("Je krijgt een Goudvis en een Cavia met een Aquarium.");
                Thread.Sleep(4000);
            }
            else if (punten == 1)
            {
                Console.WriteLine("Oeh, nou je hebt tenminste niet het slechtste einde gekregen");
                Thread.Sleep(2000);
                Console.WriteLine("Zonder pardon wordt je in elkaar getrapt door een groep paarden met tattoos van hakenkruisen op hun achterwerk.");
                Thread.Sleep(4000);
                Console.WriteLine("Nee het zijn geen ponies...");
                Thread.Sleep(4000);
            }
            else if (punten == 0)
            {
                Console.WriteLine("Nou het slechtste einde, hier komt het!");
                Thread.Sleep(2000);
                Console.WriteLine("Jouw moeder is ontzettend lelijk!");
                Thread.Sleep(4000);
                Console.WriteLine("Ha daar kan je niet tegen op!");
                Thread.Sleep(4000);
            }

            Console.WriteLine("Nou ik hoop dat jij het einde leuk vond.");
            Thread.Sleep(20000);
            Console.WriteLine("Oke doei!");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
