namespace MapBuilderTools
{
    using MapBuilderTools.MapElements;

    public class PraerieMapBuilder : MapBuilder 
    {
        public override void CreateWaterSource()
        {
            this.Map.WaterSources.Add(new River());
        }

        public override void CreateGround()
        {
            this.Map.Ground = new GrassGround();
        }

        public override void CreateFlora()
        {
            this.Map.FloraColection.Add(new Tree());
        }
    }
}
