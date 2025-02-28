# Robot Simulator

## **Project Overview**

This project is a **C# Robot Simulator** that simulates a toy robot moving on a **5x5 tabletop** while following specific commands.

### **Features**

- Move the robot around the tabletop
- Rotate left or right
- Prevent the robot from falling off the edges
- Report the robot's current position
- Read commands from `commands.txt`

---

## **Installation & Setup**

### **1. Clone the Repository**

```sh
git clone <repository-url>
cd RobotSimulator
```

### **2. Build the Project**

```sh
dotnet build
```

---

## **Running the Project**

### **Option 1: Using Command Line Input**

Run the application and manually enter commands:

```sh
dotnet run --project RobotSimulator
```

Enter commands like:

```
PLACE 0,0,NORTH
MOVE
REPORT
```

Type `EXIT` to quit.

### **Option 2: Using a Commands File**

Create a `commands.txt` file in the project root with commands:

```
PLACE 0,0,NORTH
MOVE
REPORT
```

Copy `commands.txt` to the `bin/Debug/net8.0/` folder before running:

```sh
cp commands.txt bin/Debug/net8.0/
```

Then run:

```sh
dotnet run --project RobotSimulator
```

The program will execute commands from `commands.txt`.

---

## **Running Unit Tests**

### **1. Navigate to the Tests Project**

```sh
cd Tests
```

### **2. Run All Tests**

```sh
dotnet test
```

---

## **Project Structure**

```
/RobotSimulator
│── /Enums
│   └── Direction.cs
│── /Interfaces
│   └── IRobot.cs
│── /Models
│   ├── TableTop.cs
│   └── Robot.cs
│── /Services
│   └── CommandProcessor.cs
│── Program.cs
│── RobotSimulator.csproj
│── /Tests
│   ├── RobotTests.cs
│   ├── CommandProcessorTests.cs
│   ├── TableTopTests.cs
│   └── RobotSimulator.Tests.csproj
│── cs│hou── README.md
```

---

## **License**

This project is licensed under the MIT License.

