namespace Chef
{
    using System;

    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsCut = false;
            this.IsPeeled = false;
            this.IsCooked = false;
        }

        public bool IsCut { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsRotten { get; set; }

        public bool IsCooked { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }
    }
}
