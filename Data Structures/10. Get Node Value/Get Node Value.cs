using System;
using System.Collections.Generic;
using System.IO;

class Solution {

    class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter) {
        while (node != null) {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null) {
                textWriter.Write(sep);
            }
        }
    }

    class Result
    {
        public static int getNode(SinglyLinkedListNode llist, int positionFromTail)
        {
            // Step 1: Calculate the length of the list
            int length = 0;
            SinglyLinkedListNode temp = llist;
            while(temp != null) {
                length++;
                temp = temp.next;
            }

            // Step 2: Calculate the position from head
            int positionFromHead = length - 1 - positionFromTail;

            // Step 3: Traverse to that node
            temp = llist;
            for(int i = 0; i < positionFromHead; i++) {
                temp = temp.next;
            }

            return temp.data;
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int tests = Convert.ToInt32(Console.ReadLine());

        for (int testsItr = 0; testsItr < tests; testsItr++) {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++) {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int position = Convert.ToInt32(Console.ReadLine());

            int result = Result.getNode(llist.head, position);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
