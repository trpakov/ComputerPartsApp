using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class Case : Part
    {
        public string FormFactor { get; set; }
        public Dimensions Dimensions { get; set; }
        public int NumOfDriveBays { get; set; }
        public int NumOfSlots { get; set; }
        public int MaxNumOfFans { get; set; }
        public bool SupportsLiquidCooling { get; set; }

        public Case(
            string manufacturer, 
            string name, 
            string model, 
            decimal price,
            string pictureURL,
            string url,
            string formFactor,
            Dimensions dimensions,
            int numOfDriveBays,
            int numOfSlots,
            int maxNumOfFans,
            bool supportsLiquidCooling)
            :base(manufacturer, name, model, price, pictureURL, url)
        {
            FormFactor = formFactor;
            Dimensions = dimensions;
            NumOfDriveBays = numOfDriveBays;
            NumOfSlots = numOfSlots;
            MaxNumOfFans = maxNumOfFans;
            SupportsLiquidCooling = supportsLiquidCooling;
        }

        public override string GetPartInfo() =>
            "Kомпютърната кутия е основна част на компютъра. В нея са\nпоместени дънната платка, твърдият диск, контролерите,\nзахранването, входно-изходните четящи устройства и голямо\nколичество кабели, свързващи отделните компоненти.";

        public override string ToStringInCSV() => $"\"Case\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{FormFactor}\",\"{Dimensions.WidthMM},{Dimensions.HeightMM},{Dimensions.LengthMM}\",\"{NumOfDriveBays}\",\"{NumOfSlots}\",\"{MaxNumOfFans}\",\"{SupportsLiquidCooling}\"";
    }
}
