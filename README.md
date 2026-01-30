
# DSA Array Interview Preparation – Solved Problems (26)

This repository contains **26 array problems** solved during interview preparation.

For **each problem**, the following is documented:
- Problem statement
- Difficulty level
- LeetCode link (or reference)
- Brute force approach
- Optimal approach
- Pattern used
- Link to final C# implementation (relative path, GitHub-friendly)

---

## 1. Two Sum
**Level:** Easy  
**LeetCode:** https://leetcode.com/problems/two-sum/

**Problem Statement:**  
Given an array of integers and a target value, return indices of the two numbers such that they add up to the target.

**Brute Force Approach:**  
Check every pair using two nested loops.  
Time: O(n²)

**Optimal Approach:**  
Store elements in a hash map as you scan. For each element, check if its complement exists in the map. **Key insight:** Trade space for time - remember what you've seen to avoid nested loops. **O(n) time, O(n) space.**

**Pattern Used:**  
Hashing

**Code:** [array/01_TwoSum.cs](array/01_TwoSum.cs)

---

## 2. Contains Duplicate
**Level:** Easy  
**LeetCode:** https://leetcode.com/problems/contains-duplicate/

**Problem Statement:**  
Determine if any value appears more than once in the array.

**Brute Force Approach:**  
Compare each element with every other element.

**Optimal Approach:**  
Use a set to track seen elements. If you encounter an element already in the set, it's a duplicate. **Key insight:** Set provides constant-time lookup. **O(n) time, O(n) space.**

**Pattern Used:**  
Hashing / Set

**Code:** [array/02_ContainsDuplicate.cs](array/02_ContainsDuplicate.cs)

---

## 3. Find the Duplicate Number
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/find-the-duplicate-number/

**Problem Statement:**  
Given an array containing n+1 integers where each integer is between 1 and n, find the duplicate number.

**Brute Force Approach:**  
Sort the array and check adjacent elements.

**Optimal Approach:**  
Model the array as a linked list and apply cycle detection. The duplicate number is the entry point to the cycle. **Key insight:** Treat indices as pointers - duplicate creates multiple paths to same node. **O(n) time, O(1) space.**

**Pattern Used:**  
Cycle Detection

**Code:** [array/03_FindDuplicate.cs](array/03_FindDuplicate.cs)

---

## 4. Sort Colors
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/sort-colors/

**Problem Statement:**  
Sort an array containing only 0s, 1s, and 2s in-place.

**Brute Force Approach:**  
Count occurrences of 0, 1, and 2 and overwrite the array.

**Optimal Approach:**  
Dutch National Flag: Three-way partitioning with one pass. Maintain regions for 0s, 1s, and 2s, swapping elements into their correct regions. **Key insight:** Single pass is enough when you partition into three zones. **O(n) time, O(1) space.**

**Pattern Used:**  
Two Pointers / Partitioning

**Code:** [array/04_SortColors.cs](array/04_SortColors.cs)

---

## 5. Remove Duplicates from Sorted Array
**Level:** Easy  
**LeetCode:** https://leetcode.com/problems/remove-duplicates-from-sorted-array/

**Problem Statement:**  
Remove duplicates from a sorted array in-place and return the new length.

**Brute Force Approach:**  
Use an auxiliary array.

**Optimal Approach:**  
Two-pointer technique: One pointer tracks position for unique elements, another scans ahead. Since array is sorted, duplicates are adjacent. **Key insight:** Overwrite duplicates in-place. **O(n) time, O(1) space.**

**Pattern Used:**  
Two Pointers

**Code:** [array/05_RemoveDuplicates.cs](array/05_RemoveDuplicates.cs)

---

## 6. Maximum Subarray
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/maximum-subarray/

**Problem Statement:**  
Find the contiguous subarray with the largest sum.

**Brute Force Approach:**  
Check all possible subarrays.

**Optimal Approach:**  
Kadane's Algorithm: Track running sum and global maximum. Reset running sum when it becomes negative. **Key insight:** Negative prefix defeats the purpose - start fresh. **O(n) time, O(1) space.**

**Pattern Used:**  
Kadane / Dynamic Programming

**Code:** [array/06_MaximumSubarray.cs](array/06_MaximumSubarray.cs)

---

## 7. Minimum Size Subarray Sum
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/minimum-size-subarray-sum/

**Problem Statement:**  
Find the minimal length of a contiguous subarray with sum greater than or equal to a target.

**Brute Force Approach:**  
Check all subarrays.

**Optimal Approach:**  
Slidding Window: Expand window until sum meets target, then shrink from left to minimize length. **Key insight:** Valid window can only get shorter by removing from left, not right. **O(n) time, O(1) space.**

