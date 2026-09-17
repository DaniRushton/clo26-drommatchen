# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  
**Grupp:**  
**Datum:**  
**GitHub:**  

---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
| [Daniella] | Zip + RAPPORT.md + REFLEKTION.md |


---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> Började med att skapa klassen 'Spelare' och lade in informationen som förfrågades, sedan när jag väl
  hade 'mallen' av en klass så kopierade jag den bara för att skapa nästa klass 'Match' men fick då
  ändra alla variabler och namn från Namn, Position och Nummer till Hemmalag, Bortalag och Datum.

### Metoderna

> Presentera(); presenterar vad det är för match som spelas idag medan AnnounceraMålskytt();
  säger till att spelarna gjort mål. För att Presentera(); och AnnounceraMålskytt(); skall 
  skriva ut dagens match och vem som gjorde mål användes Console.WriteLine(); i båda metoder.
  Skillnaden är vilken data de tar in - där AnnounceraMålskytt(); tar in spelarens property-
  data (Namn, Position, Nummer) och Presentera(); tar in matchens property-data (Hemmalag,
  Bortalag, Datum).

### Main()

> Klassen spelare gör att jag kan skapa ett 'Spelare-objekt' (new Spelare();), detsamma hände när jag
  skapade en klass åt Match (new Match();). I dessa får spelare namn, position och nummer och matchen
  får sitt hemmalag, bortalag och ett datum. För att sedan skriva ut denna informationen i terminalen
  anropar jag dessa objekt med hjälp av Presentera(); och AnnounceraMålskytt();

### Git

> Först forkade jag repot så det blev "mitt" på GitHub, sedan körde jag git clone i Git Bash med url:en
  man fick under 'Code' knappen på GitHub för att repot skulle finnas lokalt på min dator.
  Sedan vill jag ha en .gitignore fil så jag skrev touch .gitignore och så skapades det en sådan fil
  där jag sedan lade in .vs/ bin/ och obj/, men såg därefter att dedt redan fanns en sådan fil i clo26-
  drommatchen-mappen,så jag valde att ta bort den jag precis skapade. Sedan när jag gjorde änndringar i
  kod så kunde jag köra git add ., git commit -m "...", och sedan git push för att få upp ändringarna
  i GitHub.

### Kodkvalitet

> Namnen på variabler, objekt och metoder valdes för att det skall vara tydligt vad det innebär. 'Namn'
  betyder alltså ett namn, vilket i sin tur är mycket tydligare än omjag hade döpt objektet till
  'X' där x betyder namn - inte minst är det förvirrande för personer från utsidann, men kan också i 
  längd förvirra mig. Presentera() gör som namnet tyder på och presenterar matchen, detsamma med 
  AnnounceraMålskytt() som announcerar vem som gjorde mål. Kommentarer skrives där det inte alltid
  är självklart vad koden gör eller innebär som i Spelare.cs där jag berättar vilken rad som innehåller
  startvärden.

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> Jag lade till en variabel i Spelare.cs som säger hur många mål spelaren gjorde under matchen, och 
  uppdaterade konstruktorn för att spegla denna ändringen (_mål = mål) och lade även till ändringen
  högre upp i klassen. Sedan lade jag också till en metod i Match.cs som returnerar en bool (Sant/
  Falskt värde) som skulle returnera att spelaren är matchhjälte ifall de gör minst (>=) 1 mål.
  Sedan för att få det utskriver så lade jag till en Console.WriteLine(); i mitt program som tar emot
  det returnerade värdet. Jag bytte också ut en av match.AnnounceraMålskytte(); så att båda säger
  match.AnnounceraMath(spelare2); eftersom jag vill att spelare2 gör två mål.

### Varför vi löste det såhär

> Om jag i Console.WriteLine() bara hade skrivit att det returnerade värdet skulle dykas upp 
  Console.WriteLine(spelare.Mål >= 1); hade jag bara fått ett sant / falskt värde och det skulle inte
  indikera på vilken av spelarna det skulle vara sant/ falskt för. Därför behöver jag en interpolation
  så jag kunde vara extra tydlig om vem som faktiskt är matchhjälte. Varför jag använder mig av public
  bool istället för public void som jag gjort i exempelvis Presentera() är för att jag vill att
  ÄrMatchhjälte ska returnera ett värde som jag sedan kan använda i Console.WriteLine() för att få det
  utskrivet i terminalen.

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
[klistra in här]
```
