using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class Speakers : Part, IPeripheral
    {
        public double Type { get; set; }
        public double TotalRMSPowerWatts { get; set; }
        public string FrequencyResponse { get; set; }
        public bool IsWireless { get; set; }
        public IO IO { get; set; }
        public Dimensions Dimensions { get; set; }
        public double WeightGrams { get; set; }
        public Color Color { get; set; }

        public Speakers(
            string manufacturer,
            string name,
            string model,
            decimal price,
            string pictureURL,
            string url,
            double type,
            double totalPowerWatts,
            string freqResponse,
            bool isWireless,
            IO io,
            Dimensions dimensions,
            double weightGrams,
            Color color)
            : base(manufacturer, name, model, price, pictureURL, url)
        {
            Type = type;
            TotalRMSPowerWatts = totalPowerWatts;
            FrequencyResponse = freqResponse;
            IsWireless = isWireless;
            IO = io;
            Dimensions = dimensions;
            WeightGrams = weightGrams;
            Color = color;
        }

        public override string GetPartInfo() =>
            "Компютърните тонколони са изходни периферни\nустройства при компютрите, с чиято помощ се\nвъзпроизвежда звук, доловим от човешкото ухо.";

        public override string ToStringInCSV() => $"\"Speakers\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{Type}\",\"{TotalRMSPowerWatts}\",\"{FrequencyResponse}\",\"{IsWireless}\",\"{(int)IO}\",\"{Dimensions.WidthMM},{Dimensions.HeightMM},{Dimensions.LengthMM}\",\"{WeightGrams}\",\"{(int)Color}\"";
    }
}
