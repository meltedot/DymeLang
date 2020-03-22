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
  Explanation: Creates a range of numbers as a list from the first integer (minimum) to last integer (maximum).  
  Example: `0 --> 5` .. returns: [0, 1, 2, 3, 4]  

  * `->` operator  
  Usage: `obj -> (type)`  
  Explanation: Casts the object to the specific type.  
  Example: `"42" -> (int)` .. returns: 42  

  * `-?>` operator  
  Usage: `obj -?> (type)`  
  Explanation: Type checks the object to see if it is the type.  
  Example: `"42" -?> (int)` .. returns: false  

  * `::` operator  
  Usage: `expr :: expr`  
  Explanation: Checks if first expression is in the last expression (list).  
  Example: `4 :: 0 --> 10` .. returns: true  
  Example: `2 :: [1, 3, 5, 7]` .. returns: false  

  * Simple, one line structuring  
  Usage: `type ? = ?, ?, ?, ...`  
  Explanation: Simple ways of making data structures using types.
  Example:
  ```javascript
  type Point = x, y;
  let highpoint = new Point { x: 2, y: 10 };
  writeln(highpoint);
  /* returns..
  Point: {
    x: 2,
    y: 10
  } */
  // Pretty printing!
  ```  

# Example Programs

## Hello World
```javascript
writeln("Hello World!");
```

## Retrieve a random number in a range
```javascript
let rand = new Random();
writeln(rand.RandomRange(0, 10));
```

## Iteration with indexing
```javascript
for index, number :: 0 --> 10 {
  writeln(index + " " + number);
}
```

## Classes
```javascript
class MyClass = {
  let x = 0; // Variable inside class scope

  // Constructor, called when class is created
  this.ctor = fn {
    writeln("Class created!");
  }

  // Function in class
  this.hello = fn x {
    writeln("Hello " + x + "!");
  }
}

let m = new MyClass();
m.hello();
m.x;
```  

Classes can also have parameters:
```javascript
class ClassWithParameters(x, y) = {
  this.ctor = fn {
    writeln(x + " " + y);
  }
}
let m = new ClassWithParameters(2, 4);
```

## Fibonacci Sequence
```javascript
let fib = fn n {
	if n <= 1 {
		return n;
	}
	return fib(n - 1) + fib(n - 2);
};

writeln(fib(8));
```
