using honestcomrade.advent.day03.services;

namespace honestcomrade.advent.day03;
public class Run
{
  public static void Main()
  {
    int total = 0;
    var lines = new FileReader("./inputs/testinput.txt").ReadLines();
    foreach (var line in lines)
    {
      Console.WriteLine(line);
    }
  }
}