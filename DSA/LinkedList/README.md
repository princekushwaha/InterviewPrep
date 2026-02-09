# 📌 Linked List – DSA Interview Preparation

This folder contains **Linked List problems solved for interview preparation**, following a **pattern-based and interview-first approach**.

Each problem includes:
- Problem statement (brief)
- Pattern used
- Brute force idea
- Optimal approach
- Time & Space complexity
- Problem link
- ✅ **Link to C# solution file**

---

## 🧠 Patterns Covered
- Two Pointers
- Fast & Slow Pointer
- Cycle Detection (Floyd’s Algorithm)
- Pointer Rewiring
- Dummy Node Technique
- In-place List Manipulation

---

## ✅ Problems Solved (Linked List)

---

### 1. Reverse Linked List
**Level:** Easy  
**Pattern:** Pointer Reversal  

**Problem:** Reverse a singly linked list.

**Brute Force:**  
Store nodes in an array and rebuild the list.

**Optimal Approach:**  
Iteratively reverse pointers using `prev`, `curr`, `next`.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/reverse-linked-list/  
💻 **Code:** [ReverseLinkedList.cs](./ReverseLinkedList.cs)

---

### 2. Middle of the Linked List
**Level:** Easy  
**Pattern:** Fast & Slow Pointer  

**Problem:** Find the middle node (return second middle if even length).

**Brute Force:**  
Count nodes and traverse to n/2.

**Optimal Approach:**  
Slow pointer moves 1 step, fast moves 2 steps.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/middle-of-the-linked-list/  
💻 **Code:** [MiddleOfLinkedList.cs](./MiddleOfLinkedList.cs)

---

### 3. Detect Cycle in Linked List
**Level:** Medium  
**Pattern:** Floyd’s Cycle Detection  

**Problem:** Detect if a cycle exists.

**Brute Force:**  
Use HashSet to track visited nodes.

**Optimal Approach:**  
Fast & slow pointers meet if a cycle exists.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/linked-list-cycle/  
💻 **Code:** [DetectCycle.cs](./DetectCycle.cs)

---

### 4. Find Starting Point of Cycle
**Level:** Medium–Hard  
**Pattern:** Floyd’s Algorithm + Math  

**Problem:** Return the node where the cycle begins.

**Brute Force:**  
Use HashSet to store visited nodes.

**Optimal Approach:**  
Reset one pointer to head after meeting point.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/linked-list-cycle-ii/  
💻 **Code:** [CycleStartNode.cs](./CycleStartNode.cs)

---

### 5. Merge Two Sorted Linked Lists
**Level:** Easy–Medium  
**Pattern:** Pointer Merge  

**Problem:** Merge two sorted linked lists.

**Brute Force:**  
Copy values to array, sort, rebuild list.

**Optimal Approach:**  
In-place merge using pointers / dummy node.

**Time:** O(n + m)  
**Space:** O(1)

🔗 https://leetcode.com/problems/merge-two-sorted-lists/  
💻 **Code:** [MergeTwoSortedLists.cs](./MergeTwoSortedLists.cs)

---

### 6. Remove Nth Node From End
**Level:** Medium  
**Pattern:** Two Pointer Gap  

**Problem:** Remove nth node from the end.

**Brute Force:**  
Count length and remove.

**Optimal Approach:**  
Maintain gap of `n` between two pointers.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/remove-nth-node-from-end-of-list/  
💻 **Code:** [RemoveNthFromEnd.cs](./RemoveNthFromEnd.cs)

---

### 7. Palindrome Linked List
**Level:** Medium  
**Pattern:** Fast & Slow + Reverse  

**Problem:** Check if linked list is palindrome.

**Brute Force:**  
Copy to array and compare.

**Optimal Approach:**  
Reverse second half and compare.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/palindrome-linked-list/  
💻 **Code:** [PalindromeLinkedList.cs](./PalindromeLinkedList.cs)

---

### 8. Add Two Numbers
**Level:** Medium  
**Pattern:** Simulation + Carry  

**Problem:** Add two numbers represented by linked lists.

**Brute Force:**  
Convert to integers (overflow risk).

**Optimal Approach:**  
Digit-by-digit addition with carry.

**Time:** O(max(n, m))  
**Space:** O(max(n, m))

🔗 https://leetcode.com/problems/add-two-numbers/  
💻 **Code:** [AddTwoNumbers.cs](./AddTwoNumbers.cs)

---

### 9. Odd Even Linked List
**Level:** Medium  
**Pattern:** Pointer Rewiring  

**Problem:** Group nodes by odd and even positions.

**Brute Force:**  
Use separate lists.

**Optimal Approach:**  
Rewire odd and even pointers.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/odd-even-linked-list/  
💻 **Code:** [OddEvenLinkedList.cs](./OddEvenLinkedList.cs)

---

### 10. Rotate Linked List
**Level:** Medium  
**Pattern:** Circular Linked List  

**Problem:** Rotate list to the right by `k`.

