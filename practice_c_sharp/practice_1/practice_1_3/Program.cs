class Basics
{
    static void Main(string[] args)
    {
        char operation;
        double operand1, operand2;
        operation=Convert.ToChar(Console.ReadLine());
        operand1 =Convert.ToDouble(Console.ReadLine());
        operand2 =Convert.ToDouble(Console.ReadLine());
        double res=0;
        switch(operation)
        {
            case '+':
                res=operand1+operand2;
                break;
            case '-':
                res = operand1 - operand2;
                break;
            case '*':
                res = operand1 * operand2;
                break;
            case '/':
                res = operand1 / operand2;
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        Console.WriteLine(res);
    }
}