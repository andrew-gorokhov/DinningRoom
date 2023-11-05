namespace DinningRoom
{
    public class Dishes
    {
        public string Nameless {  get; set; }
        public string Description { get; set; }
        public string Structure { get; set; }
        public int Count { get; set; }
        
    }
    public class Drink : Dishes
    {
        public Drink(string nameless, string description, string structure, int count) : base() 
        { 
            Nameless = nameless; 
            Description = description; 
            Structure = structure; 
            Count = count; 
        }       

    }
    public class Soup : Dishes
    {
        public Soup(string nameless, string description, string structure, int count) : base()
        {
            Nameless = nameless;
            Description = description;
            Structure = structure;
            Count = count;
        }
    }
    public class Dessert : Dishes
    {
        public Dessert(string nameless, string description, string structure, int count) : base()
        {
            Nameless = nameless;
            Description = description;
            Structure = structure;
            Count = count;
        }
    }
    public class Sauce : Dishes
    {
        public Sauce(string nameless, string description, string structure, int count) : base()
        {
            Nameless = nameless;
            Description = description;
            Structure = structure;
            Count = count;
        }
    }
    public class Snack : Dishes
    {
        public Snack(string nameless, string description, string structure, int count) : base()
        {
            Nameless = nameless;
            Description = description;
            Structure = structure;
            Count = count;
        }
    }

}