using TriangleApp.Interfaces;

namespace TriangleApp.Controllers
{
    public class TriangleController
    {
        private readonly IValidationService _validationService;
        private readonly ITriangleService _triangleService;
        private readonly IConsoleView _consoleView;

        public TriangleController(IValidationService validationService, ITriangleService triangleService, IConsoleView consoleView)
        {
            _validationService = validationService;
            _triangleService = triangleService;
            _consoleView = consoleView;
        }

        public void Run()
        {
            var sides = _consoleView.GetTriangleSides();

            if (!_validationService.ArePositiveSides(sides))
            {
                _consoleView.DisplayMessage("Sides must be positive integers.");
                return;
            }

            if (!_validationService.IsValidTriangle(sides))
            {
                _consoleView.DisplayMessage("The provided sides do not form a valid triangle.");
                return;
            }

            var triangleType = _triangleService.ClassifyTriangle(sides);
            _consoleView.DisplayMessage($"The triangle is {triangleType}");
        }
    }
}
