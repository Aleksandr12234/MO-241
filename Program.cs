using System;
class HelloWorld {
  static void Main() {
    //три задачи за пятницу 13.09
    
    //задача 1 (поменять местами значения a и b)
    
    Console.WriteLine("Введите a:");
    int a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b:");
    int b=Convert.ToInt32(Console.ReadLine());
    
    a=a+b;
    b=a-b;
    a-=b;
    
    Console.WriteLine("Результат:");
    Console.WriteLine("a: "+a);
    Console.WriteLine("b: "+b);
    
    
    //задача 2 (вывод максимум из двух знаений)
    /*
    Console.WriteLine("Введите a:");
    int a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b:");
    int b=Convert.ToInt32(Console.ReadLine());
        
    int c=(a+b+Math.Abs(a-b))/2;
    Console.WriteLine("Результат: "+c);
    */
    
    //задача 3 (грядки)
    /*
    Console.WriteLine("Введите ширину грядок(l):");
    int l=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите длинну грядок(m):");
    int m=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите путь от колодца до грядок(p):");
    int p=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество грядок(n):");
    int n=Convert.ToInt32(Console.ReadLine());
    int pG=l*2+m*2;
    
    int otv=p*n*2 + pG*n+ l*n*(n-1);
    
    Console.WriteLine("результат: "+otv);
    */
  }
}