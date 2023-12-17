// See https://aka.ms/new-console-template for more information
using DDDEorkShop.Entities.SideEffect_CQRS;
using DDDEorkShop.Entities.Valiations;

Console.WriteLine("Hello, World!");

//FlightBooking flightBooking = new FlightBooking(new Guid(), DateTime.Now.AddDays(1), new Guid());
//flightBooking.Reschedule(DateTime.UtcNow.AddDays(2));Console.WriteLine("Done");

//flightBooking.Confirm();
//flightBooking.Reschedule(DateTime.UtcNow.AddDays(3));
//Console.WriteLine("Done");

Dice dice= new Dice();
dice.Roll();
Console.WriteLine(dice.Value());
Console.WriteLine(dice.Value());
dice.Roll();
Console.WriteLine(dice.Value());
Console.WriteLine(dice.Value());


Console.ReadLine();