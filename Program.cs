namespace C_AdvSession40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("123", "C# Basics", new string[] { "Ali", "Sara" }, new DateTime(2023, 5, 1), 99.99m),
                new Book("456", "OOP in Depth", new string[] { "John" }, new DateTime(2022, 10, 15), 75.50m)
            };
            Console.WriteLine("--------------------Titles---------------------------");
            // Using the Func Delegate to point at this method which has the same signature of the delegate
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle); // Returns String
            // Anonymous method way
            Console.WriteLine("----------------------Authors-----------------------------");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            Console.WriteLine("-----------------------ISBN-------------------------");
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });
            Console.WriteLine("----------------------------DateTime-----------------");
            //Lampda Expression
            LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortDateString());
            Console.WriteLine("------------------Prices------------------------");
            LibraryEngine.ProcessBooks(books, b => b.Price);

        }
    }
}
