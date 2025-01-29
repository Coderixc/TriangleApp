using TriangleApp.Interfaces;

namespace TriangleApp.Services
{
    public class TriangleService : ITriangleService
    {
        public string ClassifyTriangle(decimal[] sides)
        {
            if (sides[0] == sides[1] && sides[1] == sides[2])    //A==B AND B== C => A == C trivially Included
                return "Equilateral";
            if (sides[0] == sides[1] || sides[1] == sides[2] || sides[0] == sides[2]) //A==B OR B==C A (may or mat be Equal ) C
                return "Isosceles";
            return "Scalene";
        }
    }
}
