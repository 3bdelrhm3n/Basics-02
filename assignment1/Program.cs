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
public class Book
        {
            public string Title;
           public  int pages;
            
            
        }
#endregion