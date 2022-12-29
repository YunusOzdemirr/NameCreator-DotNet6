namespace NameCreator;

public class NameCreate
{
    
    List<string> Words = new List<string>() { "Atrax","Forum", "Kripto", "Finance", "Mentor", "Billionere", "Currency", "Dolar","Forex","Para","Cash","Exchange","Yatırım","Matrix","Fax","Stock","Request","Supply"};
    List<string> NewNames = new List<string>();

    public NameCreate()
    {
        GetWordsFromLine(Console.ReadLine());
        CreateNewNames(Words);
    }

    public List<string> GetValues() => NewNames;

    
    
    void GetWordsFromLine(string words)
    {
        if (words == string.Empty)
            return;
        Words = words.Split(" ").ToList();
    }

    List<string> CreateNewNames(List<string> words)
    {
        for (int i = 0; i < Words.Count(); i++)
        {
            var firstLetters = "";
            firstLetters = words[i].Substring(0, 2);

            for (int j = 0; j < Words.Count() - 1; j++)
            {
                var anotherName = firstLetters + words[j].Substring(0, 2) + "ly";
                var newName = firstLetters + words[j].Substring(2) + "ly";
                if (!words.Contains(anotherName))
                    NewNames.Add(anotherName);
                if (!words.Contains(newName))
                    NewNames.Add(newName);
            }
        }
        NewNames=NewNames.OrderBy(a=>a).ToList();
        return NewNames;

    }
}