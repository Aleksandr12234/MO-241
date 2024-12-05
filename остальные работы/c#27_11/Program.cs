using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //необходимо определеть символ который чаще всего встречается в комбинации A*B, *-один символ л.а

        Console.WriteLine("Введите строку:");
        string stroka = ""+Console.ReadLine();

        string Nsim="";//Символы входящие в комбинацию
        for(int k=0; k<3; k++){
            for(int i=1+k; i+1<stroka.Length; i+=3){
                string s= stroka.Substring(i-1, 3);
                if(s[0]=='A' && s[2]=='B'){
                    Nsim+=s[1];
                }
            }
            Nsim+=" ";
        }

        int max=0;
        char sim=' ';//вывводимый символ
        foreach(char i in Nsim){
            if(i==' ')continue;
            string[] s = Nsim.Split(i);
            if(s.Length>max){
                max=s.Length;
                sim=i;
            }
        }

        Console.WriteLine("Ответ: " + (sim==' ' ? "Символов нет" : sim));
    }
}