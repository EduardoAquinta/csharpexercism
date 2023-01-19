using System;
using System.Text;

public static class Identifier
{
    
    public static string Clean(string identifier)
    {
        var cleaned  = new StringBuilder(identifier.Length);

        foreach (var c in identifier)
        {
            if (char.IsControl(c))
            {
                cleaned.Append("CTRL");
            }
            else
            {
                cleaned.Append(c);
            }
        }
        
        var camelCase = new StringBuilder(cleaned.Length);
        var adjacent = false;
        
        foreach (var c in cleaned.ToString())
        {
            if (c == '-')
            {
                adjacent = true;
            }
            else if (adjacent)
            {
                camelCase.Append(char.ToUpper(c));
                adjacent = false;
            }
            else
            {
                camelCase.Append(c);
            }
        }
        var lettersOnly = new StringBuilder(camelCase.Length);
        foreach (var c in camelCase.ToString())
        {
            if (char.IsLetter(c))
            {
                lettersOnly.Append(c);
            }
            else if (c == ' ')
            {
                lettersOnly.Append('_');
            }
        }

        var noGreekLetters = new StringBuilder(lettersOnly.Length);
        foreach (var c in lettersOnly.ToString())
        {
            if (c < 'α' || c > 'ω')
            {
                noGreekLetters.Append(c);
            }
        }
        return noGreekLetters.ToString();
    }
    
    
}
