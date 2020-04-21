abstract class Baseclass // абстрактний клас
{
    protected int _x = 100;
    protected int _y = 150;
    public abstract void Abstractmethod(); // абстрактний метод
    public abstract int X { get; }
    public abstract int Y { get; }
}
class Derivedclass : Baseclass
{
    public override void Abstractmethod()
    { _x++; _y++; }
    public override int X // overriding property
    {
        get { return _x + 10; }
    }
    public override int Y // перевизначена властивість
    {
        get { return _y + 10; }
    }
    static void Main()
    {
        Derivedclass o = new Derivedclass();
        o.Abstractmethod();
        Console.WriteLine("x= {0}, y = {1}", o.X, o.Y);
    }
}
// результат: x = 111, y = 161