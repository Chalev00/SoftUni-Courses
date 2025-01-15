string book = Console.ReadLine();

string searchedBook = "";

int bookCount = 0;

while (book != searchedBook)
{
    searchedBook = Console.ReadLine();
    bookCount++;

    if (searchedBook == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {bookCount - 1} books.");
        break;
    }
    if (searchedBook == book)
    {
        Console.WriteLine($"You checked {bookCount - 1} books and found it.");
    }
}