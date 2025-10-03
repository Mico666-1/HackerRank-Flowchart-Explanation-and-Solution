using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

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

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep) {
        while (node != null) {
            Console.Write(node.data);

            node = node.next;

            if (node != null) {
                Console.Write(sep);
            }
        }
    }

    class Result
    {
        /*
         * Complete the 'reversePrint' function below.
         *
         * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
         */
        public static void reversePrint(SinglyLinkedListNode llist)
        {
            if (llist == null)
            {
                return; // base case: end of list
            }

            reversePrint(llist.next); // recursive call
            Console.WriteLine(llist.data); // print after recursion (reverse order)
        }
    }

    static void Main(string[] args) {
        int tests = Convert.ToInt32(Console.ReadLine());

        for (int testsItr = 0; testsItr < tests; testsItr++) {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++) {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            Result.reversePrint(llist.head);
        }
    }
}
