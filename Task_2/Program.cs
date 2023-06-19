// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Input three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
if (stringNumber.Length > 2)
{
Console.WriteLine("The second digit of this number: " + stringNumber[2]);
}
else
{
    Console.WriteLine("No third digit");
}
