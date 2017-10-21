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

        public Item(string name, string price, string type, double start, double end, bool bleeds)
        {
            Name = name;
            Price = price;
            Type = type;
            Start = start;
            End = end;
            Bleeds = bleeds;
        }

    }
}
