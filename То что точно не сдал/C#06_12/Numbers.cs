class Numbers{
    private int x,y;
    public Numbers(){
        x=0;
        y=0;
    }
    public Numbers(int x){
        this.x=x;
        y=0;
    }
    public Numbers(int x, int y){
        this.x=x;
        this.y=y;
    }

    public void Sum(){
        Console.WriteLine("Сумма: "+(x+y));
    }
    public void Umnogenie(){
        Console.WriteLine("Произведение: "+(x*y));
    }
    public void Div(){
        if(y!=0)Console.WriteLine("Частное: "+(x/y));
        else Console.WriteLine("Деление невозможно");
    }
    public void Vichitanie(){
        Console.WriteLine("Разность: "+(x-y));
        Console.WriteLine("Разность: "+(y-x));
    }
}