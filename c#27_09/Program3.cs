using System;

class Program3{
    static void Main(){
        //второе максимальное число
        Console.WriteLine("Введите количество элемнтов:");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите элемент:");
        int a1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите элемент:");
        int a2=Convert.ToInt32(Console.ReadLine());
        int max=Math.Max(a1,a2);
        int Pmax=Math.Min(a1,a2);

        for(int i=2; i<n; i++){
            Console.WriteLine("Введите элемент:");
            int a=Convert.ToInt32(Console.ReadLine());

            if(a>=max){
                Pmax=max;
                max=a;
            }

        }

        Console.WriteLine("ответ: "+Pmax);
        }
    }