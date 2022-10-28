namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Fahrentheit -> Celsius: {TempConverter.FahrenheitToCelsius(32)}");
            Console.WriteLine();

            Console.Write($"Celsius -> Fehrentheit: {TempConverter.CelsiusToFahrenheit(0)}");
            Console.WriteLine();
        }
    }
}
