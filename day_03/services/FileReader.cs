namespace honestcomrade.advent.day03.services;
public class FileReader(string filePath)
{
  private readonly List<string> _lines = [];
  private readonly string _filePath = filePath;

  public IEnumerable<string> ReadLines()
  {
    try
    {
      using var sr = new StreamReader(_filePath);
      while (!sr.EndOfStream)
      {
        var line = sr.ReadLine();
        if (line is not null)
        {
          _lines.Add(line);
        }
      }
    }
    catch (Exception e)
    {
      Console.WriteLine(string.Format("{0}: {1}", _filePath, e.Message));
    }
    return _lines;
  }
}
