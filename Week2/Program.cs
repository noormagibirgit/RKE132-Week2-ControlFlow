// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, world!");

//uued andmetüübid: int ja char
//if-statements (control flow)

//rakendus küsib kasutajal valida tema sugu mees või naine
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());//loeb konsoolist maha andmeid string ehk sõne formaadis

Console.WriteLine($"Welcome,{userGender}");
