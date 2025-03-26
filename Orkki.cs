namespace Prototype;

// Orkki luokka toteuttaa IOrkki-rajapinnan.
// Tässä luokassa tapahtuu itse shallow copy örkin kloonaamisessa.
class Orkki : IOrkki
{
    private string npc; // muuttuja johon örkki npc tallentuu.
    private int lvl; // muuttuja johon örkin level tallentuu.
    private Varusteet varusteet; // tämä on viitetyyppi varusteet luokasta eli shared, koska teemme koodista shallow copy esimerkin.

    // Örkin konstruktori örkin luomista varten.
    public Orkki(string npc, int lvl, Varusteet varusteet)
    {
        this.npc = npc; // asetaan npc örkki
        this.lvl = lvl; // asetetaan örkin lvl
        this.varusteet = varusteet; // asetetaan örkille varusteet
    }

    // CLone()- metodi tekee shallow copyn kutsumalla MemberwiseClone()-metodia.
    // Tämä kopioi kentät sellaisenaan, joten varusteet viittaus on sama alkuperäisellä ja kloonilla.
    public IOrkki Clone()
    {
        return (IOrkki)this.MemberwiseClone(); // Luo klooni örkin täysin samoilla arvoilla kuin alkuperäinen.
    }

    // Metodi, jolla pystyy vaihtamaan örkin varusteen.
    // koska varuste on viitetyyppi, muutos näkyy myös alkuperäisessä ja kloonissa.
    public void MikäVaruste(string varuste)
    {
    // Huom. shallow copyssä sama Varusteet-olio jaetaan
        varusteet.varuste = varuste;
    }
    // Tulostus metodi.
    // Tulostetaan npc:n tiedot eli örkki, lelvel ja varuste.
    public void Tulosta()
    {
        Console.WriteLine($"NPC: {npc}, Level: {lvl}, Equipment: {varusteet.varuste}"); // Tulostetaan npc: eli örkki, level ja varuste.
    }
}



