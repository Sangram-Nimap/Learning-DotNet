internal class Program
{
    private static void Main(string[] args)
    {
        int[] age = { 3, 45, 20, 34, 67, 87, 90,88 };
         //var a = from i in age where i > 20  select i; 
        string[] names = { "sangram", "ketan", "mihir", "harshal", "Rushikeash" };
        //  var a = from name in names where name.Contains("l") select name;
        var a = from name in names where name.Contains("sangram") select name;
        foreach(var  Output in a)
        {
            Console.WriteLine(Output);
        }
    }
}