abstract class Baseclass 
{
    protected int _x = 100;
    protected int _y = 150;
    public abstract void Abstractmethod(); 
    public abstract int X { get; }
    public abstract int Y { get; }
}
class Derivedclass : Baseclass
{
    public override void Abstractmethod()
    { _x++; _y++; }
    public override int X 
    {
        get { return _x + 10; }
    }
    public override int Y 
    {
        get { return _y + 10; }
    }
    static void Main()
    {
        Derivedclass o = new Derivedclass();
        o.Abstractmethod();
        console.WriteLine("x= {0}, y = {1}", o.X, o.Y);
    }
}
