Console.WriteLine("Enter a number: ");
var num1 =  Convert.ToInt32(Console.ReadLine());
var oldNum = 0;
int newNum = 1;
var result = 0;
for (int i = 0; i < num1; i++)
{
Console.Write($"{oldNum} ");

   result = newNum + oldNum;
   oldNum=newNum;
 newNum = result;


}