**Pattern Used:**  
Sliding Window

**Code:** [array/07_MinSizeSubarraySum.cs](array/07_MinSizeSubarraySum.cs)

---

## 8. Subarray Sum Equals K
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/subarray-sum-equals-k/

**Problem Statement:**  
Count the number of subarrays whose sum equals k.

**Brute Force Approach:**  
Check all subarrays.

**Optimal Approach:**  
Prefix Sum with hash map: Track how many times each prefix sum has appeared. **Key insight:** If two positions have same prefix sum difference of k, the subarray between them sums to k. **O(n) time, O(n) space.**

**Pattern Used:**  
Prefix Sum

**Code:** [array/08_SubarraySumEqualsK.cs](array/08_SubarraySumEqualsK.cs)

---

## 9. Majority Element
**Level:** Easy  
**LeetCode:** https://leetcode.com/problems/majority-element/

**Problem Statement:**  
Find the element that appears more than ⌊n/2⌋ times.

**Brute Force Approach:**  
Count frequencies.

**Optimal Approach:**  
Boyer-Moore Voting: Use cancellation strategy - pair up different elements. **Key insight:** Majority element will survive because it appears more than all others combined. **O(n) time, O(1) space.**

**Pattern Used:**  
Voting Algorithm

**Code:** [array/09_MajorityElement.cs](array/09_MajorityElement.cs)

---

## 10. Move Zeroes
**Level:** Easy  
**LeetCode:** https://leetcode.com/problems/move-zeroes/

**Problem Statement:**  
Move all zeroes to the end while maintaining the order of non-zero elements.

**Brute Force Approach:**  
Use extra array.

**Optimal Approach:**  
Two-pointer partitioning: Collect all non-zero elements at the front; zeros naturally fall to the back. **Key insight:** Similar to partition in quicksort. **O(n) time, O(1) space.**

**Pattern Used:**  
Two Pointers

**Code:** [array/10_MoveZeroes.cs](array/10_MoveZeroes.cs)

---

## 11. Max Consecutive Ones
**Level:** Easy  
**LeetCode:** https://leetcode.com/problems/max-consecutive-ones/

**Problem Statement:**  
Find the maximum number of consecutive 1s in the array.

**Brute Force Approach:**  
Count for each index.

**Optimal Approach:**  
Track current streak and global maximum. Reset streak counter when you hit a zero. **Key insight:** Simple state machine. **O(n) time, O(1) space.**

**Pattern Used:**  
Linear Scan

**Code:** [array/11_MaxConsecutiveOnes.cs](array/11_MaxConsecutiveOnes.cs)

---

## 12. Best Time to Buy and Sell Stock
**Level:** Easy  
**LeetCode:** https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

**Problem Statement:**  
Find the maximum profit from one buy and one sell.

**Brute Force Approach:**  
Try all buy-sell pairs.

**Optimal Approach:**  
Greedy: Track the minimum price seen so far and calculate potential profit at each step. **Key insight:** Best profit = sell at current price minus lowest price before it. **O(n) time, O(1) space.**

**Pattern Used:**  
Greedy

**Code:** [array/12_BestTimeToBuySellStock.cs](array/12_BestTimeToBuySellStock.cs)

---

## 13. Trapping Rain Water
**Level:** Hard  
**LeetCode:** https://leetcode.com/problems/trapping-rain-water/

**Problem Statement:**  
Compute how much water can be trapped after raining.

**Brute Force Approach:**  
For each index, find max left and right.

**Optimal Approach:**  
Precompute maximum heights on left and right for each position. Water trapped = min of both maximums minus current height. **Key insight:** Water level limited by shorter wall. Alternative: two-pointer for O(1) space. **O(n) time, O(n) space.**

**Pattern Used:**  
Preprocessing

**Code:** [array/13_TrappingRainWater.cs](array/13_TrappingRainWater.cs)

---

## 14. First Missing Positive
**Level:** Hard  
**LeetCode:** https://leetcode.com/problems/first-missing-positive/

**Problem Statement:**  
Find the smallest missing positive integer.

**Brute Force Approach:**  
Sort array.

**Optimal Approach:**  
Cyclic Sort: Place each number at its natural index position. First mismatched index reveals the missing positive. **Key insight:** Use array itself as hash table. **O(n) time, O(1) space.**

**Pattern Used:**  
In-place Hashing

**Code:** [array/14_FirstMissingPositive.cs](array/14_FirstMissingPositive.cs)

---

## 15. 3Sum
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/3sum/

**Problem Statement:**  
Find all unique triplets that sum to zero.

**Brute Force Approach:**  
Three nested loops.

