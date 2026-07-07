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

        // int a = 240284388;
        // float b = a;
        // Console.WriteLine("After Conversation  "+b);
        // sbyte c = 78;
        // short d = c;
        // Console.WriteLine("After Conversation  "+d);
        // char x = 'P';
        // double y = x;
        // Console.WriteLine("After Conversation  "+y);

        // data type conversion explicit 
        // Explicit Casting (manually) - converting a larger type to a smaller size type
        // double -> float -> long -> int -> short -> byte or int -> char

        // float a = 240284388;
        // int b = (int)a;
        // Console.WriteLine("After Conversation  "+b);
        // double c = 78434727.954994;
        // short d = (short)c;
        // Console.WriteLine("After Conversation  "+d);
        // char x = 'P';
        // int y = (char)x;
        // Console.WriteLine("After Conversation  "+y);

        // float a = 46764.75F;
        // int b = Convert.ToInt32(a);
        // Console.WriteLine("After Conversation  "+b);
        // string x = "aaj5656";
        // int y = Convert.ToInt32(x); // Convert class throws the exception in case of failure
        // Console.WriteLine("After Conversation  "+y);

        Console.WriteLine("Enter first number in double format");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number in double format");
        double b = Double.Parse(Console.ReadLine());
        long c = Convert.ToInt64(a+b);
        Console.WriteLine("After Conversation and sum "+c);

        // TryParse() tries to convert a string into another data type only if the string represents a valid 
        // value of that data type.
        // TryParse() is available for many built-in types, but the input is always a string.
        // Examples:
        // int.TryParse(string, out int)
        // double.TryParse(string, out double)
        // float.TryParse(string, out float)
        // decimal.TryParse(string, out decimal)
        // long.TryParse(string, out long)
        // short.TryParse(string, out short)
        // byte.TryParse(string, out byte)
        // bool.TryParse(string, out bool)
        // char.TryParse(string, out char)
        // DateTime.TryParse(string, out DateTime)

        bool success = char.TryParse("AB", out char letter);
        Console.WriteLine(success);
        Console.WriteLine(letter);

        // bool success = int.TryParse("26" , out int age);
        // Console.WriteLine(success);
        // Console.WriteLine(age);

        // bool success = decimal.TryParse("99.99", out decimal amount);
        // Console.WriteLine(success);
        // Console.WriteLine(amount);

        Console.ReadLine();
    }
}
