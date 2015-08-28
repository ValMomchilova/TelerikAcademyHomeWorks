namespace Chef
{
    using System;

    public class ChefMain
    {
        public static void Main()
        {
            //01. Task
            Chef chef = new Chef();
            chef.Cook();

            //02. Task
            Potato potato;

            potato = new Potato();

            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    chef.Cook(potato);
                }
            }
        }
    }
}
