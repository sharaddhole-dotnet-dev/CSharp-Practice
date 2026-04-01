using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input = "madam";
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);

        Console.WriteLine(result);
    }
}