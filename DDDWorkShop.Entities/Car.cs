namespace DDDEorkShop.Entities
{

    public class CarFactory
    {
        public static int id = 0;
        public static Car CreatCar()
        {
            return new Car(++id);
        }
    }
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Car(int id)
        {
            Id = id;
        }
        public void ChangeName(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new Exception();
            }
            Name = newName;
        }
    }
}
