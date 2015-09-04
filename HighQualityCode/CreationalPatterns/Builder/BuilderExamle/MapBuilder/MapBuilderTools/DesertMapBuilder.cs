namespace MapBuilderTools
{
    using MapBuilderTools.MapElements;

    public class DesertMapBuilder : MapBuilder 
    {
        public override void CreateWaterSource()
        {
            this.Map.WaterSources.Add(new Well());
        }

        public override void CreateGround()
        {
            this.Map.Ground = new SandGround();
        }

        public override void CreateFlora()
        {
            this.Map.FloraColection.Add(new Cactus());
        }
    }
}
