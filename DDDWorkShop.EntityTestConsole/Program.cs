// See https://aka.ms/new-console-template for more information
<<<<<<< HEAD
using DDDEorkShop.Entities.SideEffect_CQRS;
=======
>>>>>>> fd059b9438861a59ad3c62f08a7fa4215e5f5f9f
using DDDEorkShop.Entities.Valiations;

Console.WriteLine("Hello, World!");

<<<<<<< HEAD
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

=======
FlightBooking flightBooking = new FlightBooking(new Guid(), DateTime.Now.AddDays(1), new Guid());
flightBooking.Reschedule(DateTime.UtcNow.AddDays(2));Console.WriteLine("Done");

flightBooking.Confirm();
flightBooking.Reschedule(DateTime.UtcNow.AddDays(3));
Console.WriteLine("Done");
>>>>>>> fd059b9438861a59ad3c62f08a7fa4215e5f5f9f

Console.ReadLine();