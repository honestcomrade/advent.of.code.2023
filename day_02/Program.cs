using honestcomrade.advent.day02.services;

namespace honestcomrade.advent.day02;
public class Run
{
  public static void Main()
  {
    int numBlue = 14, numRed = 12, numGreen = 13;
    var lines = new FileReader("./inputs/testinput.txt").ReadLines();
    Console.WriteLine($"Red: {numRed}");
    Console.WriteLine($"Green: {numGreen}");
    Console.WriteLine($"Blue: {numBlue}");
    foreach (var line in lines)
    {
      Console.WriteLine(line);
      var lineService = new LineService(line);
      var number = lineService.ReadLine();
      Console.WriteLine(number.ToString());
    }
  }
}