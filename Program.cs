using TriangleApp.Controllers;
using TriangleApp.Services;
using TriangleApp.Views;
using System.Threading;

namespace TriangleClassificationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new TriangleController(new ValidationService(), new TriangleService(), new ConsoleView());
            controller.Run();

            Thread.Sleep(100000);
        }
    }
}
