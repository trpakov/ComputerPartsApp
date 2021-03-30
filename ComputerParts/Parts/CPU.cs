using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class CPU : Part
    {
        public double FrequencyGHz { get; set; }
        public string Architecture { get; set; }
        public int NumOfCores { get; set; }
        public string Segment { get; set; }
        public string Technology { get; set; }
        public int CacheMB { get; set; }

        public CPU(
            string manufacturer, 
            string name, 
            string model, 
            decimal price,
            string pictureURL,
            string url,
            double freqGHz,
            string arch,
            int cores,
            string segment,
            string technology,
            int cacheMB) 
            : base(manufacturer, name, model, price, pictureURL, url)
        {
            FrequencyGHz = freqGHz;
            Architecture = arch;
            NumOfCores = cores;
            Segment = segment;
            Technology = technology;
            CacheMB = cacheMB;
        }

        public override string GetPartInfo() => "Процесорът е електронна схема, предназначена да извършва\nаритметически и логически действия/операции върху данни,\n„подадени“ му от външен източник – обикновено памет. ";
        public override string ToStringInCSV() => $"\"CPU\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{FrequencyGHz}\",\"{Architecture}\",\"{NumOfCores}\",\"{Segment}\",\"{Technology}\",\"{CacheMB}\"";
    }
}
