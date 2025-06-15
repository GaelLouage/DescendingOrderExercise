internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DescendingOrderLinq(42145));
        Console.WriteLine(DescendingOrderLinq(145263));
        Console.WriteLine(DescendingOrderLinq(123456789));
    }
    public static int DescendingOrderLinq(int num)
    {
        var c = num.ToString().OrderByDescending(x => char.GetNumericValue(x));
        Console.WriteLine(string.Join("",c));
        return 1;
    }
    public static int DescendingOrder(int num)
    {
        var numToString = num.ToString();
        var array = new int[numToString.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (int)char.GetNumericValue(numToString[i]);
        }
        for (int i = 0; i < array.Length; i++) 
        {
            for(int j = 0; j < array.Length; j++) 
            {
                if (array[i] > array[j])
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        var result = string.Concat(array);
        return int.Parse(result);
    }
}