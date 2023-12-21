using DecoratorDesignPattern.Assets;
using DecoratorDesignPattern.Decorator;

Console.WriteLine("***Decorator pattern Demo***\n");

ConcreteComponent cc = new ConcreteComponent();

ConcreteDecoratorEx1 decorator1 = new ConcreteDecoratorEx1();
decorator1.SetTheComponent(cc);
decorator1.MakeHouse();

ConcreteDecoratorEx2 decorator2 = new ConcreteDecoratorEx2();
//Adding results from decorator1
decorator2.SetTheComponent(decorator1);
decorator2.MakeHouse();

Console.ReadKey();
