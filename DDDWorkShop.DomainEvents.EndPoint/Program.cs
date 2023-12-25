// See https://aka.ms/new-console-template for more information


using DDDWorkShop.DomainEvents.ApplicationService;
using DDDWorkShop.DomainEvents.CoreDomain;
var personRepository = new FakePersonRepository();

foreach (var item in personRepository.GetAll())
{
    Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName} isActive: {item.IsActive}");
}

Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.ReadLine();

 PersonDeactivation personDeactivation = new PersonDeactivation(new FakePersonRepository(), new EventDispatcher());

personDeactivation.Execute(1);

foreach (var item in personRepository.GetAll())
{
    Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName} isActive: {item.IsActive}");
}

Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.ReadLine();



