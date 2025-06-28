# 🎯 Flywieght Pattern with C#

This project demonstrates the **Flyweight Design Pattern** using a simple text rendering example. The goal is to optimize memory usage by reusing shared `Character` objects instead of creating a new one for each character in a string.

## 🧠 What is the Flywieght Pattern?

The Flyweight pattern is a structural design pattern that allows programs to support large numbers of fine-grained objects efficiently by **sharing common instances**.

- **Intrinsic State**: Shared between all objects (e.g., the character `'a'`)
- **Extrinsic State**: Supplied from the outside when needed (e.g., character position)
  
## 📦 Subsystem Components

- `Character`: The flyweight class representing a character.
- `CharacterFactory`: The factory responsible for creating and managing shared `Character` objects.
- `Program`: The client code that uses the factory to render a string using shared characters.
---

### 🛠️ Technologies Used
 
C#

.NET Framework 8.0

### 🤝 Contributing
 
Feel free to fork the repository, submit pull requests, or open issues for improvements and discussions.
