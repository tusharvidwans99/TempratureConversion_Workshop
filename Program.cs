namespace TempratureConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
        Repeat: Console.WriteLine("Press 1 to convert F -> C\nPress 2 to Convert C -> F");
            int option = Convert.ToInt32(Console.ReadLine());

              switch (option)
            {
                case 1:
                    ConvertTemp.FahrenheitToCelcius();
                    break;
                case 2:
                    ConvertTemp.CelciusToFahrenheit();
                    break;
                default:
                    Console.WriteLine("Enter Valid Number (1 OR 2)");
                    Console.WriteLine("Want to try again the press \'y\' else press enter");
                    string anotherTry = Console.ReadLine(); 
                    if(anotherTry == "y"){
                        goto Repeat;

                    }
                    else
                    {
                        break;
                    }
            }
        }
    }
}