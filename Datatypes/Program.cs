// to find minimum or maximum value of a data type we can use MinValue or Maxvalue property.
class Program{
    public static void Main(String []args){
        // Integral data types
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);
        Console.WriteLine();

        // Folat data types
        // float a = 292929.00999f;
        // double b = 958580999.0009d;
        // decimal c = 0334999.758745m;

        // Console.WriteLine(a);
        // Console.WriteLine(b);
        // Console.WriteLine(c);

        // String data types and escape sequences
        string name = "Hello\"Piyush\"";
        Console.WriteLine(name);
        string path = "C:\\Users\\Default\\Documents";
        Console.WriteLine(path);
        string filePath = @"C:\projects\C# programming\Portfolio"; // verbatim literal
        Console.WriteLine(filePath);
        string speech = "Piyush said, \"Coding is awesome.\"";
        Console.WriteLine(speech);
        string copyright = "Copyright \u00A9 2026";
        Console.WriteLine(copyright);

        // data type conversion implicit 
        // Implicit Casting (automatically) - converting a smaller type to a larger type size
//  sbyte      byte
//    │         │
//    └──► short ◄── ushort
//              │
//              ▼
//             int ◄── char
//              │
//              ▼
//            long ◄── uint
//              │
//              ▼
//           float
//              │
//              ▼
//           double
//              │
//           (explicit)
//              ▼
//           decimal

        int a = 24028488388;
        float b = a;
        Console.WriteLine(b);
        sbyte c = 78;
        byte d = c;
        Console.WriteLine(d);
        char x = 'P';
        double y = x;
        Console.WriteLine(y);
        // data type conversion explicit 
        // Explicit Casting (manually) - converting a larger type to a smaller size type
        // double -> float -> long -> int -> short -> byte or int -> char
        Console.ReadLine();
    }
}
