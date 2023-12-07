using honestcomrade.advent.day03.util;

namespace honestcomrade.advent.day03.services;
public class LineReader(string line)
{
  private readonly string _line = line;
  public List<string> ReadLine()
  {
    List<string> l = [];
    for (var i = 0; i < _line.Length; i++)
    {

      if (_line[i] == SymbolUtils.Period)
      {

      }
    }
    return l;
  }
}