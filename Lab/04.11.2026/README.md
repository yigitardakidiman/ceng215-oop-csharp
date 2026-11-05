# Lab - 04.11.2026 (CENG 215 Lab Week 3) 🧪

This folder contains the 4 C# console applications assigned in the CENG 215 lab session on **04.11.2026**. Each question is implemented as an independent .NET console project grouped under a single solution (`Lab_04_11_2026.slnx`).

---

## 📂 Projects

| Question | Project | Description |
| :---: | :--- | :--- |
| **Q1** | [Q1_ExamScoreSummary](./Q1_ExamScoreSummary/Program.cs) | Reads exam scores until `-1` is entered; validates 0–100, counts passes (≥60) and fails, and calculates average. |
| **Q2** | [Q2_PatternDesign](./Q2_PatternDesign/Program.cs) | Prints an $N \times N$ checkerboard pattern using `<>` and `{}` based on whether `(row + col)` is even or odd. |
| **Q3** | [Q3_SortThreeNumbers](./Q3_SortThreeNumbers/Program.cs) | Reads three integers and sorts them in ascending order using conditional statements and a temporary variable. |
| **Q4** | [Q4_HollowRectangle](./Q4_HollowRectangle/Program.cs) | Draws a hollow rectangle of size $Rows \times Cols$ using asterisks (`*`) for borders and spaces for inner cells. |

---

## 📁 Directory Structure

```text
04.11.2026/
├── Q1_ExamScoreSummary/
│   ├── Program.cs
│   └── Q1_ExamScoreSummary.csproj
├── Q2_PatternDesign/
│   ├── Program.cs
│   └── Q2_PatternDesign.csproj
├── Q3_SortThreeNumbers/
│   ├── Program.cs
│   └── Q3_SortThreeNumbers.csproj
├── Q4_HollowRectangle/
│   ├── Program.cs
│   └── Q4_HollowRectangle.csproj
├── Lab_04_11_2026.slnx
└── README.md
```

---

## 🚀 Running the Projects

### Visual Studio
Open `Lab_04_11_2026.slnx`, right-click the project you want to test, select **Set as Startup Project**, and press **F5**.

### .NET CLI
```bash
cd Lab/04.11.2026
dotnet run --project Q1_ExamScoreSummary
```
