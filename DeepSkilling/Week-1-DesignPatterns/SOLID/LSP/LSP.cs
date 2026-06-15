using System;

class Bird
{
    public virtual void Move()
    {
        Console.WriteLine("Bird is moving");
    }
}

class Sparrow : Bird
{
    public override void Move()
    {
        Console.WriteLine("Sparrow is flying");
    }
}

class Penguin : Bird
{
    public override void Move()
    {
        Console.WriteLine("Penguin is swimming");
    }
}

class LSP
{
    static void Main()
    {
        Bird bird1 = new Sparrow();
        Bird bird2 = new Penguin();

        bird1.Move();
        bird2.Move();
    }
}
