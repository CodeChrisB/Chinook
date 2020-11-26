# .NET/C#/LINQ

## Lehrziele:

* Wie LINQ für Abfragen angewendet wird.
* Wie csv-Daten in Objekten transformiert werden (DataExtensions).
## Aufgabenstellung
Chinook ist ein Media-Store mit dem Ziel, seinen Kunden den bestmöglichen Service zu bieten. Um
die Dienste an den Kunden entsprechend anzupassen, benötigt die Marketing Abteilung
Informationen. Das bestehende System beinhaltet die Stammdaten und Bewegungsdaten aus der
Vergangenheit. Betrachten wir nun folgendes Datenmodel:
Anforderungen
Die Marketing Abteilung benötigt für ihre nächsten Aktivitäten Informationen aus den Datenbeständen.

## Datenbeständen:
* Track-Zeit-Auswertung
  * Track mit Maximalzeit [sec]
  * Track mit Minimalzeit [sec]
  * Durchschnittszeit [sec]
* Album-Zeit-Auswertung
  * Album mit Maximalzeit [sec]
  * Album mit Minimalzeit [sec]
  * Durchschnittszeit [sec]
  * Track-Verkauf-Auswertung
  * Track mit der höchsten Verkaufszahl
  * Track mit der minimalen Verkaufszahl
  * Track mit dem höchsten Umsatz
  * Track mit dem geringsten Umsatz
* Kunden-Auswertung
  * Kunde mit höchsten Umsatz
  * Kunde mit geringstem Umsatz
  * Durchschnittsumsatz
* Genre-Verkauf-Auswertung
  * Genre mit der höchsten Verkaufszahl
  * Genre mit der minimalen Verkaufszahl

---
##### Die Auswertung erfolgt in einer einfachen Konsolenanwendung:
* Verwenden Sie nur LINQ für die Abfragen!
* Trennen Sie die Schichten ‚Entities‘ von Abfrage-Logik
* Die ‚Entities‘ sollen minimal sein, d.h., nur so viele wie notwendig
* Achten Sie auf eine entsprechende Archietektur.

Quellen
[Chinook Database](http://chinookdatabase.codeplex.com/)
Viel Spaß!