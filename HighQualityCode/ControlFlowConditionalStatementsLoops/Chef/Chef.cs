namespace Chef
{
    using System;
    using System.Collections.Generic;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            potato.Peel();
            potato.Cut();

            Carrot carrot = this.GetCarrot();
            carrot.Peel();
            carrot.Cut();

            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        public Dish Cook(Vegetable vegetable)
        {
            Dish dish = new Dish();
            dish.Add(vegetable);

            return dish;
        }

        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();

            return bowl;
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();

            return carrot;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();

            return potato;
        }
    }
}
