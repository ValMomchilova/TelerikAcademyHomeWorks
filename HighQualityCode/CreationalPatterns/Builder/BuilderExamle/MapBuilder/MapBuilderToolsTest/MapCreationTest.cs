namespace MapBuilderToolsTest
{
    using MapBuilderTools;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MapCreationTest
    {
        [TestMethod]
        public void TestDesertMapCreation()
        {
            int waterSourcesCount = 5;
            int floraCount = 20;

            MapCreator mapCreator = new MapCreator(waterSourcesCount, floraCount);
            DesertMapBuilder desertMapBuilder = new DesertMapBuilder();

            mapCreator.Create(desertMapBuilder);

            Map desertMap = desertMapBuilder.Map;

            string expectedGroundDescription = "sand";
            string desertMapGrounDescription = desertMap.Ground.Description;
            Assert.AreEqual(expectedGroundDescription, desertMapGrounDescription, "Desert map ground description is not the expected=");

            int desertMapWaterSourcesCount = desertMap.WaterSources.Count;
            Assert.AreEqual(waterSourcesCount, desertMapWaterSourcesCount, "Desert map water sources count i not the expected");

            int desertMapFloraCount = desertMap.FloraColection.Count;
            Assert.AreEqual(floraCount, desertMapFloraCount, "Desert map flora count is not the expected");
        }

        [TestMethod]
        public void TestPraerieMapCreation()
        {
            int waterSourcesCount = 6;
            int floraCount = 25;

            MapCreator mapCreator = new MapCreator(waterSourcesCount, floraCount);
            PraerieMapBuilder praerieMapBuilder = new PraerieMapBuilder();

            mapCreator.Create(praerieMapBuilder);

            Map praerieMap = praerieMapBuilder.Map;

            string expectedGroundDescription = "grass";
            string praerieMapGrounDescription = praerieMap.Ground.Description;
            Assert.AreEqual(expectedGroundDescription, praerieMapGrounDescription, "Praerie map ground description is not the expected=");

            int praerieMapWaterSourcesCount = praerieMap.WaterSources.Count;
            Assert.AreEqual(waterSourcesCount, praerieMapWaterSourcesCount, "Praerie map water sources count i not the expected");

            int praerieMapFloraCount = praerieMap.FloraColection.Count;
            Assert.AreEqual(floraCount, praerieMapFloraCount, "Praerie map flora count is not the expected");
        }
    }
}
