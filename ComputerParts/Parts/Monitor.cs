using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class Monitor : Part, IPeripheral
    {
        public double SizeInch { get; set; }
        public string Resolution { get; set; }
        public string ScreenType { get; set; }
        public string PanelType { get; set; }
        public bool IsWireless { get; set; }
        public IO IO { get; set; }
        public Dimensions Dimensions { get; set; }
        public double WeightGrams { get; set; }
        public Color Color { get; set; }

        public Monitor(
            string manufacturer, 
            string name, 
            string model, 
            decimal price,
            string pictureURL,
            string url,
            double sizeInch,
            string resolution,
            string screenType,
            string panelType,
            bool isWireless,
            IO io,
            Dimensions dimensions,
            double weightGrams,
            Color color)
            :base(manufacturer, name, model, price, pictureURL, url)
        {
            SizeInch = sizeInch;
            Resolution = resolution;
            ScreenType = screenType;
            PanelType = panelType;
            IsWireless = isWireless;
            IO = io;
            Dimensions = dimensions;
            WeightGrams = weightGrams;
            Color = color;
        }

        public override string GetPartInfo() =>
            "Монитор (или още дисплей, екран) e устройство\nза изобразяване на информация във визуален или\nтактилен вид.";

        public override string ToStringInCSV() => $"\"Monitor\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{SizeInch}\",\"{Resolution}\",\"{ScreenType}\",\"{PanelType}\",\"{IsWireless}\",\"{(int)IO}\",\"{Dimensions.WidthMM},{Dimensions.HeightMM},{Dimensions.LengthMM}\",\"{WeightGrams}\",\"{(int)Color}\"";
    }
}
