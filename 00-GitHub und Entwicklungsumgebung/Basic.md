# C#

### 1. Einführung

**C#** ist eine typsichere, objektorientierte Allzweck-Programmiersprache. Historisch wurde in C# fast exklusiv für Windows entwickelt. Durch Xamarin ist es inzwischen aber auch möglich, für macOS, iOS und Android zu entwickeln. Zudem gibt es mit .NET Core auch offizielle Unterstützung für GNU/Linux und macOS [1].

In der normalen Betriebsart werden C#-Quelltexte in eine meist als *IL* bezeichnete Zwischensprache übersetzt, die (normalerweise durch einen *JIT-Compiler*) auf allen Plattformen ausgeführt werden kann, auf denen eine geeignete Laufzeitumgebung zur Verfügung steht. Darüber hinaus gibt es verschiedene Ansätze der AOT-Compilierung, um plattformspezifischen Maschinencode vorab zu erzeugen.

Bis Version 2 war die Sprache bei [ISO](http://standards.iso.org/ittf/PubliclyAvailableStandards/c042926_ISO_IEC_23270_2006(E).zip) als Standard regstriert. In der Folge erschienen regelmäßig umfangreiche Erweiterungen der Sprache durch Microsoft. Durch die Entwicklung des Referenc-Compilers als Open Source (seit 2014) sind auch Community-Beiträge möglich.

### 2. Konzepts

C# greift Konzepte der Programmiersprachen Java, C++, Haskell, C sowie von Delphi auf. C# zählt zu den objektorientierten Programmiersprachen und unterstützt sowohl die Entwicklung von sprachunabhängigen .NET-Komponenten als auch COM-Komponenten für den Gebrauch mit Win32-Anwendungsprogrammen.

Einige der Elemente von C++, die im Allgemeinen als unsicher gelten, wie beispielsweise Zeiger, werden in C# nur für sogenannten „unsicheren Code“ erlaubt, der in Zonen mit eingeschränkten Rechten (z. B. bei Programmen, die aus Webseiten heraus ausgeführt werden) ohne die Zuteilung erweiterter Rechte nicht ausgeführt wird.

### 3. Entwicklungsschritte

Erscheinungsjahr | .NET-Version | C#-Version
--- | --- | ---
2002 | 	.NET 1.0 |	C# 1.0
2003 |	.NET 1.1 |	C# 1.2
2005 |	.NET 2.0 | C# 2.0
2006 |	.NET 2.0 | C# 3.0
2010 |	.NET 4.0 |	C# 4.0
2019 |	.NET Core 3 |	C#8.0

### 4. Hello World Beispiel
```c#
using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hallo Welt!");
    }
}
```
### Referenzen

[1] Bis hier her siehe: Joseph Albahari; Ben Albahari: C# 6.0 in a Nutshell. The Definitive Reference. 6. Auflage. O'Reilly, Sebastopol 2016, ISBN 978-1-4919-2706-9, S. 1–6. Joseph Albahari; Ben Albahari: C# 6.0 Pocket Reference Instant Help for C# 6.0 Programmers. O'Reilly, Sebastopol 2015, ISBN 978-1-4919-2741-0, S. 1.

[2] http://standards.iso.org/ittf/PubliclyAvailableStandards/c042926_ISO_IEC_23270_2006(E).zip