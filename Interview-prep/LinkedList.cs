using System;

//Singly linked list
internal class Node
{
    internal int data;
    internal Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }    
}

//Doubly linked list
internal class DNode(){

    internal int data;
    internal DNode prev;
    internal DNode next
    public DNode(int d)
    {
        data = d;
        next = null;
        prev = null;
    }
}