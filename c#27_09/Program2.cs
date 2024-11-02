using System;

class Program2{
    static void Main(){
        //количество элементов оканчивающихся на 2
        Console.WriteLine("Введите количество элемнтов:");
        int n=Convert.ToInt32(Console.ReadLine());

        int k=0;

        for(int i=0; i<n; i++){
            Console.WriteLine("Введите элемент:");
            int a=Convert.ToInt32(Console.ReadLine());

            if(Math.Abs(a)%10==2){
                k++;
            }
        }

        Console.WriteLine("ответ: "+k);
    }
}
