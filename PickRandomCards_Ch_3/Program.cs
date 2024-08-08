// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using PickRandomCards_Ch_3;

Console.Write("Enter the number of cards to pick:");

string line = Console.ReadLine();


// int.TryParase is a special method used to check if the text that the user entered is a number.
if (int.TryParse(line, out int numberOfCards))
{
    // This block is exectued if line COULD be converted to an int
    // value that's stored in a new variable called numberOfCards
    Console.WriteLine(numberOfCards);

}
else 
{ 
    Console.WriteLine("The number was not converted");

}

// Use a String[] variable to save the results
List<string> cards = new List<string>();


foreach (string card in CardPicker.PickSomeCards(numberOfCards))
{
    Console.WriteLine($"Card {card}");
}

