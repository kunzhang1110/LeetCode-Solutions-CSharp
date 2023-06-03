# 051-100
## 053 Maximum Subarray
Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

A subarray is a contiguous part of an array.

### Example 1:
    Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
    Output: 6
    Explanation: [4,-1,2,1] has the largest sum = 6.
### Example 2:
    Input: nums = [5,4,-1,7,8]
    Output: 23

Constraints:
- 1 <= nums.length <= 105
- -104 <= nums[i] <= 104

### Solution
Kadane’s Algorithm Dynamic Programming


## 054 Spiral Matrix
Given an m x n matrix, return all elements of the matrix in spiral order.

### Example 1:
![054 Spiral Matrix 1](./_img/054_Spiral_Matrix_1.jpg)

```
Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
```

### Example 2:
![054 Spiral Matrix 2](./_img/054_Spiral_Matrix_2.jpg)
```
Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
```