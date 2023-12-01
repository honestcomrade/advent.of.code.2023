using honestcomrade.advent.services;

namespace honestcomrade.advent;
public class Zero1
{
  public static void Main()
  {
    var totalScore = 0;
    var lines = new FileReader().ReadLines("./testinput.txt");
    foreach (var line in lines)
    {
      var digits = new LineReader(line).GetDigits();
      _ = int.TryParse($"{digits.Item1}{digits.Item2}", out var combined);
      Console.WriteLine(combined);
      totalScore += combined;
      Console.WriteLine(totalScore);
    }
    Console.WriteLine(totalScore);
  }
}