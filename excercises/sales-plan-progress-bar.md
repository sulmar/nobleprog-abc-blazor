# 📈 Task: Sales Plan Progress Bar

## 🧩 Goal
The goal of this task is to extend the dashboard tile with a progress bar that shows the sales plan progress — e.g. `66 / 100 products sold`.

---

## ✅ Functional Requirements:

1. Component `ProgressBar.razor`  
Create a component that displays a progress bar in percentages.

- The bar should automatically read progress data (Current / Total)  
- Display progress in a graphical form (e.g. Bootstrap progress bar)  
- The bar should be embeddable in other components without explicitly passing parameters through each layer  

2. Page `Dashboard.razor`  
- Add a dashboard tile with the embedded progress bar.

---

## ✅ Example tile visualization:

Sales plan progress: `66 / 100`

[██████████░░░░░░░░░░░░░░░░] 66%

---

## 💡 Tips
- For calculations, you can use:  
  `int Percent => Current * 100 / Total`

---

## ⏱️ Estimated time: **45 minutes**

If you have any questions — ask the instructor 🙂
