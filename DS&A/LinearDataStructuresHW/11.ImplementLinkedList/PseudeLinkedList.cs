using System;
using System.Collections.Generic;

public class PseudeLinkedList<T>
{
    private ListItem<T> head;

    public PseudeLinkedList()
    {
    }

    public void AddAtFront(T value)
    {
        this.head = new ListItem<T>(value, this.head);
    }

    public void AddAtBack(T value)
    {
        var listItem = new ListItem<T>(value);
        var current = this.head;

        if (current == null)
        {
            this.head = listItem;
        }
        else
        {
            while (current.NextItem != null)
            {
                current = current.NextItem;
            }

            current.NextItem = listItem;
        }
    }

    public ListItem<T> Front
    {
        get
        {
            return this.head;
        }
    }

    public ListItem<T> Back
    {
        get
        {
            var current = this.head;

            if (current != null)
            {
                while (current.NextItem != null)
                {
                    current = current.NextItem;
                }
            }

            return current;
        }
    }

    public ListItem<T> RemoveAtFront()
    {
        var node = this.head;

        if (node != null)
        {
            this.head = node.NextItem;
        }

        return node;
    }

    public ListItem<T> RemoveAtBack()
    {
        var current = this.head;

        if (current != null)
        {
            if (current.NextItem == null)
            {
                this.head = null;
            }
            else
            {
                ListItem<T> nextToLast = null;

                while (current.NextItem != null)
                {
                    nextToLast = current;
                    current = current.NextItem;
                }

                nextToLast.NextItem = null;
            }
        }
}

