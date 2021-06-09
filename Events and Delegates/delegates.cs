class Program {
    public delegate double PerformCalculation(double a,double b);
    public static double Addition(double x, double y){
        Console.WriteLine(x+y);
        return x+y;
    }
    static void Main(string[] args){
        PerformCalculation Add=Addition;
        Add(3,5);
    }


}