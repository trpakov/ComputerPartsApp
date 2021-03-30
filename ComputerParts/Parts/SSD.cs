using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class SSD : Drive
    {
        public string Controller { get; set; }
        public int MaxReadMBs { get; set; }
        public int MaxWriteMBs { get; set; }

        public SSD(
            string manufacturer,
            string name,
            string model,
            decimal price,
            string pictureURL,
            string url,
            int capacityGB,
            string interf,
            string controller,
            double formFactorInch,
            bool isPortable,
            int maxReadMBs,
            int maxWriteMBs)
            : base(manufacturer, name, model, price, pictureURL, url, capacityGB, interf, formFactorInch)
        {
            IsPortable = isPortable;
            Controller = controller;
            MaxReadMBs = maxReadMBs;
            MaxWriteMBs = maxWriteMBs;
        }

        public override string GetPartInfo() =>
            "Полупроводниково (статично) дисково устройство (SSD) е енергонезависима компютърна\nпамет. За разлика от традиционните твърди дискове, статичните не съдържат подвижни\nмеханични части и това елиминира закъснението при четене и повишава значително\nскоростите на работа. ";

        public override string ToStringInCSV() => $"\"SSD\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{CapacityGB}\",\"{Interface}\",\"{Controller}\",\"{FormFactorInch}\",\"{IsPortable}\",\"{MaxReadMBs}\",\"{MaxWriteMBs}\"";
    }
}
