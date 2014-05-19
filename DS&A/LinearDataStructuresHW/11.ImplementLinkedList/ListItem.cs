using System;
using System.Collections.Generic;
using System.Linq;

public class ListItem<T>
{
    private T value;
    private ListItem<T> nextItem;

    public ListItem(T value)
    {
        this.value = value;
    }
    public ListItem(T value, ListItem<T> nextItem)
        : this(value)
    {       
        this.nextItem = nextItem;
    }

    public T Value
    {
        get
        {
            return this.value;
        }
    }

    public ListItem<T> NextItem
    {
        get
        {
            return this.nextItem;
        }

        set
        {
            this.nextItem = value;
        }
    }
}

