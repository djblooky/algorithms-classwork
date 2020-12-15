# Searching Algorithms Demo

## Linear Search
Linear search sequentially checks each element of a data set. It is generally not as efficient as other options unless the data set is very small.

- Worst-case: O(n)
- Best-case: O(1)
- Average: O(n/2)

## Binary Search
Binary search requires a sorted data set. It compares the value in the middle of the data set to the value being searched for. If the values are equal, the target has been found.

## Interpolation Search
Requires a sorted data set. Binary search always chooses the middle of the data set before discarding one half or the other. Interpolation search uses keys. For interpolation search to work efficiently data must be uniformly distributed (in addition to being sorted).

- Best case: O (log log n)
- Worst case:  O(n)
