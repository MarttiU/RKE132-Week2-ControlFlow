// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajal sisestada oma vanuse
// Kui kasutaja vanus on väiksem kui 13, konsoolis kuvatakse:
// "Sa oled liiga noor Instagrammi kasutamiseks"
// Muul juhul
// konsoolis kuvatakse "Tere tulemast Instagrammi"

Console.WriteLine("Sisesta oma vanus:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Tere tulemast Instagrammi!");
}
else
{
    Console.WriteLine("Sa oled liiga noor Instagrammi kasutamiseks!");
}