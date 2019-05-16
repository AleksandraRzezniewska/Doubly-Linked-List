namespace BidirectionalList
{
    internal class DoubleLinkedList<T>
    {
        internal Node<T> head;

        public void InsertFront(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;

                return;
            }

            node.next = head;
            head.previous = node;
            head = node;
        }

        public void InsertEnd(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;

                return;
            }

            Node<T> previousNode = GetPreviousNode();
            previousNode.next = node;
            node.previous = previousNode;
        }

        public Node<T> GetPreviousNode()
        {
            Node<T> node = head;

            while (node.next != null)
            {
                node = node.next;
            }

            return node;
        }

        public void InsertAfter(Node<T> prevNode, T data)
        {
            if (prevNode == null)
            {
                System.Console.WriteLine("Previous node is null");
                return;
            }

            Node<T> node = new Node<T>(data);
            node.next = prevNode.next;
            prevNode.next = node;
            node.previous = prevNode;
        }

        public void PrintList()
        {
            Node<T> node = head;

            while (node != null)
            {
                System.Console.Write(node.data);
                node = node.next;
            }
        }
    }
}
