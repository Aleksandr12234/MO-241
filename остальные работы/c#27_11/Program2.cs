
internal class Program2
{
    private static void Main(string[] args)
    {
        //необходимо опр наибольшую длину последовательности, состоящую из последовательно идущих символов abc, abc...
        Console.WriteLine("Введите строку:");
        string stroka=""+Console.ReadLine();

        string abc="/";
        int maxN=0;
        foreach(char i in stroka){
            if(i=='a'){
                if(abc[abc.Length-1] != 'c') abc="/";
                abc+=i;
            }else if(i=='b' && abc[abc.Length-1] == 'a')abc+=i;
            else if(i=='c' && abc[abc.Length-1] == 'b')abc+=i;
            else abc="/";
            Console.Write(abc);
            maxN=Math.Max(maxN, abc.Length-1);
        }

        Console.WriteLine("Ответ: "+maxN);
    }
}