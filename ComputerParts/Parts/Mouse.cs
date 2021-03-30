using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class Mouse : Part, IPeripheral
    {
        public string Type { get; set; }
        public int DPI { get; set; }
        public int NumOfButtons { get; set; }
        public double WeightGrams { get; set; }
        public string Sensor { get; set; }
        public Dimensions Dimensions { get; set; }
        public bool IsWireless { get; set; }
        public IO IO { get; set; }
        public Color Color { get; set; }

        public Mouse(
            string manufacturer, 
            string name, 
            string model, 
            decimal price,
            string pictureURL,
            string url,
            string type,
            int dpi,
            int numOfButtons,
            double weightGrams,
            string sensor,
            Dimensions dimensions,
            bool isWireless,
            IO io,
            Color color)
            :base(manufacturer, name, model, price, pictureURL, url)
        {
            Type = type;
            DPI = dpi;
            NumOfButtons = numOfButtons;
            WeightGrams = weightGrams;
            Sensor = sensor;
            Dimensions = dimensions;
            IsWireless = isWireless;
            IO = io;
            Color = color;
        }

        public override string GetPartInfo() =>
            "Мишката е периферно устройство, използвано в персоналните компютри.\nЗадвижва се от ръката на потребителя, предавайки информация за\nдвижението си (както и тази за натиснатите бутони) на компютъра.";

        public override string ToStringInCSV() => $"\"Mouse\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{Type}\",\"{DPI}\",\"{NumOfButtons}\",\"{WeightGrams}\",\"{Sensor}\",\"{Dimensions.WidthMM},{Dimensions.HeightMM},{Dimensions.LengthMM}\",\"{IsWireless}\",\"{(int)IO}\",\"{(int)Color}\"";
    }
}
