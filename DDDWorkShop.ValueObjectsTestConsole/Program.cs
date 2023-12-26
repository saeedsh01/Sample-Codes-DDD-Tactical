// See https://aka.ms/new-console-template for more information



using DDDWorkShop.ValueObjects.Distances;
using DDDWorkShop.ValueObjects.FactoryMethodSample;
using DDDWorkShop.ValueObjects.MicroTypes;
using DDDWorkShop.ValueObjects.Moneyv1;
using System.Diagnostics.Metrics;
Console.WriteLine("--Start--");
//**//Sample Money
//Money m1 = new Money(1000);
//Money m2 = new Money(25000);
////var m3 = new Money(1000);
////var m4 = m3;
//if (m1 == m2)
//{
//    Console.WriteLine("Are Equals");
//}
//else
//{
//    Console.WriteLine("Are Not Equals");
//}

//**//Sample Distances
//Meters meters1 = new Meters(25000);
//Meters meters2 = new Meters(20000);
//var resCheck = meters1.Equals(meters2);
//var resKilometers = meters1.ToKilometers();
//var resYards = meters1.ToYards();
//var NewMeter=meters1.Add(meters2);

//**//Sample FactoryMethodSample
//FullName PersonFullName = FullName.Create("saeed", "shirvani");

//**//Sample MicroTypes
OvertimeCalculator overtimeCalculator = new OvertimeCalculator();
OvertimeHours overtimeHours = overtimeCalculator.Calculate(new HoursWorked(new Hours(290)), new ContractedHours(new Hours(160)));

Console.WriteLine("Amount = " + overtimeHours.Hours.Amount.ToString());

Console.ReadLine();

