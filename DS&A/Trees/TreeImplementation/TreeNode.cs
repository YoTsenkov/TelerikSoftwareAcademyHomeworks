namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        private T value;
        private IList<TreeNode<T>> children;
        private TreeNode<T> parent;
        private bool hasParent;

        public TreeNode(T value)
        {
            this.Value = value;
            this.children = new List<TreeNode<T>>();            
        }

        public TreeNode(T value, bool hasParent)
            : this(value)
        {
            this.hasParent = hasParent;
        }

        public TreeNode<T> Parent
        {
            get
            {
                return this.parent;                
            }
            set
            {
                this.parent = value;
            }
        }

        public bool HasParent
        {
            get
            {
                return this.hasParent;
            }
            set
            {
                this.hasParent = value;
            }
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Node value cant be null");
                }

                this.value = value;
            }
        }

        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cant insert null value");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public IList<TreeNode<T>> Children
        {
            get
            {
                return this.children;
            }
        }
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}
