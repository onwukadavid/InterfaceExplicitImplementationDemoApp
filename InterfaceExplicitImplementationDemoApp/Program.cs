using System;

interface IA1
{
    void Foo1();
    void Foo2();
}

interface IA2
{
    void Foo2();
    void Foo3();
}

class CA: IA1,IA2
{
    public void Foo1()
    {  }
  public  void Foo2()
    {
        Console.WriteLine("IN FOO2 OF CA ");
    }
    void IA2.Foo2()
    {
        Console.WriteLine("IN FOO2 OF CA FOR IA2");
    }
    public void Foo3()
    {  }
}


class program
{
    static void Main(string[] args)
    {
        IA1 a1; IA2 a2; CA a;
        a1 = new CA();
        a2 = new CA();
        a = new CA();
        a1.Foo2();
        a2.Foo2();
       a.Foo2();
    }
}