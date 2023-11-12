/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);
        // Test Cases

        // Test 1
        // Scenario: testing items with all the scenareos
        // index with hight priority added at any position (1 and 4 index in this case)
        // items with repeated indexs returned the first added in the queue in case of duplicate priority
        // Expected Result: b e a c d
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 8);
        priorityQueue.Enqueue("c", 1);
        priorityQueue.Enqueue("d", 1);
        priorityQueue.Enqueue("e", 6);

        string itemRemoved = priorityQueue.Dequeue();
        Console.WriteLine(itemRemoved);

        itemRemoved = priorityQueue.Dequeue();
        Console.WriteLine(itemRemoved);

        itemRemoved = priorityQueue.Dequeue();
        Console.WriteLine(itemRemoved);

        itemRemoved = priorityQueue.Dequeue();
        Console.WriteLine(itemRemoved);

        itemRemoved = priorityQueue.Dequeue();
        Console.WriteLine(itemRemoved);

        // Defect(s) Found: 

        // index starts at 1 and Remove the minus 1 (-1) after the _queue.Count property
        // Added the remove after finding the index
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}