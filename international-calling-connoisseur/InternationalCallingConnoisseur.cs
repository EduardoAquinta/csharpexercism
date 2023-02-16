using System;
using System.Collections.Generic;
using System.Linq;

public static class DialingCodes


{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        var dialingCodes = new Dictionary<int, string>();
        return dialingCodes;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var diallingCodes = new Dictionary<int, string>()
        {
            { 1, "United States of America" },
            { 55, "Brazil" },
            { 91, "India" }
        };
        return diallingCodes;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        return new() { [countryCode] = countryName };
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
         existingDictionary[countryCode] = countryName;
         return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        var country = existingDictionary.GetValueOrDefault(countryCode) ?? string.Empty;
        return country;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        var doesItHave = existingDictionary.ContainsKey(countryCode);
        return doesItHave;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
            existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        return existingDictionary.Values.OrderByDescending(countryName => countryName.Length).FirstOrDefault(string.Empty);
    }
}