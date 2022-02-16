namespace ColorSpace;


public class Color
{

    public double RedChannel { get; set;}
    public double GreenChannel { get; set;}
    public double BlueChannel { get; set;}
    public static Colors White {get;} = Colors.White;
    public static Colors Black {get;} = Colors.Black;
    public static Colors Orange {get;} = Colors.Orange;
    public static Colors Yellow {get;} = Colors.Yellow;
    public static Colors Purple {get;} = Colors.Purple;
    public static Colors Red {get;} = Colors.Red;
    public static Colors Green {get;} = Colors.Green;
    public static Colors Blue {get;} = Colors.Blue;

    public Color(double red, double green, double blue)
    {
           RedChannel = red; 
           GreenChannel = green;
           BlueChannel = blue;

           var colorNum = Tuple.Create(RedChannel, GreenChannel, BlueChannel);
           var result = colorNum switch
           {
               (255,0,0) => Red,
               (255, 255, 255) => White,
               (0, 0, 0) => Black,
               (255 , 165, 0) => Orange,
               (255, 255, 0) => Yellow,
               (0, 128, 0) => Green,
               (0, 0, 255) => Blue,
               (128, 0, 128) => Purple,
               _ => throw new NotImplementedException()
           };

           Console.WriteLine($"This colour is {result}");
           Console.WriteLine($"Channel Values: Red: {colorNum.Item1}, Green: {colorNum.Item2}, Blue: {colorNum.Item3}");
    }
};