namespace Prototype;


// Tämä varusteet luokka on viiteluokka.
// koska esimerkissä tehdään shallow copy, eli varusteet luokkaa jaetaan alkuperäisen ja kloonien kesken.
public class Varusteet
{
    public string varuste; // varustet muuttuja johon varuste tallentuu.

    // varusteen konstruktori varusteen luomista varten.
    public Varusteet(string varuste)
    {
        this.varuste = varuste;
    }
}