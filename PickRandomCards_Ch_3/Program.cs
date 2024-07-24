// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Enter the number of cards to pick:");

string line = Console.ReadLine();

if (int.TryParse(line, out int numberOfCards))
{
    // This block is exectued if line COULD be converted to an int
    // value that's stored in a new variable called numberOfCards
}
else 
{ 
    // this block is executed if line COULD NOT be converted to an int
}

