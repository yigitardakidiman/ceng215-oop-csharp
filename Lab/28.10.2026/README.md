# Lab - 28.10.2026 (CENG 215 Lab Week 2) 🧪

This folder contains the 7 C# console applications assigned in the CENG 215 lab session on **28.10.2026**. Each question is implemented as a separate .NET console project, and all projects are grouped under a single solution (`Lab_28_10_2026.slnx`).

---

## 📂 Projects

| Question | Project | Description |
| :---: | :--- | :--- |
| **Q1** | [Q1_ShoppingDiscount](./Q1_ShoppingDiscount/Program.cs) | Reads the purchase amount; applies a 10% discount if the amount is 1,000 TL or more and displays the final payment. |
| **Q2** | [Q2_TemperatureClassification](./Q2_TemperatureClassification/Program.cs) | Classifies temperatures into Freezing (<0°C), Cold (0–15°C), Mild (15–25°C), or Hot (≥25°C). |
| **Q3** | [Q3_SimpleCalculator](./Q3_SimpleCalculator/Program.cs) | Performs arithmetic operations (+, -, *, /) using `switch-case`, including division-by-zero and invalid operator handling. |
| **Q4** | [Q4_EvenNumbersAndSum](./Q4_EvenNumbersAndSum/Program.cs) | Reads a positive integer N and displays all even numbers from 2 to N along with their sum (validates N > 0). |
| **Q5** | [Q5_SumUntilZero](./Q5_SumUntilZero/Program.cs) | Repeatedly reads integers until 0 is entered; displays the sum and count of all non-zero numbers using a `while` loop. |
| **Q6** | [Q6_NumberValidation](./Q6_NumberValidation/Program.cs) | Prompts the user until an integer between 1 and 10 is entered using a `do-while` loop; prints confirmation upon valid entry. |
| **Q7** | [Q7_StarTriangle](./Q7_StarTriangle/Program.cs) | Reads a positive row count and renders a right-angled star triangle pattern using nested loops. |

---

## 📁 Directory Structure

```text
28.10.2026/
├── Q1_ShoppingDiscount/
├── Q2_TemperatureClassification/
├── Q3_SimpleCalculator/
├── Q4_EvenNumbersAndSum/
├── Q5_SumUntilZero/
├── Q6_NumberValidation/
├── Q7_StarTriangle/
├── Outputs.pdf
├── Lab_28_10_2026.slnx
└── README.md
```

---

## 🚀 Running

### Visual Studio
Open `Lab_28_10_2026.slnx`, right-click the project you want to test, select **Set as Startup Project**, and press **F5**.

### .NET CLI
```bash
cd Lab/28.10.2026
dotnet run --project Q1_ShoppingDiscount
```

> **Note:** On systems with Turkish regional settings, decimal numbers are input using a comma (e.g., `234,50`).
