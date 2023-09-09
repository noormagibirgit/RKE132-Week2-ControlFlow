// See https://aka.ms/new-console-template for more information



//uued andmetüübid: int ja char
//if-statements (control flow)

//rakendus küsib kasutajal valida tema sugu mees või naine
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());//loeb konsoolist maha andmeid string ehk sõne formaadis. ehk ei pea kasutama pikka nime nt. naine saab lühendit

Console.WriteLine("Please, enter your lastname:");
string userLastname = Console.ReadLine();   

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastname}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastname}!");

}
