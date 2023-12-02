using honestcomrade.advent.services;

namespace honestcomrade.advent;
public class Run
{
  public static void Main()
  {
    var lines = new FileReader("./inputs/testinput.txt").ReadLines();
    foreach (var line in lines)
    {
      Console.WriteLine(line);
    }
  }
}