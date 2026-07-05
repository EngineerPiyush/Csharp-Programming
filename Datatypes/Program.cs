// to find minimum or maximum value of a data type we can use MinValue or Maxvalue property.
class Program{
    public static void Main(String []args){
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);
        Console.WriteLine();

        float a = 292929.00999f;
        double b = 958580999.0009d;
        decimal c = 0334999.758745m;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        string name = "Hello\"Piyush\"";
        Console.WriteLine(name);
        string path = "folder\\subFolder\\anotherFolder";
        Console.WriteLine(path);
        string filePath = @"C:\projects\C# programming\Portfolio"; // verbatim literal
        Console.WriteLine(filePath);
        Console.ReadLine();
    }
}
