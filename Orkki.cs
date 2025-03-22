namespace Prototype;

// Orkki luokka toteuttaa IOrkki-rajapinnan.
class Orkki : IOrkki
{
    private string npc; // muuttuja johon örkki npc tallentuu.
    private int lvl; // muuttuja johon örkin level tallentuu.

    // Örkin konstruktori örkin luomista varten.
    public Orkki(string npc, int lvl)
    {
        this.npc = npc; // asetaan npc örkki
        this.lvl = lvl; // asetetaan örkin lvl
    }

    // Örkin kloonaus metodi, eli metodi palauttaa identtisen kopion alkuperäisestä örkistä.
    public IOrkki Clone()
    {
        return new Orkki(npc, lvl); // Luo klooni örkin täysin samoilla arvoilla kuin alkuperäinen.
    }
    // Tulostus metodi.
    // Tulostetaan npc:n tiedot eli örkki ja sen level
    public void Tulosta()
    {
        Console.WriteLine($"NPC: {npc}, Level: {lvl}"); // Tulostetaan npc: eli örkki ja sen level.
    }
}



