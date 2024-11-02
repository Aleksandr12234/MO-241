using System;

class Program4{
        static void Main(){
            //макс кол-во четных элементов подрят
            Console.WriteLine("Введите количество элемнтов:");
            int n=Convert.ToInt32(Console.ReadLine());

            int k=0;
            int max=0;

            for(int i=0; i<n; i++){
                Console.WriteLine("Введите элемент:");
                int a=Convert.ToInt32(Console.ReadLine());
                
                if(Math.Abs(a)%2==0){
                    k++;
                    max=Math.Max(k, max);
                }else k=0;
  
            }

            Console.WriteLine("ответ: "+max);
        }
    }