**Optimal Approach:**  
Sort array, fix one element, then use two-pointer technique to find pairs that complete the triplet. **Key insight:** Sorting enables efficient duplicate handling and two-pointer search. **O(n²) time, O(1) space.**

**Pattern Used:**  
Two Pointers

**Code:** [array/15_ThreeSum.cs](array/15_ThreeSum.cs)

---

## 16. 4Sum
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/4sum/

**Problem Statement:**  
Find all unique quadruplets that sum to the target.

**Brute Force Approach:**  
Four nested loops.

**Optimal Approach:**  
Sort array, fix two elements with nested loops, then use two-pointer for remaining pair. **Key insight:** Reduce 4Sum to 2Sum by fixing two elements. **O(n³) time, O(1) space.**

**Pattern Used:**  
Two Pointers

**Code:** [array/16_FourSum.cs](array/16_FourSum.cs)

---

## 17. Leaders in an Array
**Level:** Easy  

**Problem Statement:**  
Find all elements that are greater than or equal to all elements to their right.

**Brute Force Approach:**  
For each element, scan right.

**Optimal Approach:**  
Traverse right to left, maintaining the maximum seen so far. Any element greater than or equal to this maximum is a leader. **Key insight:** Right-to-left scan avoids checking each element's entire suffix. **O(n) time, O(1) space.**

**Pattern Used:**  
Greedy

**Code:** [array/17_LeadersInArray.cs](array/17_LeadersInArray.cs)

---

## 18. Next Permutation
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/next-permutation/

**Problem Statement:**  
Find the next lexicographical permutation.

**Brute Force Approach:**  
Generate all permutations.

**Optimal Approach:**  
Find pivot (first descending pair from right), swap with next larger element, then reverse the suffix. **Key insight:** Next permutation is the smallest increase, achieved by minimal swap and reversing. **O(n) time, O(1) space.**

**Pattern Used:**  
Permutation Logic

**Code:** [array/18_NextPermutation.cs](array/18_NextPermutation.cs)

---

## 19. Majority Element II
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/majority-element-ii/

**Problem Statement:**  
Find all elements appearing more than ⌊n/3⌋ times.

**Brute Force Approach:**  
Frequency map.

**Optimal Approach:**  
Extended Boyer-Moore for two candidates. Find potential candidates via voting, then verify their actual counts. **Key insight:** At most 2 elements can appear more than n/3 times. **O(n) time, O(1) space.**

**Pattern Used:**  
Voting Algorithm

**Code:** [array/19_MajorityElementII.cs](array/19_MajorityElementII.cs)

---

## 20. Maximum Product Subarray
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/maximum-product-subarray/

**Problem Statement:**  
Find the contiguous subarray with maximum product.

**Brute Force Approach:**  
Check all subarrays.

**Optimal Approach:**  
Track both maximum and minimum product ending at each position. Consider all three possibilities at each step. **Key insight:** Negative × negative = positive, so maintain both extremes. **O(n) time, O(1) space.**

**Pattern Used:**  
Dynamic Programming

**Code:** [array/20_MaximumProductSubarray.cs](array/20_MaximumProductSubarray.cs)

---

## 21. Contiguous Array
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/contiguous-array/

**Problem Statement:**  
Find the maximum length subarray with equal number of 0s and 1s.

**Brute Force Approach:**  
Check all subarrays.

**Optimal Approach:**  
Transform problem: Convert 0→-1, now find longest subarray with sum 0. Use prefix sum with hash map to track first occurrence. **Key insight:** Equal counts means sum = 0 after transformation. **O(n) time, O(n) space.**

**Pattern Used:**  
Prefix Sum

**Code:** [array/21_ContiguousArray.cs](array/21_ContiguousArray.cs)

---

## 22. Maximum Sum Circular Subarray
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/maximum-sum-circular-subarray/

**Problem Statement:**  
Find the maximum subarray sum in a circular array.

**Brute Force Approach:**  
Duplicate array and check all subarrays.

**Optimal Approach:**  
Two cases: maximum is either non-wrapping (use Kadane) or wrapping (total - minimum subarray). **Key insight:** Circular maximum = total sum - circular minimum. **O(n) time, O(1) space.**

**Pattern Used:**  
Kadane / Greedy

**Code:** [array/22_MaxCircularSubarray.cs](array/22_MaxCircularSubarray.cs)

---

## 23. Merge Intervals
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/merge-intervals/

**Problem Statement:**  
Merge all overlapping intervals.

**Brute Force Approach:**  
Compare every interval with others.

