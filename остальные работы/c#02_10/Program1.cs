using System;

class Program1{
    static void Main(){
        Console.WriteLine("Введите количество элементов:");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите элеммент:");
        int predA=Convert.ToInt32(Console.ReadLine());
        int k=0;
        int kMax=0;
        for(int i=1; i<n; i++){
            Console.WriteLine("Введите элеммент:");
            int a=Convert.ToInt32(Console.ReadLine());

            if(a==predA){
                k++;
                kMax=Math.Max(kMax, k);
            }else k=0;

            predA=a;
        }

        Console.WriteLine("Ответ: "+(kMax+1));
    }
}