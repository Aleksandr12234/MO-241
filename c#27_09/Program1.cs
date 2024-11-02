using System;

class Program1{
    static void Main(){
        //количество локальных минимумов
        Console.WriteLine("Введите количество элемнтов:");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите элемент:");
        int a1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите элемент:");
        int a2=Convert.ToInt32(Console.ReadLine());
        int k=0;

        for(int i=2; i<n; i++){
            Console.WriteLine("Введите элемент:");
            int a3=Convert.ToInt32(Console.ReadLine());
            if(a1>a2 && a2<a3){
                k++;
            }
            a1=a2;
            a2=a3;
        }

        Console.WriteLine("ответ: "+k);
        }
    }
