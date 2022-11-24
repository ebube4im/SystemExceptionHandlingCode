namespace SystemExceptionHandlingCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _selection;
            int _firstNumber;
            int _secondNumber;

            try
            {
                Console.WriteLine("Welcome to Our Calculator.");
                Console.WriteLine("Which operation do you want to perform?");
               Console.WriteLine("Reply \n 1: Addtion  \n 2: Subtraction  \n 3: Division  \n 4: Multiplication");
                _selection = int.Parse( Console.ReadLine());
                
                
                switch (_selection)
                {
                    case 1:
                        Console.WriteLine("You have selected Addition operation");

                      

                        try
                        {
                            Console.WriteLine("Enter the First Number");
                            _firstNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Second Number");
                            _secondNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine(Calculate.Add(_firstNumber, _secondNumber));


                        }
                        catch (FormatException ex)
                        {

                            Console.WriteLine($"Oops! {ex.Message}");


                        }
                        catch (ArgumentException ex)
                        {

                            Console.WriteLine($"Oops! Is the number not too large? Here is the error message {ex.Message}");

                        }


                        break;
                    case 2:

                        Console.WriteLine("You have selected SUbtraction operation");

                    

                        try
                        {
                            Console.WriteLine("Enter the First Number");
                            _firstNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Second Number");
                            _secondNumber = int.Parse(Console.ReadLine());
                           Console.WriteLine( Calculate.Subtract(_firstNumber, _secondNumber));

                        }
                        catch (FormatException ex)
                        {

                            Console.WriteLine($"Oops! {ex.Message}");

                        }
                        catch (ArgumentException ex)
                        {

                            Console.WriteLine($"Oops! Is the number not too large? Here is the error message {ex.Message}");

                        }
                        break;

                    case 3:

                        Console.WriteLine("You have selected Division operation");
                                     

                        try
                        {
                            Console.WriteLine("Enter the First Number");
                            _firstNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Second Number");
                            _secondNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine(Calculate.Divide(_firstNumber, _secondNumber));

                        }
                        catch (FormatException ex)
                        {

                            Console.WriteLine($"Oops! {ex.Message}");

                        }
                        catch (DivideByZeroException ex)
                        {

                            Console.WriteLine($"Oops! You attempted to divide by Zero. Here is the error message: {ex.Message}");

                        }
                        catch (ArgumentException ex)
                        {

                            Console.WriteLine($"Oops! Is the number not too large? Here is the error message {ex.Message}");

                        }
                        catch (ArithmeticException ex)
                        {

                            Console.WriteLine($"Oops! Our Calculator didnt see that coming! Here is the error message {ex.Message}");

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine($"Oops! Our Calculator didnt see that coming! Here is the error message {ex.Message}");

                        }
                        break;

                    case 4:

                        Console.WriteLine("You have selected Multiply operation");

                       

                        try
                        {
                            Console.WriteLine("Enter the First Number");
                            _firstNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Second Number");
                            _secondNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine(Calculate.Subtract(_firstNumber, _secondNumber));

                        }
                        catch (FormatException ex)
                        {

                            Console.WriteLine($"Oops! {ex.Message}");

                        }
                        catch (ArgumentException ex)
                        {

                            Console.WriteLine($"Oops! Is the number not too large? Here is the error message {ex.Message}");

                        }
                        break;

                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Something must have gone wrong! Here is the message {ex.Message}");
            }

           
        }
    }
}