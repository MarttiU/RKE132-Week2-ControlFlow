// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajal valida tema sugu (m/f)
// Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr.(kasutaja perekonnanimi) / "Welcome, Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your name:");

string userLastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastname}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastname}!");
}
