public class Employee
{
    private string name;
    private int id;
    public Employee(string s, int i)
    { name = s; id = i; }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
}
public class Genericlist<T> where T : Employee
{
    private class Node
    {
        private Node next;
        private T data;
        public Node(T t)
        { next = null; data = t; }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }
    private Node head;
    public Genericlist() // конструктор
    { head = null; }
    public void Addhead(T t)
    {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }
    public Ienumerator<T> Getenumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
    public T Findfirstoccurrence(string s)
    {
        Node current = head;
        T t = null;
        while (current != null)
        {
            // обмеження надає доступ до властивості Name
            if (current.Data.Name == s)
            { t = current.Data; break; }
            else
            { current = current.Next; }
        }
        return t;
    }
}