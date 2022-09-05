// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Channels;

Console.WriteLine("Hello! Welcome to my all you can eat buffet. We charge $9.99 per person. Water is free, however soda is not included. How many people are in your group? (Please have a party of 6 or less people.)");

int people = int.Parse(Console.ReadLine());
if (people > 6)

    Console.WriteLine("Sorry, you have too many people in your party. Goodbye.");
if (people > 6)
    System.Environment.Exit(0);

Console.WriteLine();


Console.WriteLine("A table for " + people + "... Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or soda.");




int i = 1;
while (i <= people)


{
    Console.WriteLine("Person number " + (i++) + ", soda or water? ");
    

    
    string drink =
           Console.ReadLine();
    

    Console.WriteLine(drink + " , that's a great choice.");
    
    Console.WriteLine();



    int s = 0;
    foreach (Match m in Regex.Matches(drink, "soda"))
    {
        int[] ints = new int[7] { 0, 1, 2, 3, 4, 5, 6, };
    }

    int q = 0;
    foreach (Match t in Regex.Matches(drink, "water"))
    {
        int[] intt = new int[7] { 0, 1, 2, 3, 4, 5, 6, }; 
    }

}

string soda = "0";
string water = "0";
int a = Convert.ToInt32(soda);
int b = Convert.ToInt32(water);


Console.WriteLine("Okay. So that is " + (b++) + " waters and" + (a++) + "  sodas. I'll be right back. Feel free to grab your food.");
    Console.WriteLine();

    double d = Convert.ToDouble(soda);
    double d2 = Convert.ToDouble(water);



double w = 9.99;
  
    int c = 0;
c = (int)w;

    Console.WriteLine("Here's your bill! Total price:  $" + (people *c + (a++ * a)));














