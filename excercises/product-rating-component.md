# 📊 Task: Product Rating Component

## 🧩 Goal:

Your task is to create a Blazor component that allows a user to rate a product on a scale from `1` to `5` using interactive stars. The component should be self-contained and reusable across different parts of the application.

---

## ✅ Functional Requirements:
1. **Create the component** `StarRating.razor`, which:
   - Displays 5 stars in a single row  
   - Highlights stars according to the current rating (e.g., filled icon for active stars, empty for the rest)  
   - Allows clicking on any star to set the rating (1–5)  

2. **In the parent component** (`ProductView.razor`):  
   - Embed the `StarRating` component  
   - Store the current rating as an `int`  
   - After a rating is set, display a text message, e.g.: **“Thank you! Your rating: 4/5”**

---

## 💡 Tips
- Add the `bootstrap-icons` library in `index.html`:
```html
<link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.css" rel="stylesheet">
```
- Filled star: `<i class="bi bi-star-fill text-warning"></i>`  
- Empty star: `<i class="bi bi-star text-muted"></i>`  
- CSS: you can apply `cursor: pointer` to clickable elements  

---

## 🧠 Extension (optional)
- Send the rating through an API  

---

## ⏱️ Estimated Time: **45 minutes**

If you have any questions — ask the instructor 🙂  
