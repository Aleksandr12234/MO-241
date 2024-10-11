using System;

class Program3{
    static void Main(){
        Console.WriteLine("Введите количество элементов:");
        int n=Convert.ToInt32(Console.ReadLine());

        int sum=0;
        int maxSum=0;
        bool b=false;
        bool b1=false;

        for(int i=0; i<n; i++){
            Console.WriteLine("Введите элемент:");
            int a=Convert.ToInt32(Console.ReadLine());

            if(Math.Abs(a)%2 == 0){
                sum+=a;
                b1=true;
            }else{
                if(!b && b1){
                    maxSum=sum;
                    b=true;
                    b1=false;
                }else if(b1){
                    maxSum=Math.Max(maxSum, sum);
                    b1=false;
                }
                sum=0;
            }
        }

        if(!b && b1){
                    maxSum=sum;
                    b=true;
                }else if(b1){
                    maxSum=Math.Max(maxSum, sum);
                }

        Console.WriteLine("Ответ: "+(b ? maxSum : "Четных элементов нет"));
    }
}