using NameCreator;


GetCalculator();



void GetCalculator()
{
    var calculator = new Exchange();

   var asd= calculator.CalculateTheExchange((decimal)15.90, 0);
   Console.WriteLine(asd);
   var ss = calculator.ProfitCalculation(29, (decimal)15.9, asd);
   Console.WriteLine(ss);
}






void GetValues()
{
    var creator = new NameCreate();
    var NewNames = creator.GetValues();
    for (int i = 0; i < NewNames.Count(); i++)
    {
        Console.WriteLine(NewNames[i]);
    }
}