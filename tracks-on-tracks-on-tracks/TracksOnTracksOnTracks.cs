using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

public static class Languages
{
    private static List<string> _listOfLanguages = new List<string>
    {
        "C#",
        "Clojure",
        "Elm"
    };
    private static string excitingLanguage = "C#";
    
    public static List<string> NewList()
    {
        var listOfStrings = new List<string>();
        return listOfStrings;
    }

    public static List<string> GetExistingLanguages()
    {
        return _listOfLanguages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        return languages.Append(language).ToList();
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count();
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        var containsLanguage = false;
        foreach (string element in languages)
        {
            if (element == language)
            {
                containsLanguage = true;
            } 
        }
        return containsLanguage;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        return languages.Reverse<string>().ToList();
    }

    public static bool IsExciting(List<string> languages)
    {  
        if (languages.Count == 0)
            return false;
        if (languages.First() == excitingLanguage)
            return true;
        if (languages[1] == excitingLanguage && (languages.Count is >= 2 and <= 3) )  
            return true;
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        var list1 = new List<string>(languages);
        list1.Remove(language);
        return list1;
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Distinct().Count() == languages.Count();
    }
}
