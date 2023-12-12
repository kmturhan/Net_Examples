// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Sekil
{
    protected int _en;
    protected int _boy;
    public Sekil(int boy, int en)
    {
        _en = en;
        _boy = boy;
    }
    virtual public int AlanHesapla()
    {
        return 0;
    }
}

public class Ucgen : Sekil
{
    public Ucgen(int boy, int en) : base(boy, en)
    {
        
    }
    override public int AlanHesapla()
    {
        return _boy * _en / 2;
    }
}
public class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en) : base(boy, en)
    {
        
    }
    override public int AlanHesapla()
    {
        return _boy * _en;
    }
}