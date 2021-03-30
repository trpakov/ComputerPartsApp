using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class HDD : Drive
    {
        public int RPM { get; set; }
        public int MaxTransferRateGBs { get; set; }
        public int CacheMB { get; set; }

        public HDD(
            string manufacturer, 
            string name, 
            string model, 
            decimal price,
            string pictureURL,
            string url,
            int capacityGB,
            string interf,
            int cacheMB,
            double formFactorInch,
            int rpm,
            int maxTransfRateGBs,
            bool isPortable)
            :base(manufacturer, name, model, price, pictureURL, url, capacityGB, interf, formFactorInch)
        {
            IsPortable = isPortable;
            CacheMB = cacheMB;
            RPM = rpm;
            MaxTransferRateGBs = maxTransfRateGBs;
        }

        public override string GetPartInfo() =>
            "Твърдият диск, наричан още хард диск, е запаметяващо устройство\nот енергонезависим тип. Информацията се съхранява чрез магнитен\nзапис върху покрити със специален слой плочи.";

        public override string ToStringInCSV() => $"\"HDD\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{CapacityGB}\",\"{Interface}\",\"{CacheMB}\",\"{FormFactorInch}\",\"{RPM}\",\"{MaxTransferRateGBs}\",\"{IsPortable}\"";
    }
}
