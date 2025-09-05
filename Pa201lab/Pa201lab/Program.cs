// See https://aka.ms/new-console-template for more information
/*string name = "Ayten";
Console.WriteLine("Salam " + name);*/
using System.ComponentModel.Design;

/* int num = 9;
if (num > 0)
{
   Console.WriteLine("Positive");
}
else if (num == 0) {
   Console.WriteLine("Zero");
}
else
{ 
   Console.WriteLine("Negative");
} */

/*int age = 43;
if (age<18&&age>0)
{
    Console.WriteLine("Usaq");
}
else if (age<65&&age>18)
{
    Console.WriteLine("Yetkin");
}
else if (age>65)
        {
    Console.WriteLine("Yasli");
}
      
*/

/* int point = 79;
    if (point>100||point<0)
{
    Console.WriteLine("Wrong point");

}
    else if (point>90)
{
    Console.WriteLine("A");

}
    else if (point>70&&point<89)
{
    Console.WriteLine("B");
}
    else if (point>50&&point<69)
{
    Console.WriteLine("C");
}
    else if ( point<50)
        {
        Console.WriteLine("F"); 
    } */
/*string name = Console.ReadLine();
Console.WriteLine("Salam" + name);*/
string input = Console.ReadLine();
int n = Convert.ToInt32(input);
if (n > 0) Console.WriteLine("Positive");
else if (n < 0) Console.WriteLine("Negative");
else Console.WriteLine("Zero");
