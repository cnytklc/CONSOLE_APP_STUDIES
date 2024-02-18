//Finding 2 numbers' EBOB-EKOK
public static class EbobCalculation
{
    public static int Ebob(int number1, int number2){

int result=0;
for (int i = 1; i <= number1 && i<= number2; i++)
{
    if(number1%i==0 && number2%i==0){
       result=i;
    }
}
Console.Write($"EBOB is : {result}");
    return result;

    }
}

class EkokCalculation
{
    public static int Ekok(int number1, int number2){
    var ekok = (number1*number2)/EbobCalculation.Ebob(number1,number2);

Console.WriteLine($"EKOK is : {ekok}");
return ekok;
}
}


class Program
{
    public static void Main(string[] args){
Console.Write("Enter 2 numbers: ");
var number1 = Convert.ToInt32(Console.ReadLine());
var number2 = Convert.ToInt32(Console.ReadLine());
var result = EbobCalculation.Ebob(number1,number2);
var result1 = EkokCalculation.Ekok(number1,number2);


    
}
}
