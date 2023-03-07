using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var badge = "";
        if (id == null && department == null)
        {
            badge = $"{name} - OWNER";
        }
        else if (department == null)
        {
            badge = $"[{id}] - {name} - OWNER";
        }
        else if (id == null)
        {
            badge = $"{name} - {department.ToUpper()}";
        }
        else
        {
            badge = $"[{id}] - {name} - {department.ToUpper()}";
        }
        Console.WriteLine(badge);
        return badge;
    }
}
