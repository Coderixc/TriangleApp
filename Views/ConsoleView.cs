using TriangleApp.Interfaces;

namespace TriangleApp.Views
{
    public class ConsoleView : IConsoleView
    {
        public decimal[] GetTriangleSides()
        {
            Console.WriteLine("Enter the three sides of the triangle:");
            decimal sideA = GetValidSide("Side A: ");
            decimal sideB = GetValidSide("Side B: ");
            decimal sideC = GetValidSide("Side C: ");
            return new[] { sideA, sideB, sideC };
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        private decimal GetValidSide(string prompt)
        {
            decimal side;
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out side) && side > 0)
                    break;
                Console.WriteLine("Please enter a positive integer.");
            }
            return side;
        }
    }
}
