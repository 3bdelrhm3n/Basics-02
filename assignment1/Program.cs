using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question 2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book
            //with itself), GetHashCode(), and GetType() on book.

            object book = new Book  { pages =10 ,Title ="First Book"};
            Console.WriteLine( book );
            Console.WriteLine( "to string (): " +book.ToString ());
            Console.WriteLine( "Equals ():"+book.Equals (book ));
            Console.WriteLine( "gethascode ():"+book. GetHashCode() );
            Console.WriteLine( "gettype"+book .GetType());
            #endregion
        }
    }
}
#region question 1
   //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it. 
public class Book
        {
            public string Title;
           public  int pages;
            
            
        }
#endregion

#region question 3
//Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
//int pages = "464";

   // because we are trying to assign a string value to an int variable, it will give compile time error.
#endregion