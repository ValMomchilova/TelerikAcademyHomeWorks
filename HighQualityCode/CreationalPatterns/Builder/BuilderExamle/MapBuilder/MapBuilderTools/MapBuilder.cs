namespace MapBuilderTools
{
    public abstract class MapBuilder
    {
        public MapBuilder()
        {
            this.Map = new Map();
        }

        public Map Map { get; set;  }

        public abstract void CreateWaterSource();

        public abstract void CreateGround();

        public abstract void CreateFlora();
    }
}
