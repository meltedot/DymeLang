# DymeLang
A toy programming language written in C# and parsed with ANTLR4  
Inspired by Rust, F# and Javascript

# Features
## Loose Types
Dyme uses loose or weak type management, meaning that no single variable has a determined type at compilation, therefore are dynamic.

## Variable Declarations and Assignments
```javascript
let x = 2;
x = x + 2; // 4
let y = "Hello";
y = y + " World!"; // Hello World!
```

## Functions
```javascript
let add = fn a, b {
  return a + b;
};

add 2, 4;
add(2, 4);
// These both return the same results.
```
Functions can be called with or without parentheses, however functions with no parameters must be called with parentheses.  
Functions are also expressions as seen by the keyword `fn`, this allows for higher order functions and functions in parameters.

## Control Flow
```javascript
if 20 == 5 {
  // unreachable
} else if 5 + 2 < 50 {
  // reachable
} else if 20 != 5 {
  // unreachable
} else {
  // unreachable
}
```

## Builtins
Dyme uses a very '.NET' way of using Builtins, such as using classes to store built-in functions.  
Here are some examples of built in classes and functions.
```javascript
writeln(""); // display to console
Console.InputLn(); // get input
Console.InputKey(); // get key
String.Length("test"); // string length
let rand = new Random(); // random seed
rand.RandomRange(0, 10); // random range
```

## Unique Features

  * `-->` operator  
  Usage: `int --> int`  
  Explanation: Creates a range of numbers as a list from the first integer (minimum) to last integer (maximum)  
  Example: `0 --> 5` .. returns: [0, 1, 2, 3, 4]  
