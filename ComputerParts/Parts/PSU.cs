using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class PSU : Part
    {
        public int PowerW { get; set; }
        public Dimensions Dimensions { get; set; }
        public string FormFactor { get; set; }
        public int EffectivnesPercent { get; set; }
        public int FanSizeMM { get; set; }

        public PSU(
            string manufacturer,
            string name,
            string model,
            decimal price,
            string pictureURL,
            string url,
            int powerW,
            Dimensions dimensions,
            string formFactor,
            int effectivnessPercent,
            int fanSizeMM)
            :base(manufacturer, name, model, price, pictureURL, url)
        {
            PowerW = powerW;
            Dimensions = dimensions;
            FormFactor = formFactor;
            EffectivnesPercent = effectivnessPercent;
            FanSizeMM = fanSizeMM;
        }

        public override string GetPartInfo() =>
            "Компютърното захранване е техническо средство, което доставя\nнеобходимото захранване за работата на останалите компютърни\nкомпоненти. То преобразува високото мрежово напрежение и\nпроменливият ток към постоянен ток с ниско напрежение за\nползване от електронните елементи на компютъра.";

        public override string ToStringInCSV() => $"\"PSU\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{PowerW}\",\"{Dimensions.WidthMM},{Dimensions.HeightMM},{Dimensions.LengthMM}\",\"{FormFactor}\",\"{EffectivnesPercent}\",\"{FanSizeMM}\"";
    }
}
