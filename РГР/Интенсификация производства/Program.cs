
internal class Program
{
    private static void Main(string[] args)
    {
        //Интенсификация производства (ввод - вывод через консоль)
        Console.WriteLine("Ввод:");

        Console.Write("Дата начала периода: ");
        string start=""+Console.ReadLine();
        int ddS=Convert.ToInt32(start.Substring(0,2));
        int mmS=Convert.ToInt32(start.Substring(3,2));
        int earS=Convert.ToInt32(start.Substring(6,4));
        DateTime date1=new DateTime(earS, mmS, ddS);

        Console.Write("Дата окончания периода: ");
        string end=""+Console.ReadLine();
        int ddE=Convert.ToInt32(end.Substring(0,2));
        int mmE=Convert.ToInt32(end.Substring(3,2));
        int earE=Convert.ToInt32(end.Substring(6,4));
        DateTime date2=new DateTime(earE, mmE, ddE);

        Console.Write("Начальный выпуск продукции: ");
        int nach=Convert.ToInt32(Console.ReadLine());

        TimeSpan daysTS=date2-date1;
        long days=daysTS.Days;
        long result=(days+1)*nach+(1+days)*days/2;
        Console.WriteLine("ответ: "+result);
    }
}