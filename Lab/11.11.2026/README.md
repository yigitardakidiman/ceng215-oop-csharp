# Lab - 11.11.2026 (CENG 215 Lab Week 4) 🧪

This folder contains the 3 C# console applications assigned in the CENG 215 lab session on **11.11.2026** (Lab Week 4 / Course Week 7: *Arrays and Lists in C#*). Each question is implemented as an independent .NET console project grouped under a single solution (`Lab_11_11_2026.slnx`), alongside standalone `.cs` files ready for LMS submission.

---

## 📂 Projects & Questions

| Question | Project / File | Description |
| :---: | :--- | :--- |
| **Q1** | [Q1_SeparateEvenOdd](./Q1_SeparateEvenOdd/Program.cs) / [Q1.cs](./Q1.cs) | Reads a non-negative integer $N$, separates integers from $0$ to $N$ into even and odd arrays, and prints them using `foreach`. |
| **Q2** | [Q2_DailyExpenseTracker](./Q2_DailyExpenseTracker/Program.cs) / [Q2.cs](./Q2.cs) | Reads expenses until `0`, validates positive amounts in a `List<decimal>`, and calculates total and count of expenses $\ge 100$ TL. |
| **Q3** | [Q3_MatchStudentsCourses](./Q3_MatchStudentsCourses/Program.cs) / [Q3.cs](./Q3.cs) | Reads student names and courses into two 1D arrays, combines them into a 2D `string[,]` array, and displays student-course pairs. |

---

## 📦 LMS Submission Package

In accordance with the lab assignment guidelines:
* **Folder:** `240208425_YigitArdaKidiman_Week4/`
  * Contains the 3 standalone source files: `Q1.cs`, `Q2.cs`, `Q3.cs`
  * Contains [Outputs.pdf](./Outputs.pdf) compiled in English from high-resolution screenshots.
  * Contains `img/` folder with source execution captures (`Q1.png`, `Q2.png`, `Q3.png`).
* **ZIP Archive:** [240208425_YigitArdaKidiman_Week4.zip](./240208425_YigitArdaKidiman_Week4.zip) (Ready for direct LMS upload, contains `Q1.cs`, `Q2.cs`, `Q3.cs`, and `Outputs.pdf`).

---

## 📁 Directory Structure

```text
11.11.2026/
├── Q1.cs
├── Q2.cs
├── Q3.cs
├── Q1_SeparateEvenOdd/
│   ├── Program.cs
│   └── Q1_SeparateEvenOdd.csproj
├── Q2_DailyExpenseTracker/
│   ├── Program.cs
│   └── Q2_DailyExpenseTracker.csproj
├── Q3_MatchStudentsCourses/
│   ├── Program.cs
│   └── Q3_MatchStudentsCourses.csproj
├── 240208425_YigitArdaKidiman_Week4/
│   ├── Q1.cs
│   ├── Q2.cs
│   ├── Q3.cs
│   ├── Outputs.pdf
│   └── img/
│       ├── Q1.png
│       ├── Q2.png
│       └── Q3.png
├── 240208425_YigitArdaKidiman_Week4.zip
├── Outputs.pdf
├── Lab_11_11_2026.slnx
└── README.md
```
│       ├── Q2.png
│       └── Q3.png
├── 240208425_YigitArdaKidiman_Week7.zip
├── Outputs.pdf
├── Lab_11_11_2026.slnx
└── README.md
```

---

## 🚀 Running the Projects

### Visual Studio
Open `Lab_11_11_2026.slnx`, right-click the project you want to test, select **Set as Startup Project**, and press **F5**.

### .NET CLI
```bash
cd Lab/11.11.2026
dotnet run --project Q1_SeparateEvenOdd
dotnet run --project Q2_DailyExpenseTracker
dotnet run --project Q3_MatchStudentsCourses
```

Or run standalone files directly:
```bash
dotnet run Q1.cs
```
