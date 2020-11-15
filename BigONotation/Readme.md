# Big-O Notation Examples

In the file (big-o.cs)[big-o.cs], I have demonstrated the concepts of three notations: Constant, Linear, and Quadratic.

## Constant Notation - O(1)
From lines 3-6, the function PrintNumber(int number) demonstrates that constant notation represents a process with only one step. It will still only have one step no matter the size of the argument.

## Linear Notation - O(n)
From lines 9-14, the function CountUpToNumber(int number) demonstrates that linear notation represents a process where the number of steps increases with the size of the argument. In my example, the bigger the number you enter the more times the function prints to count up to it.

## Quadratic Notation - O(n^2)
From lines 17-28, the function MakeGrid(int rows, int columns) demonstrates that quadratic notation represents a process where the number of steps increases quadratically. In my example, the number of rows and columns multiplied together would give you the the size of the grid or total number of steps to create it.