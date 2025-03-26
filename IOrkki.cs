namespace Prototype;

// Määritetään IOrkki-rajapinta, jossa on Clone-metodi
interface IOrkki
{
    IOrkki Clone(); // Tässä on kloonausmetodi, eli kloonataan alkuperäinen örkki.
    void Tulosta(); // Tässä on tulostusmetodi, tulostetaan örkin tiedot.
}



