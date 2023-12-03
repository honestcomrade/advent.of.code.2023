using honestcomrade.advent.day02.services;

namespace honestcomrade.advent.day02;
public class Run
{
  public static void Main()
  {
    // part 1, not needed for part 2
    // int numBlue = 14,
    //   numRed = 12,
    //   numGreen = 13;
    int total = 0;
    var lines = new FileReader("./inputs/input.txt").ReadLines();
    // part 1, not needed for part 2
    // Console.WriteLine($"Red: {numRed}");
    // Console.WriteLine($"Green: {numGreen}");
    // Console.WriteLine($"Blue: {numBlue}");
    foreach (var line in lines)
    {
      var lineService = new LineService(line);
      var game = lineService.ReadLine();
      // part1, not needed for part 2
      // if (game.Green.Any(f => f > numGreen) || game.Red.Any(f => f > numRed) || game.Blue.Any(f => f > numBlue))
      // {
      //   continue;
      // }
      var highestRed = game.Red.Max();
      var highestGreen = game.Green.Max();
      var highestBlue = game.Blue.Max();
      var linePower = highestRed * highestGreen * highestBlue;
      Console.WriteLine($"{game.GameNumber}: Highest values: Red:{highestRed}, Blue: {highestBlue}, Green: {highestGreen}, LinePower: {linePower}");
      total += linePower;
      Console.WriteLine($"New Total: {total}");
    }
  }
}