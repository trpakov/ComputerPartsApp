using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class VideoCard : Part
    {
        public string Chipset { get; set; }
        public string Interface { get; set; }
        public string MemoryType { get; set; }
        public int MemorySize { get; set; }

        public VideoCard(
            string manufacturer,
            string name,
            string model,
            decimal price,
            string pictureURL,
            string url,
            string chipset,
            string interf,
            string memType,
            int memSize)
            : base(manufacturer, name, model, price, pictureURL, url)
        {
            Chipset = chipset;
            Interface = interf;
            MemoryType = memType;
            MemorySize = memSize;
        }

        public override string GetPartInfo() =>
            "Видео карта в компютрите е разширителна карта, преобразуваща\nграфичния образ, съхранен в паметта на компютъра, във форма,\nподходяща за показване на монитора.";

        public override string ToStringInCSV() => $"\"VideoCard\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{Chipset}\",\"{Interface}\",\"{MemoryType}\",\"{MemorySize}\"";
    }
}
