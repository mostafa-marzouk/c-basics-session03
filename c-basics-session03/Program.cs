using System.Text;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            /*
               C# Assignment
                    Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
                    both title and upperTitle to show that title did not change.
             */
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"Title : {title} \nupper Title : {upperTitle}");
            #endregion
            #region Q2
            /*
             Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
                to check if they point to the same object in memory.
             */
            //string title1 = "Clean Code";
            //string title2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(title1,title2));

            #endregion
            #region Q3
            /*
             Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
                object. Print the final result.
             */
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);
            #endregion
        }
    }
}