**Brute Force:**  
Rotate one step at a time.

**Optimal Approach:**  
Make list circular and break at correct point.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/rotate-list/  
💻 **Code:** [RotateLinkedList.cs](./RotateLinkedList.cs)

---

### 11. Delete Node in a Linked List
**Level:** Easy  
**Pattern:** Value Copy Trick  

**Problem:** Delete a node without head reference.

**Optimal Approach:**  
Copy next node’s value and bypass it.

**Time:** O(1)  
**Space:** O(1)

🔗 https://leetcode.com/problems/delete-node-in-a-linked-list/  
💻 **Code:** [DeleteNode.cs](./DeleteNode.cs)

---

### 12. Remove Duplicates from Sorted Linked List
**Level:** Easy  
**Pattern:** Single Pointer  

**Problem:** Remove duplicates from sorted list.

**Optimal Approach:**  
Skip consecutive duplicate nodes.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/remove-duplicates-from-sorted-list/  
💻 **Code:** [RemoveDuplicatesSortedList.cs](./RemoveDuplicatesSortedList.cs)

---
### 13. Copy List with Random Pointer
**Level:** Hard  
**Pattern:** HashMap / Deep Copy  

**Problem:**  
Create a deep copy of a linked list where each node has a random pointer.

**Brute Force:**  
Use HashMap to map original nodes to cloned nodes.

**Optimal Approach:**  
Two-pass HashMap solution mapping old nodes to new nodes.

**Time:** O(n)  
**Space:** O(n)

🔗 https://leetcode.com/problems/copy-list-with-random-pointer/  
💻 **Code:** [CopyRandomList.cs](./CopyRandomList.cs)

---

### 14. Merge K Sorted Linked Lists
**Level:** Hard  
**Pattern:** K-way Merge  

**Problem:**  
Merge `k` sorted linked lists into one sorted list.

**Brute Force:**  
Repeatedly find the minimum head among all lists.

**Optimal Approach:**  
Min Heap or Divide & Conquer.

**Time:** O(N log k)  
**Space:** O(k)

🔗 https://leetcode.com/problems/merge-k-sorted-lists/  
💻 **Code:** [MergeKSortedLists.cs](./MergeKSortedLists.cs)

---

### 15. Sort a Linked List
**Level:** Hard  
**Pattern:** Merge Sort / Divide & Conquer  

**Problem:**  
Sort a linked list in ascending order.

**Brute Force:**  
Copy to array, sort, rebuild list.

**Optimal Approach:**  
Merge sort using slow/fast pointer split.

**Time:** O(n log n)  
**Space:** O(log n)

🔗 https://leetcode.com/problems/sort-list/  
💻 **Code:** [SortLinkedList.cs](./SortLinkedList.cs)

---

### 16. Flatten a Multilevel Doubly Linked List
**Level:** Medium–Hard  
**Pattern:** DFS / Recursion  

**Problem:**  
Flatten a multilevel doubly linked list into a single-level list.

**Brute Force:**  
DFS traversal using extra list.

**Optimal Approach:**  
Recursive DFS with head & tail tracking.

**Time:** O(n)  
**Space:** O(n)

🔗 https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/  
💻 **Code:** [FlattenMultilevelList.cs](./FlattenMultilevelList.cs)

---

### 17. Reverse Nodes in K-Group
**Level:** Hard  
**Pattern:** Recursion / Pointer Reversal  

**Problem:**  
Reverse nodes of a linked list in groups of size `k`.

**Brute Force:**  
Reverse sublists using extra memory.

**Optimal Approach:**  
Check k nodes → reverse k → recurse.

**Time:** O(n)  
**Space:** O(n / k)

🔗 https://leetcode.com/problems/reverse-nodes-in-k-group/  
💻 **Code:** [ReverseKGroup.cs](./ReverseKGroup.cs)

---

### 18. Reorder List
**Level:** Medium  
**Pattern:** Find Middle + Reverse + Merge  

**Problem:**  
Reorder list as L0 → Ln → L1 → Ln-1 → …

**Brute Force:**  
Use array to reorder.

**Optimal Approach:**  
Split list, reverse second half, merge alternately.

**Time:** O(n)  
**Space:** O(1)

🔗 https://leetcode.com/problems/reorder-list/  
💻 **Code:** [ReorderList.cs](./ReorderList.cs)

---

### 19. Intersection of Two Linked Lists
**Level:** Easy–Medium  
**Pattern:** Two Pointer / Pointer Switching  

**Problem:**  
Find the node where two linked lists intersect.

**Brute Force:**  
HashSet to track visited nodes.

**Optimal Approach:**  
Pointer switching to equalize path lengths.

**Time:** O(n + m)  
**Space:** O(1)

🔗 https://leetcode.com/problems/intersection-of-two-linked-lists/  
💻 **Code:** [IntersectionOfTwoLinkedLists.cs](./IntersectionOfTwoLinkedLists.cs)

---
