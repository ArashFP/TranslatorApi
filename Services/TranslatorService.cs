namespace TranslatorApi.Services
{
  public class TranslatorService
  {
    private const int Shift = 3;

    public string Translate(string text)
    {
      return new string(text.Select(c =>
      {
        if (!char.IsLetter(c)) return c;

        char offset = char.IsUpper(c) ? 'A' : 'a';
        return (char)((c + Shift - offset) % 26 + offset);
      }).ToArray());
    }

    public string Restore(string text)
    {
      return new string(text.Select(c =>
      {
        if (!char.IsLetter(c)) return c;

        char offset = char.IsUpper(c) ? 'A' : 'a';
        return (char)((c - Shift - offset + 26) % 26 + offset);
      }).ToArray());
    }
  }
}