namespace honestcomrade.advent.day02.services;
public class FileReader
{
  private readonly List<string> _lines = new();
  private readonly string _filePath;

  public FileReader(string filePath)
  {
    _filePath = filePath;
  }
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
