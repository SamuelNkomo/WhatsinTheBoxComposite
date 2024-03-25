namespace WhatsinTheBoxComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var harddrive = new Leaf("HArd Drive", 2000, 2);
            var ram = new Leaf("Ram", 1000, 2);
            var cpu = new Leaf("CPU", 6000, 1);
            var mouse = new Leaf("Mouse", 1500, 4);
            var keyboard = new Leaf("Keyboard", 1700, 4);

            Composite motherboard = new Composite("Motherboard", 5000, 1);
            Composite cabinet = new Composite("Cabinet", 2000, 1);
            Composite peripherals = new Composite("Peripherals", 0, 0);
            Composite computer = new Composite("Computer", 0, 0);

            motherboard.AddItems(ram);
            motherboard.AddItems(cpu);

            cabinet.AddItems(harddrive);
            cabinet.AddItems(motherboard);

            peripherals.AddItems(keyboard);
            peripherals.AddItems(mouse);

            computer.AddItems(cabinet);
            computer.AddItems(peripherals);

            Console.WriteLine("Total price is:"+ computer.CalculateTotalPrice());
            Console.ReadLine();


        }
    }
}
