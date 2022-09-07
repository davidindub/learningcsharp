using OOPExamples;
using System;

class Program
{
    static void Main(string[] args)
    {

        var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower);
        
        Console.WriteLine("Computer Type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is computer - " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);
        Console.WriteLine("Computer case - " + comp.caseType);

        comp.TogglePower();
        Console.WriteLine("Computer is on - " + comp.isOn);

        comp.ToggleSleep();
        Console.WriteLine("Computer is sleeping - " + comp.isSleeping);

        comp.TogglePower();
        Console.WriteLine("Computer is on - " + comp.isOn);

        Console.Read();

    }
}

