# home-codeingStandardsRefactoring-chollweger
# Refactoring Ausarbeitung

* Was ist Refactoring Definition in eigenen Worten?

Mit Refactoring bezeichnet man die Überarbeitung der Struktur einer Software, ohne dass sich deren Verhalten nach außen ändert. Das Ziel ist es, den Programmcode überschaubarer und klarer zu strukturieren, um insbesondere die Aufwände für dessen Wartung und Pflege zu minimieren.


* Welche Vorteile/Nachteile birgt Refactoring?

  + Überschaubareres Script, lesbarer, strukturell verständlicher
  + Besser modifizierbar, besser testbar, redundanzen können vermieden werden 

  - Zusätzlicher Aufwand


* Was sind die Refactoring-Schritte?
  •	Umbenennen von Variablen und Methoden.
  •	Einkapseln von Feldern.
  •	Einführung einer neuen abstrakten Oberklasse.
  •	Entfernen und Neuordnen von Parametern.
  •	Umformatieren von Programmcode.
  •	Extraktion von Methoden, Klassen, Paketen und Schnittstellen.
  •	Verbesserung der Datenkapselung.

* Prinzipien von gutem Code?
  •	Leicht lesbar.
  •	Andere Entwickler können ihn besser lesen und verstehen.
  •	Wenig Abhängigkeit zu anderen Codes 
  •	Gut zu testen.
  •	Keine Duplizierungen.
  •	Keine Überraschungen.
  •	Klassen und Methoden sind auf die Erfüllung einer Aufgabe ausgerichtet und werden nicht durch Nebenaufgaben verunreinigt

* Was versteht man unter Code Smell?

Funktionierender, aber schlecht strukturierter Quellcode.


* Recherche von 10 Code Smells die Eure Projekt betreffen können, inkl. Beschreibung und Beispiel.

  •	Code-Duplikate: Quellcode der mehrfach verwendet wird (in identischer oder ähnlicher Form)

  •	Lange Methoden: Je länger eine Methode ist, desto fehleranfälliger ist sie. Zusätzlich erschweren lange Methoden die        Wiederverwendung.

  •	Umfangreiche Parameterlisten: Sie erschweren das Verständnis von Methodenaufrufen, da Attribute von Objekten als  Parameterliste übergeben werden, anstatt das Objekt an die Methode zu übergeben.

  •	Temporäre Felder: Felder einer Klasse beschreiben die Zustände ihrer Objekte, wobei ein Objekt ein Feld nur unter bestimmten Umständen bzw. temporär verwendet, so dass der Code schwer zu verstehen ist.

  •	Wiederholende Switch-Anweisungen: Sie werden an mehreren Codestellen verwendet, obwohl es besser wäre, sie als eigene Methode zu extrahieren.

  •	Große Klassen: Eine Klasse ist zu umfangreich, umfasst zu viele Instanzvariablen und duplizierten Code.

  •	Datenklasse: Klassen mit Feldern und Zugriffsmethoden ohne Funktionalität.

  •	Datenklumpen: Eine Gruppe von Objekten, welche häufig zusammen vorkommen.

  •	Unangebrachte Intimität: Zwei Klassen haben zu enge Verflechtungen miteinander.

  •	Faule Klasse: Eine Klasse leistet zu wenig, um ihre Existenz zu rechtfertigen.

  •	Middle Man (Vermittler): Eine Klasse delegiert alle Methodenaufrufe an eine andere Klasse.



