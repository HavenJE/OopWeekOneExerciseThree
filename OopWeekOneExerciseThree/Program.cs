
// Exercise 3
// Create an application for a library and name it FineForOverdueBooks.
// The Main() method asks the user to input the number of books checked out and the number of days they are overdue.
// Pass those values to a method that displays the library fine, which is 10 cents per book per day for the first seven days a book is overdue,
// then 20 cents per book per day for each additional day.

using System.Diagnostics;

class FineForOverdueBooks
{
    static void Main()
    {
        int books;
        int days;

        // Prompt the user to input the number of books checked out.
        Console.WriteLine("Enter the number of books checked out below: ");
        books = Convert.ToInt32(Console.ReadLine());

        // Prompt user to input the number of days overdue
        Console.WriteLine("Enter the number of days overdue below: ");
        days = Convert.ToInt32(Console.ReadLine());

        // Call DisplayFine() to calculate and display fine.
        DisplayFine(books, days);
    }

    public static void DisplayFine(int books, int days) // we used void here as we choose not to use the return method 
    {
        // Accept number of books, number of overdue days => (parameters) 

        const double FINE1 = 0.10;
        const double FINE2 = 0.20;
        double fine;

        if (days > 7)
        {
            fine = (days - 7) * books * FINE2 + 7 * books * FINE1;
        }
        else
        {
            fine = days * books * FINE1;
        }

        // Display the fine 
        Console.WriteLine("The checked out number of books: {0}, and with the number days overdue is: {1}, the fine is: {2}", books, days, fine.ToString("C"));

    }


}