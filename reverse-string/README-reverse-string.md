# Reverse String

A simple C# console application that reverses a given string.

## How it Works

- Takes a string input
- Converts it to a character array
- Reverses the array
- Prints the reversed string

## Example

```
Input:  madam
Output: madam
```

## How to Run

Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.

```bash
dotnet run
```

## Code

```csharp
using System;
public class Program
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
```

## Tech Stack

- Language: C#
- Framework: .NET 9
