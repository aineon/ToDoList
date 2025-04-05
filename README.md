
# Simple Calculator & TODO List Projects

This solution contains two small projects:

- **Simple Calculator**
- **Simple TODO List**

These projects were completed as part of a Udemy Course:
- _Ultimate C# Masterclass for 2025_ by **Krystyna Ślusarczyk**

Each project was first built independently based on requirements provided by the tutor, followed by a comparison with the tutor’s implementation.


This solution contains the following 4 projects:
- `Calculator` (Built by me before viewing the tutor's solution)
- `CalculatorTutorSolution`
- `TODOListMain` (Built by me before viewing the tutor's solution)
- `TODOListTutorSolution`

---

## Simple Calculator

### 🛠 Built With
- C# Console Application

### ✅ Requirements

The user inputs two numbers and selects an operation (add, subtract, multiply). The program then outputs the selected operation and result.

### ▶️ Workflow
```
Hello!
Input the first number:
> (User input)
Input the second number:
> (User input)
What do you want to do with those numbers?
[A]dd
[S]ubtract
[M]ultiply
> (User input)

(Result is displayed)
Press any key to close
```

### 📘 Selecting an Option by the User
| Scenario               | User Action                             | Result                                                 |
|------------------------|------------------------------------------|--------------------------------------------------------|
| Addition               | User enters 'A' or 'a'                   | Displays: `5 + 10 = 15`                                |
| Subtraction            | User enters 'S' or 's'                   | Displays: `5 - 10 = -5`                                |
| Multiplication         | User enters 'M' or 'm'                   | Displays: `5 * 10 = 50`                                |
| Incorrect input        | Invalid or empty input                   | Displays: `Invalid option`                             |

---

## Simple TODO List

### 🛠 Built With
- C# Console Application

### ✅ Requirements
Manage a list of TODOs (add, view, and remove tasks). Each TODO must have a unique, non-empty description.

### ▶️ Main Workflow
```
Hello!
What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
> (User input)
```

The user can continue performing actions until they choose to exit.

---

## 📘 Selecting an Option by the User

### Scenario: Sunny Day
- **User Action**: Enters `S`, `A`, `R`, or `E` (case-insensitive)
- **Result**: The corresponding operation is handled. Afterwards, the main menu is printed again (unless exiting).

### Scenario: Incorrect or Empty Input
- **User Action**: Enters an invalid option or leaves it empty
- **Result**: `Incorrect input` is displayed. Menu reprinted until valid input is provided.

---

## 📝 Option "S" - See All TODOs

### Scenario: Sunny Day
- **Result**: TODOs printed in list format with indexes (starting at 1).
```
1. Order a cake for the birthday party.
2. Buy train tickets for the weekend.
3. Take Lucky to the vet.
```

### Scenario: No TODOs Present
- **Result**: `No TODOs have been added yet.`

---

## ➕ Option "A" - Add a TODO

### Prompt:
```
Enter the TODO description:
> (User input)
```

### Scenario: Sunny Day
- **Result**: `TODO successfully added: [DESCRIPTION]`

### Scenario: Empty Description
- **Result**: `The description cannot be empty.` and re-prompts

### Scenario: Non-Unique Description
- **Result**: `The description must be unique.` and re-prompts

---

## ❌ Option "R" - Remove a TODO

### Prompt:
```
Select the index of the TODO you want to remove:
```

### Scenario: Sunny Day
- **User Action**: Enters valid index
- **Result**: `TODO removed: [DESCRIPTION]`

### Scenario: No TODOs Present
- **Result**: `No TODOs have been added yet.`

### Scenario: Empty Index
- **Result**: `Selected index cannot be empty.` and re-prompts

### Scenario: Invalid Index
- **Result**: `The given index is not valid.` and re-prompts

---

## 🚪 Option "E" - Exit
- Closes the application.

---


