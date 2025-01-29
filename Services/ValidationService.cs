using TriangleApp.Interfaces;

namespace TriangleApp.Services
{
    public class ValidationService : IValidationService
    {
        /// <summary>
        /// Triangle Inequality Theorem - (sum of any two sides must be greater than the third side.)
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        public bool IsValidTriangle(decimal[] sides)
        {

            if (sides.Length != 3 )
            {
                return false; // Invalid input
            }

            //sides = {3, 5,4}
            // after sorting { 3,4,5}
            //3+4 = 7
            // 7  must be greater than third side (5) - This holds TRUE

            Array.Sort(sides);
            return (sides[0] + sides[1]) > sides[2];
        }

        public bool ArePositiveSides(decimal[] sides)
        {
            return sides.All(side => side > 0);
        }
    }
}
