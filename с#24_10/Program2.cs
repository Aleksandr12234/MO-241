using System.Globalization;

class Program2{
    static void Main(){

        NumberFormatInfo nfi=new(){
            NumberDecimalSeparator=".",
        };

        string line;
        double min=0;
        int n=0;
        try
        {
            StreamReader sr=new("input9.txt");//имя обрабатываемого фаила (вывод через консоль)
            line=""+sr.ReadLine();
            int k=0;

            while (line!="")
            {
                k++;
                line = ""+sr.ReadLine();
                string[] dannie=line.Split(' ');

                double[] a=new double[dannie.Length];
                for (int i=0; i<dannie.Length; i++)
                {
                    a[i]=Convert.ToDouble(dannie[i], nfi);
                }

                double Sp1=2*(a[0]*a[1] + a[1]*a[2] + a[0]*a[2]);
                double c2=a[7];
                double Sp2=2*(a[3]*a[4] + a[4]*a[5] + a[3]*a[5]);
                double c1=a[6];
                double Vm2=a[3]*a[4]*a[5]-Sp2;
                double Vm1=a[0]*a[1]*a[2]-Sp1;

                double x=(Sp1*c2 - Sp2*c1)/(Sp1*Vm2-Sp2*Vm1)*1000;
                x=Math.Round(x*100)/100.0;

                if(n==0 || min>x){
                    min=x;
                    n=k;
                }

                //Console.WriteLine(  Math.Round(x*100)/100.0  );
            }
    
            sr.Close();
        }catch (Exception) {}

        Console.WriteLine($"{n} {min}");
    }


}