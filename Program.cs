namespace Prototype;

class Program
{
    static void Main()
    {
        // Tässä luodaan alkuperäinen örkki npc, jota aiotaan kloonata.
        Orkki alkuperainen = new Orkki("Örkki", 38);
        // Tähän listaan tallentuu kaikki kloonatut örkit.
        List<Orkki> kloonatut = new List<Orkki>();

        // Valinta valikko toistetaan niin kauan kunnes käyttäjä itse painaa Enter lopettaaksen ohjelman ajon.
        while (true)
        {
            // Tulostetaan valikon tekstit eli näytä, kloonaa jne.
            Console.Write("\n[1] Näytä  [2] Kloonaa  [3] Poista viimeisin klooni  [Enter] Lopeta\nValinta: ");
            // Luetaan käyttäjän valinta eli 1, 2, 3 tai enter, ?? "" lisäyksellä varmistamme että valinta ei ole koskaan null, jottei ohjelma voisi koskaan kaatua myöhemmin.
            string valinta = Console.ReadLine() ?? "";

            switch (valinta)
            {
                case "":
                // Painamalla pelkkää enteriä se on tyhjä syöte eli lopetetaan ohjelma.
                    Console.WriteLine("\nLopetetaan...");
                    return;

                case "1":
                // Valitsemalla 1 näytetään alkuperäisen npc örkin tiedot eli örkki ja örkin leveli, lisäksi näytetään kaikki kloonatut örkit myös jos niitä on
                // Jos örkkejä ei ole tulostuu ei ole yhtään kloonattua örkkiä.
                    Console.WriteLine("\n-----------------");
                    Console.WriteLine("Alkuperäinen:");
                    alkuperainen.Tulosta();
                    Console.WriteLine("-----------------");

                // Tässä tapahtuu tarkistaminen onko kloonattuja örkkejä olemassa.
                    Console.WriteLine("Örkin kloonit:");
                    if (kloonatut.Count == 0)
                    {
                        Console.WriteLine("Ei ole yhtään kloonattua örkkiä.");
                        Console.WriteLine("-----------------");
                        break;
                    }

                // Käydään läpi kaikki kloonatut örkit kloonatut listalta ja tulostetaan kloonatut örkit.
                    int i = 0;
                    foreach (Orkki klooni in kloonatut)
                    {
                        klooni.Tulosta();
                        i++;
                        Console.WriteLine("-----------------");
                    }
                    break;

                case "2":
                // Tässä taphtuu alkuperäisen örkin kloonaaminen ja lisääminen kloonatut listaan.
                    kloonatut.Add((Orkki)alkuperainen.Clone());
                    Console.WriteLine("\nKloonattiin örkki.");
                    break;

                case "3":
                // Tässä tapahtuu viimeisimmän kloonin poistaminen jos listassa on klooneja.
                    if (kloonatut.Count > 0)
                    {
                        kloonatut.RemoveAt(kloonatut.Count - 1);
                        Console.WriteLine("\nViimeisin örkki klooni poistettu.");
                    }
                    else
                    {
                // Jos klooneja ei ole niin ilmoitetaan että ei ole kloonia jota poistaa.
                        Console.WriteLine("\nEi ole örkin kloonia jota poistaa.");
                    }
                    break;

                default:
                // Jos valinta on joku muukuin 1, 2 tai 3, ilmoitetaan käyttäjälle että syöte on väärä.
                    Console.WriteLine("\nVäärä valinta!!");
                    break;
            }
        }
    }
}