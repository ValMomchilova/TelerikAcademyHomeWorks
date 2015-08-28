namespace Chef
{
    using System;
    using System.Collections.Generic;

    public class Dish
    {
        public Dish()
        {
            this.Vegetables = new List<Vegetable>();
        }

        public List<Vegetable> Vegetables { get; set; }

        public void Add(Vegetable vegetable)
        {
            this.Vegetables.Add(vegetable);
        }
    }
}
