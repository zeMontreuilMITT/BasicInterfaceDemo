// See https://aka.ms/new-console-template for more information
using InterfaceDemo;

List<ISayHello> helloSayers = new List<ISayHello>()
{
    new HumanFromCanada(),
    new DuckFromCanada()
};

ISayHello helloSayer;

IMakeBreakfast breakfastMaker;


string type = "anything else";

if(type == "person")
{
    helloSayer = new HumanFromCanada(); 
} else
{
    helloSayer = new DuckFromCanada();
}

Console.WriteLine(helloSayer.SayHello());