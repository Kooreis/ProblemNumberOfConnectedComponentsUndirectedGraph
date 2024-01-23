# Question: How do you find the number of connected components in an undirected graph? JavaScript Summary

The JavaScript code provided defines a Graph class that is used to represent an undirected graph. The Graph class has methods to add vertices and edges to the graph, perform a depth-first search (DFS), and calculate the number of connected components in the graph. The DFS method is used to traverse the graph, marking each visited vertex to avoid revisiting it. The connectedComponents method uses the DFS method to traverse the graph, incrementing a count each time a new unvisited vertex is found, which represents a new connected component. After defining the Graph class, the code creates an instance of the Graph, adds vertices and edges to it, and then uses the connectedComponents method to calculate and log the number of connected components in the graph. This approach effectively solves the problem of finding the number of connected components in an undirected graph by using DFS to traverse the graph and count the connected components.

---

# TypeScript Differences

The TypeScript version of the solution is similar to the JavaScript version in terms of logic and structure. Both versions use a Graph class with methods for adding vertices and edges, performing a depth-first search (DFS), and finding the number of connected components. The main differences between the two versions are due to TypeScript's static typing and class property visibility features.

1. Static Typing: TypeScript is a statically typed superset of JavaScript. This means that you have to declare the type of a variable when you declare it. In the TypeScript version, types are declared for all variables and function return values. For example, the `vertices` property is declared as a number, the `adj` property is declared as a 2D number array, and the `connectedComponents` method is declared to return a number.

2. Class Property Visibility: TypeScript supports three types of visibility for properties and methods in a class: public (default), private, and protected. In the TypeScript version, the `vertices` and `adj` properties are declared as private, meaning they can only be accessed within the Graph class.

3. Array Initialization: In the JavaScript version, a Map object is used to store adjacency lists for the vertices. In the TypeScript version, a 2D array is used instead. The array is initialized using the `Array.from` method, which creates a new array instance from a length object or iterable object.

4. Looping: In the JavaScript version, for-in loop is used to iterate over the adjacency list of a vertex. In the TypeScript version, a traditional for loop is used instead.

5. Vertex Representation: In the JavaScript version, vertices are represented as strings ('A', 'B', 'C', etc.). In the TypeScript version, vertices are represented as numbers (0, 1, 2, etc.).

---

# C++ Differences

The C++ version of the solution uses a similar approach to the JavaScript version, using Depth-First Search (DFS) to find the number of connected components in an undirected graph. However, there are some differences due to the language features and methods used in each version.

1. Data Structures: In the JavaScript version, a Map object is used to store the adjacency list of the graph, while in the C++ version, an array of lists (list<int> *adj) is used. The JavaScript version also uses an object (visited = {}) to keep track of visited vertices, while the C++ version uses a dynamic boolean array (bool *visited).

2. Class and Object: Both versions define a Graph class with similar methods. However, the way these methods are defined and used is slightly different due to the differences between JavaScript and C++. In JavaScript, methods are defined inside the class using the method name followed by parentheses, while in C++, methods are defined outside the class using the scope resolution operator (::).

3. Memory Management: In the C++ version, memory for the adjacency list and the visited array is allocated dynamically using the new keyword, and it is the programmer's responsibility to deallocate this memory using delete when it is no longer needed. In contrast, JavaScript has automatic garbage collection, so there is no need to manually deallocate memory.

4. Iteration: The JavaScript version uses for...of and for...in loops to iterate over the keys of the adjacency list and the elements of each adjacency list, respectively. The C++ version uses iterators to iterate over the elements of each adjacency list.

5. Output: The JavaScript version logs the number of connected components to the console using console.log, while the C++ version prints the connected components to the standard output using cout. The C++ version also prints each vertex in the connected components, which the JavaScript version does not do.

---
