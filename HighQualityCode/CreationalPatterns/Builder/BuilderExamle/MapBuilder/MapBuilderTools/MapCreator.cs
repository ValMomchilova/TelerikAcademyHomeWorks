namespace MapBuilderTools
{
    public class MapCreator
    {
        public MapCreator(int waterSourcesCount, int floraCount)
        {
            this.WaterSourcesCount = waterSourcesCount;
            this.FloraCount = floraCount; 
        }

        public int WaterSourcesCount { get; set; }

        public int FloraCount { get; set; }

        public int FaunaCount { get; set; }

        public void Create(MapBuilder mapBuilder)
        {
            mapBuilder.CreateGround();

            for (int i = 0; i < this.WaterSourcesCount; i++)
            {
                mapBuilder.CreateWaterSource();
            }

            for (int i = 0; i < this.FloraCount; i++)
            {
                mapBuilder.CreateFlora();
            }                      
        }
    }
}
