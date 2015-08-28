namespace Chef
{
    using System;
    using System.Collections.Generic;

    internal class Bowl
    {
        public Bowl()
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
