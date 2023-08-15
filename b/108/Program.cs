using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        try
        {
            int[] resultNum;

            var input = Console.ReadLine();
            string inputString = input.ToString() ?? string.Empty;
            int n = int.Parse(inputString.Split(' ')[0]);
            int m = int.Parse(inputString.Split(' ')[1]);
            var gondlaLimit = GetInputNum(n);
            var groupNum = GetInputNum(m);
            
            resultNum = CountGondlaNum(gondlaLimit, groupNum);
            PrintOutput(resultNum);

        }
        catch(Exception e)
        {
            Console.WriteLine($"{e.StackTrace}:{e.Message}");
        }
    }

    private static List<int> GetInputNum(int lineNum)
    {
        {        
            var resultList = new List<int>();
            for(int i = 0; i < lineNum; i++)
            {
                var input = Console.ReadLine();
                int inputInt = int.Parse(input);
                resultList.Add(inputInt);
            }
            return resultList;
        }    
    }

    private static int[] CountGondlaNum (List<int> gondlaLimitList, List<int> groupList)
    {
        int[] resultArray = new int[0];
        Array.Resize(ref resultArray, gondlaLimitList.Count);

        int gondlaIndex = 0;
        int gondlaIndexMax = gondlaLimitList.Count - 1;
        foreach(int group in groupList)
        {
            int groupNum = group;
            while(true)
            {
                int rest =  groupNum - gondlaLimitList[gondlaIndex];
                resultArray[gondlaIndex] += rest <= 0 ? groupNum : gondlaLimitList[gondlaIndex];
                gondlaIndex++;
                groupNum = rest;
                if(gondlaIndex > gondlaIndexMax) gondlaIndex = 0;
                if(rest <= 0) break;
            }
        }
        return resultArray;
    }

    private static void PrintOutput(int[] list)
    {
        foreach(int item in list)
        {
            Console.WriteLine(item);
        }
    } 
}