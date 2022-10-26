
List<string> Words = new List<string>() { "Forum", "Kripto", "Finance", "Mentor", "Billionere", "Currency", "Dolar" };
List<string> NewNames = new List<string>();

Console.WriteLine("Give me the words");
Console.WriteLine("Like this format Money Apple Desk");

if(Console.ReadLine()!= string.Empty)
 GetWordsFromLine(Console.ReadLine());
CreateNewNames(Words);
 void GetWordsFromLine(string words)
{
    if (words == string.Empty)
        return;
    Words = words.Split(" ").ToList();
}

void CreateNewNames(List<string> words)
{
    for (int i = 0; i < Words.Count(); i++)
    {
        var firstLetters = "";
        firstLetters = words[i].Substring(0, 2);
        
        for (int j= 0; j < Words.Count()-1; j++)
        {
            var anotherName = firstLetters + words[j].Substring(0, 2)+"ly";
            var newName= firstLetters + words[j].Substring(2) +"ly";
            if(!words.Contains(anotherName) )
            NewNames.Add(anotherName);
            if (!words.Contains(newName))
                NewNames.Add(newName);
        }
    }
    for (int i = 0; i < NewNames.Count(); i++)
    {
        Console.WriteLine(NewNames[i]);
    }
}