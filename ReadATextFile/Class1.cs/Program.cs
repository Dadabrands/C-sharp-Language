using System.IO;

public static void Main(string[] args)
{
    String? line;
    try
    {
        // Pass the file path and file name to the StreamReader constructor
        StreamReader sr = new StreamReader("C:\Users\SAM DAD\Desktop\C# Course\ReadATextFile\Sample.txt")
        // Read the first line of text
        line = sr.ReadLine();
        //  Continue to read until yiu reach end of the file
        while (line != null)
        {
            // write the line to console window
            Console.WriteLine(line);
            // Read the next Line
            line = sr.ReadLine();
        }
        // close the file
        sr.Close();
        Console.ReadLine();

    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
        Console.WriteLine("Executing finally block.");

    }
}
