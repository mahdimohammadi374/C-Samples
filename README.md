
# 📡 EventsProject

A simple C# console application demonstrating **C# events** using the modern `EventHandler<T>` pattern.  
This example simulates a stock price tracker where a **publisher** (`Stock`) raises an event when the stock price changes, and a **subscriber** (`NotificationService`) reacts to it.

---

## 📌 Overview
- **Publisher**: `Stock` class defines an event `PriceUpdated`.
- **Subscriber**: `NotificationService` listens to the event and displays price change information.
- **Custom EventArgs**: `UpdatePriceEventArgs` passes the stock symbol, old price, and new price.

---

## 🛠 Features
- Modern `EventHandler<T>` event handling.
- Custom event arguments for strongly-typed event data.
- Null-safe invocation with `?.Invoke`.
- Publisher–Subscriber (Observer) design pattern.

---

## 📂 Project Structure
```
EventsProject/
│
├── Stock.cs                 # Publisher: defines and raises the PriceUpdated event
├── NotificationService.cs   # Subscriber: handles the PriceUpdated event
├── UpdatePriceEventArgs.cs  # Custom EventArgs with stock details
└── Program.cs               # Application entry point
```

---

## 🚀 How It Works
1. The **Stock** class declares:
   ```csharp
   public event EventHandler<UpdatePriceEventArgs> PriceUpdated;
   ```
2. The **NotificationService** subscribes:
   ```csharp
   stock.PriceUpdated += notificationService.NotifyAdmin;
   ```
3. When the stock price changes via:
   ```csharp
   stock.UpdatePrice(5);
   ```
   The `PriceUpdated` event is raised and the subscriber prints the change.

---

## 💻 Example Output
```
Price of Stock symbol a changed from 1 to 5
Hello, World!
```

---

## 🧠 Key Learnings
- **Events** provide a safe way to implement publisher–subscriber communication in C#.
- `EventHandler<T>` is preferred over custom delegates for strongly-typed events.
- Always check for subscribers before invoking an event (or use `?.Invoke`).
- Subscribers can be added (`+=`) or removed (`-=`) dynamically.

---

## 📜 License
MIT License
