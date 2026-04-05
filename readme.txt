Robotics Challenge Solution
This repository contains two projects:

repository url : https://github.com/KeduGangurde-1991/robotics-challenge-solution

RoboticsApp: The main console application implementing robot allocation strategies (Levels 1–4).

RoboticsChallenge.Tests: The xUnit test project validating allocation strategies and exception handling.

📂 Project Structure
Code
robotics-challenge-solution/
├── RoboticsChallengeSolution.sln   # Solution file
├── RoboticsApp/                    # Main project
│   └── RoboticsApp.csproj
├── RoboticsChallenge.Tests/        # Unit test project
│   └── RoboticsChallenge.Tests.csproj
└── README.md
🚀 Running the Main Project
Navigate to the root folder:

bash
cd robotics-challenge-solution
Run the console application:

bash
dotnet run --project RoboticsApp/RoboticsApp.csproj
The program will prompt you to:

Select an allocation level (1–4).

Enter requested hours.

View the allocation result (total hours, cost, and assigned robots).

🧪 Running Unit Tests
Navigate to the root folder:

bash
cd robotics-challenge-solution
Restore dependencies:

bash
dotnet restore
Build the solution:

bash
dotnet build RoboticsChallengeSolution.sln
Run all tests:

bash
dotnet test RoboticsChallengeSolution.sln
✅ What the Tests Cover
Allocation Strategies: Level 1–4 allocators.

Exception Handling: Invalid input, impossible allocation, no robots available.

Multi-Client Scenarios: Ensures Level 4 allocator handles multiple requests.

📌 Notes
Requires .NET 6 or later.

Works with VS Code or Visual Studio.

The solution file ensures both projects are managed together.