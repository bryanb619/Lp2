using System.Dynamic;

class Program
{
    // criar delegate

    public delegate void MyDelegate(string msg);

    private Joiner _joiner;

    static void Main(string[] args)
    {   
        
    }

    // criar metodo que vão ser chamados pelo delegate



}


class Joiner
{
    private readonly string _firstString;

    public Joiner(string str)
    {
        _firstString = str;
    }


    public void JoinAndPrint(string secondString)
    {
        Console.WriteLine(_firstString +  secondString);
   
    }
    

}