**Optimal Approach:**  
Sort intervals by start time, then merge overlapping ones in a single pass. **Key insight:** After sorting, overlapping intervals are consecutive. **O(n log n) time, O(n) space.**

**Pattern Used:**  
Sorting + Greedy

**Code:** [array/23_MergeIntervals.cs](array/23_MergeIntervals.cs)

---

## 24. Longest Increasing Subsequence (DP)
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/longest-increasing-subsequence/

**Problem Statement:**  
Find the length of the longest increasing subsequence.

**Brute Force Approach:**  
Generate all subsequences.

**Optimal Approach:**  
Dynamic Programming: For each position, find the longest increasing subsequence ending at that position by checking all previous elements. **Key insight:** DP[i] = 1 + max(DP[j]) for all j < i where nums[j] < nums[i]. **O(n²) time, O(n) space.**

**Pattern Used:**  
Dynamic Programming

**Code:** [array/24_LIS_DP.cs](array/24_LIS_DP.cs)

---

## 25. Longest Increasing Subsequence (Binary Search)
**Level:** Hard  

**Problem Statement:**  
Find LIS length using optimized approach.

**Brute Force Approach:**  
DP O(n²).

**Optimal Approach:**  
Greedy + Binary Search: Maintain smallest possible tail for each length. Use binary search to find where current element fits. **Key insight:** Keeping smallest tails maximizes future extension possibilities. **O(n log n) time, O(n) space.**

**Pattern Used:**  
Binary Search + Greedy

**Code:** [array/25_LIS_BinarySearch.cs](array/25_LIS_BinarySearch.cs)

---

## 26. Product of Array Except Self
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/product-of-array-except-self/

**Problem Statement:**  
Return an array where each element is the product of all other elements.

**Brute Force Approach:**  
For each index multiply all other elements.

**Optimal Approach:**  
Two-pass: First pass computes prefix products, second pass computes suffix products and combines them. **Key insight:** Product at i = (product of all before i) × (product of all after i). **O(n) time, O(1) space.**

**Pattern Used:**  
Prefix / Suffix

**Code:** [array/26_ProductExceptSelf.cs](array/26_ProductExceptSelf.cs)

---
## 27. Reverse the Array
**Level:** Easy  
**GFG:** https://www.geeksforgeeks.org/write-a-program-to-reverse-an-array-or-string/

**Problem Statement:**  
Reverse the given array in-place.

**Brute Force Approach:**  
Create a new array and copy elements in reverse order.  
Time: O(n), Space: O(n)

**Optimal Approach:**  
Use two pointers (start & end) and swap elements while moving inward.  
Time: O(n), Space: O(1)

**Pattern Used:**  
Two Pointers

**Code:** [array/27_ReverseArray.cs](array/27_ReverseArray.cs)

---

## 28. Find Maximum and Minimum in an Array
**Level:** Easy  
**GFG:** https://www.geeksforgeeks.org/maximum-and-minimum-in-an-array/

**Problem Statement:**  
Find the minimum and maximum element in the array.

**Brute Force Approach:**  
Sort the array and pick first and last elements.

**Optimal Approach:**  
Single linear scan maintaining current min and max.  
Time: O(n), Space: O(1)

**Pattern Used:**  
Linear Scan

**Code:** [array/28_MinMaxArray.cs](array/28_MinMaxArray.cs)

---

## 29. Kth Minimum / Maximum Element in an Array
**Level:** Medium  
**GFG:** https://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array/

**Problem Statement:**  
Find the kth smallest or largest element in an unsorted array.

**Brute Force Approach:**  
Sort the array and return kth element.

**Optimal Approach:**  
Quickselect / Heap-based selection. Average O(n).

**Pattern Used:**  
Selection Algorithm

**Code:** [array/29_KthElement.cs](array/29_KthElement.cs)

---

## 30. Jump Game
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/jump-game/

**Problem Statement:**  
Determine if you can reach the last index.

**Brute Force Approach:**  
Recursive exploration / DP.

**Optimal Approach:**  
Greedy – track farthest reachable index.

**Pattern Used:**  
Greedy

**Code:** [array/30_JumpGame.cs](array/30_JumpGame.cs)

---

## 31. Jump Game II
**Level:** Hard  
**LeetCode:** https://leetcode.com/problems/jump-game-ii/

**Problem Statement:**  
Find the minimum number of jumps to reach the end.

**Brute Force Approach:**  
Recursive / DP.

**Optimal Approach:**  
Greedy range expansion (BFS-like levels).

**Pattern Used:**  
Greedy / BFS Levels

**Code:** [array/31_JumpGameII.cs](array/31_JumpGameII.cs)

---

