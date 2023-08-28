

static void Main(string[] args)
{
    //    int integer;
    //    integer = 12;

    //        int int1 = 1;
    //        int int2 = 0;
    //        int int3 = int1 * int2;

    //   Console.WriteLine(int3);


    //    C# Keywords
    // Keywords are reserved words 

    // you can sidestep the keyword restriction by putting an @ sign before the keyword i.e @void 
    // int @void = 23;
    // Console.WriteLine(@void);
    // Best pracice is to try as possiblee not to use the reserved words. find a meaningful name for your variables and use the reserved word as las resort



    // Console.WriteLine("What is your Name");
    //    string? name = Console.ReadLine();
    //    string message = $"Hello {name}";
    //    Console.WriteLine(message);

    // string firstString;
    // firstString = "some string";
    // Console.WriteLine($"{nameof(firstString)} : {firstString}");
    int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    foreach (var arrayItem in array)
    {
        Console.WriteLine($"{arrayItem} squared equals {Square(arrayItem)}");

    }

}
static int Square(int value)
{
    return value * value;
}


