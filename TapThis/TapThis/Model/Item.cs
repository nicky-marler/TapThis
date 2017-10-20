namespace TapThis.Model
{
    public class Item
    {    
        public string Name { get; set; }
        public string Price { get; set; }
        public string Type { get; set; }
        public double Start { get; set; }
        public double End { get; set; }
        public bool Bleeds { get; set; }

        public Item()
        {
            Name = "";
            Price = "";
            Type = "Drink";
            Start = 17.0;
            End = 21.0;
            Bleeds = false;
        }

    }
}