## 32. Union of Two Arrays
**Level:** Easy  
**GFG:** https://www.geeksforgeeks.org/find-union-and-intersection-of-two-unsorted-arrays/

**Problem Statement:**  
Find the union of two arrays.

**Brute Force Approach:**  
Merge arrays and remove duplicates.

**Optimal Approach:**  
Use HashSet to store distinct elements.

**Pattern Used:**  
Hashing

**Code:** [array/32_UnionOfArrays.cs](array/32_UnionOfArrays.cs)

---

## 33. Intersection of Two Arrays
**Level:** Easy–Medium  
**LeetCode:** https://leetcode.com/problems/intersection-of-two-arrays/

**Problem Statement:**  
Find the intersection of two arrays (distinct elements).

**Brute Force Approach:**  
Check each element of one array in the other.

**Optimal Approach:**  
HashSet-based lookup.

**Pattern Used:**  
Hashing

**Code:** [array/33_IntersectionOfArrays.cs](array/33_IntersectionOfArrays.cs)

---

## 34. Container With Most Water
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/container-with-most-water/

**Problem Statement:**  
Find two lines that together with the x-axis form a container holding the maximum water.

**Brute Force Approach:**  
Check all pairs of lines and compute area.  
Time: O(n²)

**Optimal Approach:**  
Two pointers from both ends, move the smaller height inward.  
Time: O(n), Space: O(1)

**Pattern Used:**  
Two Pointers / Greedy

**Code:** [array/34_ContainerWithMostWater.cs](array/34_ContainerWithMostWater.cs)

---

## 35. Trapping Rain Water
**Level:** Hard  
**LeetCode:** https://leetcode.com/problems/trapping-rain-water/

**Problem Statement:**  
Compute how much water can be trapped between bars after raining.

**Brute Force Approach:**  
For each index, find max to left and right.  
Time: O(n²)

**Optimal Approach:**  
Prefix max + suffix max or two-pointer technique.  
Time: O(n), Space: O(n) / O(1)

**Pattern Used:**  
Prefix / Two Pointers

**Code:** [array/35_TrappingRainWater.cs](array/35_TrappingRainWater.cs)

---

## 36. Product of Array Except Self
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/product-of-array-except-self/

**Problem Statement:**  
Return an array where each element is the product of all other elements except itself.

**Brute Force Approach:**  
For each index, multiply all other elements.  
Time: O(n²)

**Optimal Approach:**  
Prefix and suffix products.  
Time: O(n), Space: O(1) extra

**Pattern Used:**  
Prefix / Suffix

**Code:** [array/36_ProductExceptSelf.cs](array/36_ProductExceptSelf.cs)

---

## 37. First Missing Positive
**Level:** Hard  
**LeetCode:** https://leetcode.com/problems/first-missing-positive/

**Problem Statement:**  
Find the smallest missing positive integer in an unsorted array.

**Brute Force Approach:**  
Sort and scan positives.  
Time: O(n log n)

**Optimal Approach:**  
Index placement (cyclic sort idea).  
Time: O(n), Space: O(1)

**Pattern Used:**  
Cyclic Sort / Index Mapping

**Code:** [array/37_FirstMissingPositive.cs](array/37_FirstMissingPositive.cs)

---

## 38. Majority Element (> n/2)
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/majority-element/

**Problem Statement:**  
Find the element that appears more than n/2 times.

**Brute Force Approach:**  
Count frequencies using map.

**Optimal Approach:**  
Boyer–Moore Voting Algorithm.  
Time: O(n), Space: O(1)

**Pattern Used:**  
Voting Algorithm

**Code:** [array/38_MajorityElement.cs](array/38_MajorityElement.cs)

---

## 39. Majority Element II (> n/3)
**Level:** Hard  
**LeetCode:** https://leetcode.com/problems/majority-element-ii/

**Problem Statement:**  
Find all elements that appear more than n/3 times.

**Brute Force Approach:**  
Frequency map.

**Optimal Approach:**  
Extended Boyer–Moore (two candidates + verification).  
Time: O(n), Space: O(1)

**Pattern Used:**  
Voting Algorithm

**Code:** [array/39_MajorityElementII.cs](array/39_MajorityElementII.cs)

---

## 40. Merge Intervals
**Level:** Medium  
**LeetCode:** https://leetcode.com/problems/merge-intervals/

**Problem Statement:**  
Merge all overlapping intervals.

**Brute Force Approach:**  
Compare every interval pair.

**Optimal Approach:**  
Sort by start time and merge greedily.  
Time: O(n log n)

**Pattern Used:**  
Sorting / Greedy

**Code:** [array/40_MergeIntervals.cs](array/40_MergeIntervals.cs)

---

