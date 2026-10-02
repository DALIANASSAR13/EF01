Here are simple, student-style answers for the write-up questions:

### 1. Delegate vs Lambda Expression

* **Delegate:** It's like a pointer or container that holds a reference to a method. It defines what signature (parameters and return type) a method must have.
* **Lambda Expression:** It's just a short and fast syntax using the `=>` arrow to write an anonymous method directly inline.
* **In short:** A delegate is the **type**, while a lambda is a quick way to **create an instance** of that delegate.

---

### 2. Why is `var` still statically typed?

`var` is not dynamic. The compiler looks at the initial value when you build your code and sets the exact type right then. Once defined, the type can never change.

* Example: If you write `var x = 10;`, `x` becomes an `int` forever. Trying to write `x = "Hello";` later will give you a compiler error!

---

### 3. Scenario where an Anonymous Type is better than a Class

When you only need a temporary group of data in **one specific place** (like picking just the `Name` and `Price` of a product to display in a UI), creating an anonymous type (`new { Name, Price }`) is much faster. You don't need to waste time writing a separate class file that you will only use once.