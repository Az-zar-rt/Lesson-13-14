namespace InternetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Count infoCoconut = new Count();
            infoCoconut.Info();
            infoCoconut.Price();
            infoCoconut.Quantity();
            infoCoconut.MoreInfo();
            Console.WriteLine("\n");
            infoCoconut.Add();
            Console.WriteLine("Success!");
            NewCustomer customer = new NewCustomer();
            Console.WriteLine(customer.RegisterCustomer());
            NewProduct product = new NewProduct();
            Console.WriteLine(product.RegisterProduct());
        }
    }

    abstract class ProductInfo
    {
        public abstract void Info();
        public abstract void Price();

        public abstract void Quantity();

        public void MoreInfo()
        {
            Console.WriteLine("For more Info ask the seller");
        }
    }

    class Count : ProductInfo, IQuantity
    {
        public override void Info()
        {
            string name = "Pineapple";
            string country = "Brazil";
            Console.WriteLine($"Product name: {name} \nCountry: {country}");
        }

        public override void Price()
        {
            int netPrice = 15;
            int delivery = 5;
            int total = delivery + netPrice;
            Console.WriteLine($"Price: {total}$");
        }

        public override void Quantity()
        {
            int inStock = 2000;
            int spoiled = 500;
            int avaiable = inStock - spoiled;
            Console.WriteLine($"Avaiable on sell: {avaiable} coconuts");
        }

        public int Add()
        {
            Console.WriteLine($"Please, Add some Quantity to the item coconut");
            int addItem = int.Parse(Console.ReadLine());
            return addItem;
        }
    }

    interface INewProduct
    {
        string RegisterProduct();
    }

    interface INewCustomer
    {
        string RegisterCustomer();
    }

    interface IQuantity
    {
        int Add();
    }

    class NewCustomer : INewCustomer
    {
        public string RegisterCustomer()
        {
            Console.WriteLine("Hi, please, enter your name");
            string? name = Console.ReadLine();
            Console.WriteLine("Now, enter your surname");
            string? surname = Console.ReadLine();
            Console.WriteLine("Last step - enter your email");
            string? email = Console.ReadLine();
            Console.WriteLine($"Thank you for registration, your Info:");
            return name + surname  + email;
        }
    }

    struct NewProduct : INewProduct
    {
        public string RegisterProduct()
        {
            Console.WriteLine("Hi,please, enter item name");
            string? itemName = Console.ReadLine();
            Console.WriteLine("Now, enter Price");
            string? itemPrice = Console.ReadLine();
            Console.WriteLine("New product Info:");
            return itemName  + itemPrice;
        }
    }
}