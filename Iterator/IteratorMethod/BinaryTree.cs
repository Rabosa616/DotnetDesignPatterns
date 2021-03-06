using System.Collections.Generic;

namespace Iterator.IteratorMethod;

public class BinaryTree<T>
{
    private readonly Node<T> root;

    public BinaryTree(Node<T> root)
    {
        this.root = root;
    }

    public IEnumerable<Node<T>> InOrder
    {
        get
        {
            foreach (var node in Traverse(root))
            {
                yield return node;
            }
        }
    }

    private IEnumerable<Node<T>> Traverse(Node<T> current)
    {
        if (current.Left != null)
        {
            foreach (var left in Traverse(current.Left))
            {
                yield return left;
            }
        }

        yield return current;

        if (current.Right != null)
        {
            foreach (var right in Traverse(current.Right))
            {
                yield return right;
            }
        }
    }
}