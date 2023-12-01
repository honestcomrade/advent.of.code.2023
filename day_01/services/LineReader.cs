using System.Text.RegularExpressions;
using honestcomrade.advent.util;
using Microsoft.VisualBasic;

namespace honestcomrade.advent.services;
public class LineReader
{
  private readonly string _line;
  private static readonly Dictionary<string, string> _numbers = new Dictionary<string, string>
  {
    {"one", "1"},
    {"two", "2"},
    {"three", "3"},
    {"four", "4"},
    {"five", "5"},
    {"six", "6"},
    {"seven", "7"},
    {"eight", "8"},
    {"nine", "9"},
  };

  private static readonly string regexes =
    string.Join(Delimiters.Pipe, _numbers.Keys.Select(f => f));

  public LineReader(string line)
  {
    _line = line;
  }

  public Tuple<string, string> GetDigits()
  {
    var digits = ScanDigits();
    return new Tuple<string, string>(digits.First(), digits.Last());
  }

  private static string TransformToDigit(string input)
  {
    _ = _numbers.TryGetValue(input, out var match);
    return match ?? input;
  }

  private IEnumerable<string> ScanDigits()
  {
    var reStr = $"(?=(\\d|{regexes}))";
    Regex re = new(reStr);
    var matches = re.Matches(_line);
    return matches.Select(f => TransformToDigit(f.Groups?.Values?.Last()?.Value));
  }
}