//Hello World and Student ID
Console.WriteLine("Hello, World!");

Console.Write("Enter Student Name:");
var studentName = Console.ReadLine();
Console.Write("Enter Student Surname:");
var studentSurname = Console.ReadLine();
Console.Write("Enter Student Number:");
int studentNo = Convert.ToInt32(Console.ReadLine());


    switch (studentNo)
    {
        case 190403084:Console.WriteLine($"{studentName} {studentSurname}");
        break;

        default:Console.WriteLine("THERE IS NO STUDENT NUMBER WHICH YOU ENTER");
        break;
    }
    
