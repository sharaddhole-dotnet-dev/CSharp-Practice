# Palindrome String

A simple C# console application that checks whether a given string is a Palindrome or not.

## What is a Palindrome?

A string that reads the same forward and backward.

```
Example: madam → madam (Palindrome ✅)
Example: hello → olleh (Not Palindrome ❌)
```

## How it Works

- Takes a string input
- Reverses it using a for loop
- Compares original and reversed string
- Prints whether it is a Palindrome or not

## Example

```
Input:  madam
Output: Palindrome
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
    static void Main()
    {
        string str = "madam";
        string rev = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }
        if (str == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
```

## Tech Stack

- Language: C#
- Framework: .NET 9
