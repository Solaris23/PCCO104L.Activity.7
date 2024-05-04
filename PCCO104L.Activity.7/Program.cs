namespace PCCO104L.Activity._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car carFerrari = new Car(80.71, "Ferrari", 80000, "Italy", "Gasoline", 70000);
            carFerrari.globalRating();
            carFerrari.StartEngine();

            Car carAudi = new Car(45.23, "Audi", 50000, "Germany", "Gasoline", 50000);
            carAudi.globalRating();
            carAudi.TurnOnHeadlights();

            Car carHonda = new Car(25.27, "Honda", 25000, "Japan", "Gasoline", 65000);
            carHonda.globalRating();

            Car carNissan = new Car(26.64, "Nissan", 28000, "Japan", "Gasoline", 32000);
            carNissan.globalRating();

            Car carPorsche = new Car(81.25, "Porsche", 85000, "Germany", "Gasoline", 41000);
            carPorsche.globalRating();

            Car carCadillac = new Car(66.65, "Cadillac", 65000, "USA", "Gasoline", 38000);
            carCadillac.globalRating();
        }
    }

    public class Car
    {
        public string Brand { get; set; }

        private double _Rating { get; set; }

        private int _Price { get; set; }

        public string Country { get; set; }

        public string FuelType { get; set; }

        private int _Mileage { get; set; }

        public Car() { }

        public Car(double rating)
        {
            _Rating = rating;
        }

        public Car(int price)
        {
            _Price = price;
        }

        public Car(double rating, string brand, int price, string country, string fuelType, int mileage)
        {
            _Rating = rating;
            Brand = brand;
            _Price = price;
            Country = country;
            FuelType = fuelType;
            _Mileage = mileage;
        }

        public void globalRating()
        {
            Console.WriteLine($"{Brand} - Rating: {_Rating} - Price: {_Price} - Country: {Country} - Fuel Type: {FuelType} - Mileage: {_Mileage}");

        }

        public void StartEngine()
        {
            Console.WriteLine($"{Brand} engine started.");
        }

        public void TurnOnHeadlights()
        {
            Console.WriteLine($"{Brand} headlights turned on.");

        }
    }
}
