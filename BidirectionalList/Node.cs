namespace BidirectionalList
{
    internal class Node<T>
    {
        internal T data;
        internal Node<T> previous;
        internal Node<T> next;

        public Node(T data)
        {
            this.data = data;
            previous = null;
            next = null;
        }
    }
}
