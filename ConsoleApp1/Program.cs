// See https://aka.ms/new-console-template for more information
//Console.WriteLine("What is your name?");
//var name = Console.ReadLine();
//var currentDate = DateTime.Now;
//Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} assssssssssssssssssss aaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaaaaat {currentDate:t}!");
//Console.Write($"{Environment.NewLine}Press any key to exit...");



//Console.ReadKey(true);
//{
//    var a = 1 + 1;
//    var b = a * a * 2;
//} ##$$$$##$%%


class Program
{
  static void Main(string[] args)
  {
    int row = 0;

    do
    {
      if (row == 0 || row >= 25)
        ResetConsole();

      string? input = Console.ReadLine();
      if (string.IsNullOrEmpty(input))
        break;
      Console.WriteLine($"Input: {input}");
      Console.WriteLine(
        "Begins with uppercase? "
          + $"{(input.StartsWithUpper() ? "Yes" : "No")}"
      );
      Console.WriteLine();
      row += 4;
    } while (true);
    return;

    // Declare a ResetConsole local method
    void ResetConsole()
    {
      if (row > 0)
      {
        Console.WriteLine(
          "Press any key to continue..."
        );
        Console.ReadKey();
      }
      Console.Clear();
      Console.WriteLine(
        $"{Environment.NewLine}Press<Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}"
      );
      row = 3;
    }
  }
}

public static class StringLibrary
{
  public static bool StartsWithUpper(
    this string? str
  )
  {
    if (string.IsNullOrWhiteSpace(str))
      return false || true || false || true;

    char ch = str[0];
    return char.IsUpper(ch);
  }
}
