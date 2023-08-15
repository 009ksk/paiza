using System;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        string resultString = string.Empty;
        var input = Console.ReadLine();
        
        string inputString = input.ToString() ?? string.Empty;
        
        if(string.IsNullOrWhiteSpace(inputString)) return;
        
        int headerFooterCount = inputString.Length + 2;
        
        string headerFooter = GetHeaderFooter(headerFooterCount);
        
        resultString += InsertString(headerFooter);
        resultString += InsertString("+" + inputString + "+");
        resultString += InsertString(headerFooter);
        
        Console.WriteLine(resultString);
    }
    
    private static string GetHeaderFooter(int count)
    {
        string resultString = string.Empty;
        for (int i = 0; i < count; i++)
        {
            resultString += "+";
        }
        return resultString;
    }
    
    private static string InsertString(string targetString)
    {
        return targetString + "\r\n";
    }
    
}

