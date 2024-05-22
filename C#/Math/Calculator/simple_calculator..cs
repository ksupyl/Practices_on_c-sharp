using System;

public class MainClass
{
    public static void Main()
    {
        // put your c# code here
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        string znak = Console.ReadLine();
        switch(znak) {
            case "+":
                Console.WriteLine(num1 + num2);
                break;
            case "-":
                Console.WriteLine(num1 - num2);
                break;
            case "*":
                Console.WriteLine(num1 * num2);
                break;
            case "/":
                if(num2 != 0){
                    Console.WriteLine(num1 / num2);
                    break;
                } else {
                    Console.WriteLine("Error, you cannot divide by zero.");
                    break;
                    }
            case "%":
                Console.WriteLine(num1 * 0.01 * num2);
                break;
        }
    }
}