using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class MotherBoard : Part
    {
        public string FormFactor { get; set; }
        public string CPU_Socket { get; set; }
        public string Chipset { get; set; }
        public string MemoryType { get; set; }

        public MotherBoard(
            string manufacturer,
            string name,
            string model,
            decimal price,
            string pictureURL,
            string url,
            string form,
            string socket,
            string chipset,
            string memType)
            : base(manufacturer, name, model, price, pictureURL, url)
        {
            FormFactor = form;
            CPU_Socket = socket;
            Chipset = chipset;
            MemoryType = memType;
        }

        public override string GetPartInfo() => 
            "Дънната платка е компонент от всеобщата компютърна архитектура, който\nсвързва и синхронизира всички технически елементи на компютъра.";

        public override string ToStringInCSV() => $"\"MotherBoard\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{FormFactor}\",\"{CPU_Socket}\",\"{Chipset}\",\"{MemoryType}\"";

    }
}
