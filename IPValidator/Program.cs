using System;
using System.Net;

bool Validator(string ipString)
{   if (ipString.Any(x => Char.IsWhiteSpace(x)))
        {
        return false;
         };

    string[] ipNumbers = ipString.Split(new char[] { '.' });
    if (ipNumbers.Length != 4)
        return false;
    string[] filteredList = new string[8];
    int i= 0;
    int num;
   
    foreach (string ipNumber in ipNumbers)
    {   
        if(!int.TryParse(ipNumber, out num))
            return false;
        char firstCharacter = ipNumber.ToCharArray()[0];
        if (firstCharacter == '0' && ipNumber.ToCharArray().Length > 1)
        {
            filteredList[i] = ipNumber;
        }
            
        i++;

        int ipNum = int.Parse(ipNumber);

        if (ipNum > 255 || ipNum < 0)
        {
            filteredList[i] = ipNumber;
        }
            
        i++;
    }
    
    bool final = true;
    foreach (string ipNumber in filteredList) 
    {
       
     if(ipNumber != null)
        {
        final = false;
        }
    }

    return final;

}

string[] testArray  = new string[]
{
"0.0.0.0",
"12.255.56.1",
"137.255.156.100",
"abc.def.ghi.jkl",
"123.456.789.0",
"12.34.56",
"12.34.56.00",
"12.34.56.7.8",
"12.34.256.78",
"1234.34.56",
"pr12.34.56.78",
"12.34.56.78sf",
"12.34.56 .1",
"12.34.56.-1",
"123.045.067.089"
};

foreach (var test in testArray)
{
    Console.WriteLine($"This is the test: {test}");
    Console.WriteLine(Validator(test));
    //Console.WriteLine(test.Any(x => Char.IsWhiteSpace(x)))
    //;

}