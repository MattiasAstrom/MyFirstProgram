//Author; Mattias Åström NET24.

int anInt = 5;

//Compares the value on an int.
if (anInt > 10)
{
    Console.WriteLine("Talet är stort!");
}
else
{
    Console.WriteLine("Oj. Lågt tal!");
}

//Ask user for their name and greets them (no error handling).
Console.WriteLine("Vad heter du?");

string userInput = "";

userInput = Console.ReadLine();

Console.WriteLine($"Hej {userInput}");


//prints out all the numbers between 0 and the variable anInt.
int startNumber = 0;

for (int i = 0; i <= anInt; i++)
{
    Console.WriteLine(startNumber);
    startNumber++;
}