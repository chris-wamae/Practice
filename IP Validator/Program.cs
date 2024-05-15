using System;
using System.Diagnostics;
using System.Net;

//how to test for maximum and minimum values using this method
bool Validator(string ipString)
{
    int num;
    bool result = true;
    for (int x = 0; x < ipString.Length; x++)
    {
        if (
            !int.TryParse(ipString[x].ToString(), out num)
            && ipString[x].ToString() != "."
            && result
        )
        {
            //Console.WriteLine(ipString[x].ToString());

            result = false;
        }
        else if (ipString[x].ToString() == ".")
        {
            if (x + 2 < ipString.Length)
            {
                // Console.WriteLine("ran");
                //Console.WriteLine("limit");
                //Console.WriteLine(x + 2);
                //Console.WriteLine("length");
                //Console.WriteLine(ipString.Length);
                if (ipString[x + 1].ToString() == "0" && ipString[x + 2].ToString() != ".")
                {
                    //Console.WriteLine("In zero not followed by period");
                    result = false;
                }

               
            }

            

            if (x + 3 < ipString.Length)
            {
                if (ipString[x + 3].ToString() != ".")
                {
                    if (String.Compare(ipString[x + 1].ToString(), "2") > 0)
                    {
                        //Console.WriteLine("In greater than 2");
                        //Console.WriteLine(ipString[x + 1]);
                        result = false;
                    }
                    if (String.Compare(ipString[x + 2].ToString(), "5") > 0)
                    {
                        //Console.WriteLine("In greater than 5");
                        //Console.WriteLine(ipString[x + 2]);
                        result = false;
                    }
                }

                if (String.Compare(ipString[x + 3].ToString(), "6") > 0)
                {
                   // Console.WriteLine("In greater than 6");
                    result = false;
                }
            }

            if(x + 4 <  ipString.Length)
            {
                if (ipString[x + 4].ToString() != "." && ipString[x + 3].ToString() != "." && ipString[x + 2].ToString() != ".")
                {
                    result = false;
                }
            }
         

        }
    }
    return result;
}

//this is the end of the method


//    if (ipString.Any(x => Char.IsWhiteSpace(x)))
//    {
//        return false;
//    };

//    string[] ipNumbers = ipString.Split(new char[] { '.' });

//    if (ipNumbers.Length != 4)
//    {
//        return false;
//    }

//    int i = 0;
//    int num;

//    foreach (string ipNumber in ipNumbers)
//    {
//        if (!int.TryParse(ipNumber, out num))
//        {
//            return false;
//        }

//        char firstCharacter = ipNumber.ToCharArray()[0];
//        if (firstCharacter == '0' && ipNumber.ToCharArray().Length > 1)
//        {
//            return false;
//        }

//        i++;

//        int ipNum = int.Parse(ipNumber);

//        if (ipNum > 255 || ipNum < 0)
//        {
//            return false;
//        }

//        i++;
//    }
//    return true;

//}

string[] testArray = new string[]
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
    "pr12.34.56. 78",
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
    //Validator(test);
    //;
}


//current code
// 1. checks if the ipString has a whitespace using an if statement
// 2. splits the string along the periods, adds each part into an array and checks if the length is 4
// 3. creates a new string array of 8 chracters
// 4. tries to parse each member of the string array into an integer
// 5. checks if the first character of each of the members of the string array has a trailing zero
// 6. converts each string array member into an integer and checks if its less than 255 or less than 0
// 7. if any is it is added to the string array of 8 characters

//new solution



//bool validString = true;
//int num;

//string s = "pr12.34.56. 78";

//for(int i = 0; i < s.Length; i++)
//{
// if(validString)
// {
//  validString = int.TryParse(s, out num);
// }
//}

//return validString;

//string[] arr = new string[] { "01", "10" };

//Console.WriteLine(arr.Max());


public static bool is_Valid_IP(string ipAddres)
{
var ipString = ipAddres.Split(".");

if(ipString.Length != 4)
    {
    return false;
    }

foreach (string stringNum in ipString)
    {
      if(!int.TryParse(stringNum, out int num))
        return  false;
      if(num < 0 || num > 255)
        {
            return false;
        }
      if(!num.ToString().Equals(stringNum))
        { return false; }
    }

return true;

}