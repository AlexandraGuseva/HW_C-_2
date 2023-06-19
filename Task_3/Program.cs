// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter the number that represents the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("This day is a holyday");
    }
    else if (dayNumber < 1 || dayNumber >7)
    {
        Console.WriteLine("There is no such day");
    }    
    else
    {Console.WriteLine("There is no holiday");}
}
CheckingTheDayOfTheWeek (dayNumber);
    