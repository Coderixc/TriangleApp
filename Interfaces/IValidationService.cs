namespace TriangleApp.Interfaces
{
    public interface IValidationService
    {
        bool IsValidTriangle(decimal[] sides);
        bool ArePositiveSides(decimal[] sides);
    }
}
