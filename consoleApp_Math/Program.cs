// MATH OPERATIONS

var number= 4.5;

var result = Math.Ceiling(number);
var result1 = Math.Round(number);
var result2 = Math.Floor(number);
var result3 = Math.Min(5,2);
var result4 = Math.Max(5,2);
var result5 = Math.Abs(-5);
var result6 = Math.Cbrt(50);
var result7 = Math.Exp(2);


//////////////////////
///Normal code of max and min finder
// MAX-MIN
Console.WriteLine("Enter 3 number between 1-500 :");
List<int>num = new List<int>();
var bigNum = 0;
var minNum = 501;
for (int i = 0; i <= 2; i++)
{
var nums = Convert.ToInt32(Console.ReadLine());
num.Add(nums);
if(num[i]>bigNum){
    bigNum=num[i];
};
if(num[i]<minNum){
    minNum=num[i];
};
}
Console.Write($"Big num is = {bigNum} and minNum = {minNum}");
