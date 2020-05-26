
using System;
delegate void MyEventHandler();
class MyEvent
{
    public event MyEventHandler SomeEvent;
    public void OnSomeEvent()
    { if (SomeEvent != null) SomeEvent(); }
}
class X
{
    int id;
    public X(int x) { id = x; }
    public void Xhandler()
    { Console.WriteLine("Подію отримано об'єктом " + id); }
}
class EventDemo3
{
    static void Main()
    {
        MyEvent evt = new MyEvent();
        X o1 = new X(1);
        X o2 = new X(2);
        X o3 = new X(3);
        evt.SomeEvent += o1.Xhandler;
        evt.SomeEvent += o2.Xhandler;
        evt.SomeEvent += o3.Xhandler;
        evt.OnSomeEvent();
        Console.ReadLine();
    }
}