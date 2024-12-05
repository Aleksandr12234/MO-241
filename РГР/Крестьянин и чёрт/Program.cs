internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ввод: ");
        int InN=Convert.ToInt32(Console.ReadLine());
        int count=0;

        for(int n=1; n<=InN; n++){
            for(int k=n+1; k<=n*2; k++){
                for(int z=1; n*step(2,z)-k*(step(2,z)-1)>=0; z++){
                    if(n*step(2,z)-k*(step(2,z)-1)==0){
                        count++;
                        break;
                    }
                }
            }
        }

        Console.WriteLine("Ответ: "+count);
    }
    static int step(int a, int b){
        int result=1;
        for(int i=0; i<b; i++){
            result*=a;
        }
        return result;
    }
}