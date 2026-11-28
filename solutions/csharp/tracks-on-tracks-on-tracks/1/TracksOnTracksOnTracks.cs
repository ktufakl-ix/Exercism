public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string> { "C#", "Clojure", "Elm" };
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        return languages.Append(language).ToList();
        //return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        List<string> swap = new List<string>();
        for(int i = languages.Count-1;i>=0;i--)
        {
            swap.Add(languages[i]);
        }
        return swap;
    }

    public static bool IsExciting(List<string> languages)
    {
/*        if (languages[0] == "c#" || (languages[1] == "c#" && (languages.count == 2 || languages.count == 3)))
            return true;
        return false;
*/
        if(languages.Count!=0)
        {
            if (languages[0] == "C#")
                return true;
            else if(languages.Count == 2 || languages.Count == 3)
            {
                if (languages[1] == "C#")
                    return true;
            }
        }
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        if (languages.TryGetNonEnumeratedCount(out var _))
        {
            languages.Remove(language);
        }
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        return languages.Count == languages.Distinct().Count(); 
    }
}
