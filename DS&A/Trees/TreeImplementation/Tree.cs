namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;

    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T rootValue)
        {
            if (rootValue == null)
            {
                throw new ArgumentNullException("The root cant be null");
            }

            this.root = new TreeNode<T>(rootValue);
        }

        public Tree(T rootValue, params Tree<T>[] children)
            : this(rootValue)
        {
            foreach (var child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public void PrintDfsRecursive(TreeNode<T> root)
        {            
            foreach (var child in root.Children)
            {
                PrintDfsRecursive(child);
            }

            Console.Write(root.Value + " ");
        }

        public void TraverseBFS()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.root);
            while (queue.Count > 0)
            {
                TreeNode<T> currentNode = queue.Dequeue();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    queue.Enqueue(childNode);
                }
            }
        }

        public void TraverseDFSWithStack()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                TreeNode<T> currentNode = stack.Pop();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    TreeNode<T> childNode = currentNode.GetChild(i);
                    stack.Push(childNode);
                }
            }
        }
    }
}
