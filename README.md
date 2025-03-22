Tämä on hyvin yksinkertainen ohjelma mikä näyttää miten Prototype pattern toimii C# ohjelmointikielellä.

Eli mitä ohjelmassa tapahtuu, kun ohjelma käynnistetään aukeaa valikko ja eri näppäimiä painamalla tapahtuu eri asioita.

[1] Näytä = Painike näyttää alkuperäisen örkin ja kloonatut örkit ja jos örkkejä ei ole tulostuu vain että ei ole yhtään kloonattua örkkiä.

[2] Kloonaa = Painike kloonaa alkuperäisen örkin ja sen tiedot eli tässä tapauksessa että se on örkki ja sen levelin.

[3] Poista viimeisin klooni = Painike poistaa viimeisimmän kloonatun örkin.

[Enter] Lopeta = Tämä painike lopettaa ohjelman.

Eli tämän esimerkin idea oli näyttää kuinka ajon aikaisesti pystyään luomaan örkkejä ja poistamaan niitä.
Eli kun luomme uusia örkkejä, pystymme kopioimaan niitä alkuperäisestä örkistä ja täten meidän ei tarvitse luoda tyhjästä uusia örkkejä.