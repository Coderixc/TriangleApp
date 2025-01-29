# Triangle Type Determination Program

## Project Overview
This project is a simple yet structured program to determine the type of a triangle based on its three side lengths. The solution follows clean and maintainable code practices with a focus on readability, error handling, and scalability.

### Key Features
- **Triangle Classification:** Identifies if a triangle is Equilateral, Isosceles, or Scalene.
- **Input Validation:** Ensures that user inputs form a valid triangle.
- **Clean Architecture:** Follows the MVC (Model-View-Controller) design pattern for clear separation of responsibilities.
- **Testable Code:** will add this .

---

## How to Run the Project
1. Clone this repository to your local machine.
2. Open the project in **Visual Studio**.
3. Build the solution.
4. Run the application from the terminal using the console.


---

## Project Structure
```

```

### Explanation of Each Component
- **Controllers:** Manages the flow between user input, validation, and business logic.
  - `TriangleController.cs`: Handles interactions between the view and services.

- **Models:** Encapsulates triangle data.
  - `TriangleModel.cs`: Holds the side lengths of a triangle.

- **Services:** Contains business logic and validation rules.
  - `TriangleService.cs`: Classifies triangles as Equilateral, Isosceles, or Scalene.
  - `ValidationService.cs`: Ensures valid input and checks triangle inequality.

- **Views:** Manages user interactions.
  - `ConsoleView.cs`: Reads input and displays output in the console.

- **Interfaces:** Defines contracts for services and views to keep the system flexible and testable.
  - `ITriangleService.cs`: Interface for triangle classification.
  - `IValidationService.cs`: Interface for input validation.
  - `IConsoleView.cs`: Interface for console interactions.

- **Program.cs:** The entry point of the application.

---


### Error Handling
- If the sides do not form a valid triangle, the program will show an error.

---



## Future Enhancements
- Unit testing using **xUnit**.
- ASP.NET Core Web API integration for web-based interactions.
- GUI-based interface using **WinForms** or **WPF**.

---

## Key Takeaways
- Simple and clean project structure.
- MVC design pattern for maintainability.
- Separation of concerns for easier testing and code changes.
- Well-documented code and directory structure for better understanding.

If you have any suggestions or improvements, feel free to fork this repository and contribute!

