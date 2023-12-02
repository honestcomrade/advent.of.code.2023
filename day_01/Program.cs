using honestcomrade.advent.services;

namespace honestcomrade.advent;
public class Main
{
  public static void Run()
  {
    var totalScore = 0;
    var lines = new FileReader("./inputs/input.txt").ReadLines();
    foreach (var line in lines)
    {
      var digits = new LineReader(line).GetDigits();
      _ = int.TryParse($"{digits.Item1}{digits.Item2}", out var combined);
      totalScore += combined;
    }
    Console.WriteLine($"Final Score {totalScore}");
  }
}