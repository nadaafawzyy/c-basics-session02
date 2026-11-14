string title = "Dune";
int pages = 464;

object obj = new Book
{
    Title = title,
    Pages = pages
};

Book book = new Book
{
    Title = title,
    Pages = pages
};
Console.WriteLine(obj);

// Methods inherited from object
Console.WriteLine(book.ToString());
Console.WriteLine(book.Equals(book));
Console.WriteLine(book.GetHashCode());
Console.WriteLine(book.GetType());

// try / catch / finally
try
{
    int zero = 0;
    int result = 10 / zero;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}

// int to double: implicit conversion
int p = 300;
double d = p;

// double to int: explicit conversion
double price = 49.99;
int priceInt = (int)price;



// Convert class
string pagesText = "464";
int a = Convert.ToInt32(pagesText);

Console.WriteLine($"Converted pages: {a}");

// Parse and TryParse
int year = int.Parse("2023");
Console.WriteLine("Year:" + year);

bool isValid = int.TryParse("abc", out int result2);
Console.WriteLine(isValid);   // False

// int to string
int n = 464;
string s = n.ToString();

Console.WriteLine(s);
Console.WriteLine(s.GetType());

// Boxing and unboxing
int copies = 100;
object boxed = copies;
int unboxed = (int)boxed;

Console.WriteLine(boxed);
Console.WriteLine(unboxed);


class Book
{
    public string Title  = "Dune";

    public int Pages;
}