
using System.Text.RegularExpressions;
using honestcomrade.advent.day02.util;

namespace honestcomrade.advent.day02.services;
public class LineService
{
  private readonly string _line;
  public LineService(string line)
  {
    _line = line;
  }

  public Game ReadLine()
  {
    return ParseLine();
  }

  private Regex Red = new Regex($"(\\d*) red");
  private Regex Green = new Regex($"(\\d*) green");
  private Regex Blue = new Regex($"(\\d*) blue");

  private Game ParseLine()
  {
    var parts = _line?.Split(Delimiters.Colon);
    var gameStr = parts?.FirstOrDefault()?.Split(Delimiters.Space);
    _ = int.TryParse(gameStr?.Last(), out var gameNumber);

    var scores = parts?.Last();
    var pulls = scores?.Split(Delimiters.SemiColon).Select(f => f.Trim());
    var red = pulls?.Select(f => Red.Match(f)).Where(f => f.Captures.Count > 0).Select(f => f.Groups.Values.Last()?.Value).Select(int.Parse);
    var blue = pulls?.Select(f => Blue.Match(f)).Where(f => f.Captures.Count > 0).Select(f => f.Groups.Values.Last()?.Value).Select(int.Parse);
    var green = pulls?.Select(f => Green.Match(f)).Where(f => f.Captures.Count > 0).Select(f => f.Groups.Values.Last()?.Value).Select(int.Parse);
    return new Game()
    {
      Red = red,
      Blue = blue,
      Green = green,
      GameNumber = gameNumber,
    };
  }
}
