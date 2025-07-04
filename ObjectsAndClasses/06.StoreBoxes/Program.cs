namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] arguments = commands.Split();
                string serialNum = arguments[0];
                string itemName = arguments[1];
                int quantity = int.Parse(arguments[2]);
                float itemPrice = float.Parse(arguments[3]);

                Box box = new Box();
                box.SerialNumber = serialNum;
                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                box.Quantity = quantity;

                box.Price = itemPrice * quantity;
                boxes.Add(box);
            }

            boxes = boxes.OrderByDescending(b => b.Price).ToList();
            foreach (Box box in boxes)
            {
                {
                    //{ boxSerialNumber}

                    //-- { boxItemName}
                    //- ${ boxItemPrice}: { boxItemQuantity}

                    //-- ${ boxPrice}
                    Console.WriteLine(box.SerialNumber);
                    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price}: {box.Quantity}");
                    Console.WriteLine($"-- ${box.Price}");
                }

            }
        }

        public class Item
        {
            public string Name { get; set; }
            public float Price { get; set; }
        }

        public class Box
        {
            //Serial Number, Item, Item Quantity and Price for a Box
            public Box()
            {
                Item = new Item();
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public float Price { get; set; }
        }
    }
}