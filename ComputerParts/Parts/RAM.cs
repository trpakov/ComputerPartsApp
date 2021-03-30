using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class RAM : Part
    {
        public int CapacityGB { get; set; }
        public string Type { get; set; }
        public int SpeedMHz { get; set; }

        public RAM(
            string manufacturer,
            string name,
            string model,
            decimal price,
            string pictureURL,
            string url,
            int capacityGB,
            string type,
            int speedMHz)
            : base(manufacturer, name, model, price, pictureURL, url)
        {
            CapacityGB = capacityGB;
            Type = type;
            SpeedMHz = speedMHz;
        }

        public override string GetPartInfo() =>
            "Паметта с произволен достъп (RAM) е вид компютърна памет,\nкоято позволява неограничен достъп до произволна част от\nзапаметените данни. Има относително голяма скорост.\nНамира широко приложение в изчислителната техника.";

        public override string ToStringInCSV() => $"\"RAM\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{CapacityGB}\",\"{Type}\",\"{SpeedMHz}\"";
    }
}
