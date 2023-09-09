// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;


//rakendus küsib kasutajal sisestada tema vanus'
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse: "you are to young to use Instagram"
//muul juhul konsoolis kuvatakse "Welcome to Insagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);   

//boolean - tal on kaks väärtust true/false

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");  

//int userAge = Int32.Parse (Console.ReadLine()); // "13" - salvestatakse heap ehk sõne, kui on lihtsalt 13 number -salvestakse stack, mis võtab vähem ruumi vahemälus
//int tüüpi muutuja salvestatakse parse. 


if (isAgeNumber)
{
    if(userAgeNum >=13)
    {
         Console.WriteLine("Welcome to Instageam");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
}
else
{
    Console.WriteLine("Could not read you age");

}