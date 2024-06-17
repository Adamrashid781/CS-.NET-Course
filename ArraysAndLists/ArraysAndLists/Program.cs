using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
    static void Main()
    {
        // ARRAYS

        //int[] numarray = new int[5];
        //numarray[0] = 5;
        //numarray[1] = 2;
        //numarray[2] = 10;
        //numarray[3] = 200;
        //numarray[4] = 5000;


        //console.writeline(numarray[3]);
        //int[] numarray1 = new int[] { 5, 2, 10, 200, 5000, 300, 2300 };

        //int[] numarray2 = { 5, 2, 10, 2000, 30, 5000 };

        //numarray2[5] = 650;
        //console.writeline(numarray2[5]);



        // LISTS

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);


        //List<string> strList = new List<string>();
        //strList.Add("Hello");
        //strList.Add("Adam");
        //strList.Add("Welcome");

        //Console.WriteLine(strList[1]);

        //Console.WriteLine(intList[0]);


        string[] strArray = new string[] {"Adam", "Mom", "Dad"};
        int selection;

        // Prints out the arrays contents
        for (int i = 0; i < strArray.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + strArray[i]);
        }
        Console.WriteLine("select a name!");
        selection = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Array length " + strArray.Length);
        if(selection > strArray.Length)
        {
            Console.WriteLine("You selected an invalid name!");
        }
        else
        {
            // removes 1 from the user input to match it with the actual index of the item intended to be selected in the array
            selection--;
            Console.WriteLine("You selected: " + strArray[selection]);
        }





        int[] intArray = new int[] { 1, 2, 3, 4, 5 };

        for(int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + intArray[i]);
        }
        Console.WriteLine("Select a number!");
        selection = Convert.ToInt32(Console.ReadLine());

        if(selection > intArray.Length)
        {
            Console.WriteLine("You selected an invalid Index!");
        }
        else
        {
            selection--;
            Console.WriteLine("You selected: " + intArray[selection]);
        }


        List<string> strList = new List<string>();
        strList.Add("This is the first item in the List.");
        strList.Add("This is the second item in the List.");
        strList.Add("This is the third item in the List.");

        for(int i = 0; i < strList.Count; i++)
        {
            Console.WriteLine((i+1) + ". " + strList[i]);
        }
        Console.WriteLine("Select a sentence!");
        selection = Convert.ToInt32(Console.ReadLine());

        if(selection > strList.Count)
        {
            Console.WriteLine("You selected an invalid sentence!");
        }
        else
        {
            selection--;
            Console.WriteLine("You selected: " + strList[selection]);
        }


        Console.ReadLine();
        }
    }

