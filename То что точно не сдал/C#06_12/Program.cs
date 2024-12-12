internal class Program
{
    
    private static void Main(string[] args)
    {
        Numbers numbers=new Numbers();

        Console.Write("Ввод: ");
        bool u1=int.TryParse(Console.ReadLine(), out int a);
        bool u2=int.TryParse(Console.ReadLine(), out int b);
        if(u1 && u2)numbers=new Numbers(a,b);
        else if(u1) numbers=new Numbers(a);
        else if(u2) numbers=new Numbers(b);

        numbers.Sum();
        numbers.Umnogenie();
        numbers.Div();
        numbers.Vichitanie();
    }
}