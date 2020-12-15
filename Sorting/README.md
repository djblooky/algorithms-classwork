# Sorting Algorithms Demo

## Bubble Sort
Bubble sort starts from the beginning of an array swapping the first two elements whenever the first one is larger, and does this all the way until the end.

- Runtime: O(n2) average and worst case
- Memory: O(1)
- Example: Bubble.cs

## Insertion Sort
Insertion sort creates the final sorted set one element at a time. It is efficient on small data sets but is much less efficient on large sets than quicksort, heapsort, or merge sort. 

- Runtime: best case is O(n), and worst case is O(n2)
- Memory: O(1) to O(n)
- Example: Insertion.cs

## Selection Sort
Selection sort is an in-place comparison sorting algorithm. It is not efficient on large lists, and tends to perform worse than insertion sort. 

- Runtime: O(n2) average and worst case
- Memory: O(1)
- Selection.cs

## Heap Sort
Heapsort is a comparison-based sort-in-place algorithm that takes no extra storage. It's usually called an improved selection sort. 

- Runtime: O(n log n) best case
- Memory: O(1)
- Example: Heap.cs

## Quick Sort
Quicksort is a divide and conquer algorithm. It first divides the input array into two smaller sub-arrays: the low elements and the high elements. It then recursively sorts the sub-arrays. (Wikepedia)

- Runtime: O(n log n) average, O(n2) worst case
- Memory: O(log n)
- Example: Quick.cs

## Merge Sort
Merge sort is a divide and conquer algorithm, where the input array is divided into two halves that are sorted and then later merged.

- Runtime: O(n log n) average and worst case
- Memory: O(n)
- Example: Merge.cs
