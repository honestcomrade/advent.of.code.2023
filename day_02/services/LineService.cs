
using honestcomrade.advent.day02.util;

namespace honestcomrade.advent.day02.services;
public class LineService
{
  private readonly string _line;
  private int _gameNumber;
  public LineService(string line)
  {
    _line = line;
  }

  public Dictionary<string, int> ReadLine()
  {
    return ParseLine();
  }

  private Dictionary<string, int> ParseLine()
  {
    var parts = _line?.Split(Delimiters.Colon);
    var gameStr = parts?.FirstOrDefault()?.Split(Delimiters.Space);
    _ = int.TryParse(gameStr?.Last(), out var gameNumber);
    _gameNumber = gameNumber;
    return new Dictionary<string, int>() { { "gameNumber", _gameNumber } };
  }

  public int GameNumber => _gameNumber;

}

// Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
