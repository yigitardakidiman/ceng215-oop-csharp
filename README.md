# CENG 215 Course Codes & Assignments 🎓💻

This repository contains the source code for in-class lecture exercises, lab sessions, and homework assignments prepared for the **CENG 215** course.

---

## 📁 Projects & Contents

### 📝 Homework
| Folder / Project | Description | Technology / Language | Status |
| :--- | :--- | :---: | :---: |
| [hw1 (GradeCalculator)](./Homework/hw1/) | A Windows Forms application that calculates the weighted average and letter grade based on course grades and their weight percentages. | C# / .NET 10.0 (WinForms) | Completed ✅ |
| [hw2 (Basic C# Programs)](./Homework/hw2/) | Basic C# console applications: age calculator (`age_calculator.cs`), number operations (`number_operations.cs`) and rectangle calculator (`rectangle_calculator.cs`). | C# / .NET | Completed ✅ |

### 🔬 Lab
| Folder / Project | Description | Technology / Language | Status |
| :--- | :--- | :---: | :---: |
| [21.10.2026 (Lab Week 1)](./Lab/21.10.2026/) | 5 console applications: circle area (Q1), grade average (Q2), temperature converter (Q3), time converter (Q4), swap values (Q5). | C# / .NET 10.0 (Console) | Completed ✅ |
| [28.10.2026 (Lab Week 2)](./Lab/28.10.2026/) | 7 console applications: discount (Q1), temperature (Q2), calculator (Q3), even sum (Q4), sum to zero (Q5), validation (Q6), star triangle (Q7). | C# / .NET 10.0 (Console) | Completed ✅ |
| [04.11.2026 (Lab Week 3)](./Lab/04.11.2026/) | 4 console applications: exam summary (Q1), pattern design (Q2), sort 3 numbers (Q3), hollow rectangle (Q4). | C# / .NET 10.0 (Console) | Completed ✅ |
| [11.11.2026 (Lab Week 4)](./Lab/11.11.2026/) | 3 console applications: separate even and odd numbers (Q1), daily expense tracker (Q2), match students with courses (Q3). | C# / .NET 10.0 (Console) | Completed ✅ |

### 📚 Lecture / Lesson
| Folder / Project | Description | Technology / Language | Status |
| :--- | :--- | :---: | :---: |
| [NumberChecker](./Lesson/NumberChecker/) | A console application that reads an integer and determines whether it is positive, negative, or zero using conditional statements. | C# / .NET 10.0 (Console) | Completed ✅ |

---

## 📂 Directory Structure

```text
CENG_215_Codes/
│
├── Homework/                        # Homework assignments
│   ├── hw1/                         # Homework 1: GradeCalculator (WinForms)
│   │   ├── GradeCalculator/         # WinForms source code (Form1.cs, Program.cs, etc.)
│   │   ├── GradeCalculator.slnx     # Solution file
│   │   └── README.md                # Homework 1 documentation
│   └── hw2/                         # Homework 2: Basic C# console applications
│       ├── age_calculator.cs        # Age calculation
│       ├── number_operations.cs     # Arithmetic operations
│       ├── rectangle_calculator.cs  # Rectangle area and perimeter
│       └── README.md                # Homework 2 documentation
│
├── Lab/                             # Laboratory sessions
│   ├── .gitkeep
│   ├── 21.10.2026/                  # Lab Week 1: 5 console projects (Q1-Q5)
│   │   ├── Q1_CircleArea/           # Circle area and circumference
│   │   ├── Q2_GradeCalculator/      # Midterm/final average and passed/failed
│   │   ├── Q3_TemperatureConverter/ # Celsius -> Fahrenheit
│   │   ├── Q4_TimeConverter/        # Seconds -> hours/minutes/seconds
│   │   ├── Q5_SwapValues/           # Swap using a third variable
│   │   ├── Lab_21_10_2026.slnx      # Solution file
│   │   └── README.md                # Lab documentation
│   ├── 28.10.2026/                  # Lab Week 2: 7 console projects (Q1-Q7)
│   │   ├── Q1_ShoppingDiscount/     # Purchase discount calculator
│   │   ├── Q2_TemperatureClassification/ # Temperature classifier
│   │   ├── Q3_SimpleCalculator/     # Arithmetic calculator with switch
│   │   ├── Q4_EvenNumbersAndSum/    # Even numbers and their sum
│   │   ├── Q5_SumUntilZero/         # Sum and count until 0
│   │   ├── Q6_NumberValidation/     # Input validation with do-while
│   │   ├── Q7_StarTriangle/         # Star triangle pattern
│   │   ├── Outputs.pdf              # Execution screenshots PDF
│   │   ├── Lab_28_10_2026.slnx      # Solution file
│   │   └── README.md                # Lab Week 2 documentation
│   ├── 04.11.2026/                  # Lab Week 3: 4 console projects (Q1-Q4)
│   │   ├── Q1_ExamScoreSummary/     # Exam scores summary
│   │   ├── Q2_PatternDesign/        # Checkerboard pattern design
│   │   ├── Q3_SortThreeNumbers/     # Sort 3 numbers ascending
│   │   ├── Q4_HollowRectangle/      # Hollow rectangle pattern
│   │   ├── Lab_04_11_2026.slnx      # Solution file
│   │   └── README.md                # Lab Week 3 documentation
│   └── 11.11.2026/                  # Lab Week 4: 3 console projects (Q1-Q3)
│       ├── Q1.cs                    # Standalone file for Q1
│       ├── Q2.cs                    # Standalone file for Q2
│       ├── Q3.cs                    # Standalone file for Q3
│       ├── Q1_SeparateEvenOdd/      # Separate even and odd numbers
│       ├── Q2_DailyExpenseTracker/  # Daily expense tracker
│       ├── Q3_MatchStudentsCourses/ # Match students with courses
│       ├── Outputs.pdf              # Execution screenshots PDF (English)
│       ├── Lab_11_11_2026.slnx      # Solution file
│       └── README.md                # Lab Week 4 documentation
│
├── Lesson/                          # In-class lecture examples & exercises
│   ├── NumberChecker/               # Positive, negative, or zero checker
│   │   ├── NumberChecker.csproj     # Project file
│   │   ├── Program.cs               # Console source code
│   │   └── README.md                # Project documentation
│   └── README.md                    # Lesson directory overview
│
├── .gitignore                       # Excludes build output and temporary files
└── README.md                        # Main repository overview
```

---

## 🚀 Running the Projects

Each project has its own `README.md` with detailed build and run instructions.

### Running Windows Forms Projects (e.g. `hw1`):
```bash
cd Homework/hw1/GradeCalculator
dotnet run
```

### Running Lab Projects (e.g. `Lab/21.10.2026`):
```bash
cd Lab/21.10.2026
dotnet run --project Q1_CircleArea
```

### Running Lesson Projects (e.g. `Lesson/NumberChecker`):
```bash
cd Lesson/NumberChecker
dotnet run
```

---

## 👤 Developer

- **Developer:** Yiğit Arda Kıdıman
- **GitHub:** [@yigitardakidiman](https://github.com/yigitardakidiman)
- **Repo:** [CENG215_codes](https://github.com/yigitardakidiman/CENG215_codes)
