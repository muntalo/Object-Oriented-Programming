using System;

namespace SemesterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library("A Library");

            Game myFirstGame = new Game("Monopoly", "Lizzy Magie", "8 years old+");
            Game mySecondGame = new Game("Call of Duty", "Activision", "PEGI 18");

            Book myFirstBook = new Book("Dune", "Frank Herbert", "9780441172719");
            Book mySecondBook = new Book("Catch-22", "Joseph Heller", "9780684833392");



            myLibrary.AddResource(myFirstGame);
            myLibrary.AddResource(mySecondGame);
            myLibrary.AddResource(myFirstBook);
            myLibrary.AddResource(mySecondBook);

            mySecondGame.OnLoan = true;
            myFirstBook.OnLoan = true;

            Console.WriteLine(myLibrary.HasResource("Catch-22"));

            Console.WriteLine(myLibrary.HasResource("Call of Duty"));
        }
    }
}
