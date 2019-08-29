Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

Bonus: Can you do this in one pass?

Starting off the problem, we know that we need to either have two pointers on the array to add and compare with k
	This approach requires that the first pointer would tart at the beginning of the array while the other pointer traverses the array to see if any other number adds up to k
	Time Complexity: O(n^2)

Another approach would be to use a HashSet and the Contains method which is in O(1) time
	Input each integer into the HashSet and check the HashSet each time to see if the current number added with HashSet.Contains equals k
	Add the current number to the HashSet
	output the sets of numbers that add up to k
	Time Complexity: O(n)