namespace MapBuilderTools
{
    using System.Collections.Generic;
    using MapBuilderTools.MapElements;

    public class Map 
    {
        private Ground ground;

        private List<WaterSource> waterSources;

        private List<Flora> floraColection;

        public Map()
        {
            this.WaterSources = new List<WaterSource>();
            this.floraColection = new List<Flora>();
        }

        public Ground Ground
        {
            get
            {
                return this.ground;
            }

            set
            {
                this.ground = value;
            }
        }

        public List<WaterSource> WaterSources
        {
            get
            {
                return this.waterSources;
            }

            set
            {
                this.waterSources = value;
            }
        }

        public List<Flora> FloraColection
        {
            get
            {
                return this.floraColection;
            }

            set
            {
                this.floraColection = value;
            }
        }
    }
}
