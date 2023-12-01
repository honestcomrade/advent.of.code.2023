namespace honestcomrade.advent.services;
public class FileReader
{
  private readonly List<string> _lines = new();
  public IEnumerable<string> ReadLines(string filePath)
  {
    try
    {
      using var sr = new StreamReader(filePath);
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
      Console.WriteLine(string.Format("{0}: {1}", filePath, e.Message));
    }
    return _lines;
  }
}
