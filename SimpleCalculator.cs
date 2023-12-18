

Console.WriteLine("Welcome to the Simple Calculator!");

Console.Write("Enter the first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine("Choose an operation:");

Console.WriteLine("[+] Addition");
Console.WriteLine("[-] Substraction");
Console.WriteLine("[*] Multiplication");
Console.WriteLine("[/] Division");

Console.Write("Enter the operation sign: ");
char operationSign = char.Parse(Console.ReadLine());

switch (operationSign)
{
	case '+':
		Console.WriteLine($"Result: {firstNum} + {secondNum} =  {Addition(firstNum, secondNum)}");
		break;
	case '-':
		Console.WriteLine($"Result: {firstNum} - {secondNum} =  {Substraction(firstNum, secondNum)}");
		break;
	case '*':
		Console.WriteLine($"Result: {firstNum} * {secondNum} =  {Multiplication(firstNum, secondNum)}");
		break;
	case '/':
		Console.WriteLine($"Result: {firstNum} / {secondNum} =  {Division(firstNum, secondNum)}");
		break;
}


static double Addition(int firstNum, int secondNum)
	=> firstNum + secondNum;


static double Substraction(int firstNum, int secondNum)
    => firstNum - secondNum;


static double Multiplication(int firstNum, int secondNum)
    => firstNum * secondNum;


static double Division(int firstNum, int secondNum)
    => firstNum / secondNum;