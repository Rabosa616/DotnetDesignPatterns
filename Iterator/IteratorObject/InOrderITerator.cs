namespace Iterator.IteratorObject;

public class InOrderITerator<T>
{
    private readonly Node<T> root;
    private bool yieldedStart;
    public Node<T> Current;

    public InOrderITerator(Node<T> root)
    {
        this.root = root;
        Current = root;

        while (Current.Left != null)
        {
            Current = Current.Left;
        }

        //    1 <- root
        //   / \
        //  2   3
        //  ^ Current
    }

    public bool MoveNext()
    {
        if (!yieldedStart) // First element
        {
            yieldedStart = true;
            return true;
        }

        if (Current.Right != null)
        {
            Current = Current.Right;
            while (Current.Left != null)
            {
                Current = Current.Left;
            }

            return true;
        }
        else
        {
            var p = Current.Parent;
            while (p != null && Current == p.Right)
            {
                Current = p;
                p = p.Parent;
            }
            return Current != null;
        }
    }

    public void Reset()
    {
        Current = root;
        yieldedStart = false;
    }
}