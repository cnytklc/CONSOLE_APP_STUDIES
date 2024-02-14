// Create 2 arrays named students and grades
// and fill the array elements with the values you received from the user.
// (3 students)

string[] students = new string[3];
int[] studentGrade = new int[3];
int? count = 0;
for (int i = 0; i < students.Length; i++)
{
    
    
    count +=1;
    Console.Write($"Enter {count}. Student Name : ");
    students[i]=Console.ReadLine()?? " ";
    Console.Write($"Enter {count}. Student Grade : ");
    studentGrade[i]= int.Parse(Console.ReadLine()?? "0");
    
}
List<string> list = new List<string>();
List<string> sameName = new List<string>();

foreach (var student in students)
{
    
        if (!list.Contains(student)){
            list.Add(student);
        }
        else
        {
            sameName.Add(student);
        }
}
if (sameName.Count>0){
Console.WriteLine($"YOU ENTER {sameName[0]} MORE THAN 1 TIME");

Console.WriteLine("DO YOU WANT TO EDIT? Y/N");
string? answer = Console.ReadLine().ToUpper();
if (answer == "Y"){
    count=0;
    for (int i = 0; i < students.Length; i++)
{
    
    
    count +=1;
    Console.Write($"Enter {count}. Student Name : ");
    students[i]=Console.ReadLine()?? " ";
    Console.Write($"Enter {count}. Student Grade : ");
    studentGrade[i]= int.Parse(Console.ReadLine()?? "0");
    
}
}

}

for (int i = 0; i < students.Length; i++)
{
Console.WriteLine($"{students[i]} {studentGrade[i]}");
}

// How many students does the students array have?

Console.WriteLine($"How many students do we have is = {students.Length}");

// Sort the grade of students 

Array.Sort(studentGrade,students);

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine($"grade :{studentGrade[i]} name: { students[i]}");
}

// Grade average
var total = 0;
for (int i = 0; i < students.Length; i++)
{
    total+=studentGrade[i];

}
float average = total/students.Length;
Console.WriteLine($"Average is {average}");
