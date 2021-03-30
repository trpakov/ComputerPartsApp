using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public class Keyboard : Part, IPeripheral
    {
        public string KeysType { get; set; }
        public string FormFactor { get; set; }
        public string Layout { get; set; }
        public string Localisation { get; set; }
        public int PollingRateHz { get; set; }
        public Dimensions Dimensions { get; set; }       
        public bool IsWireless { get; set; }
        public double WeightGrams { get; set; }
        public IO IO { get; set; }
        public Color Color { get; set; }

        public Keyboard(
            string manufacturer, 
            string name, 
            string model, 
            decimal price,
            string pictureURL,
            string url,            
            string keysType,
            string formFactor,
            string layout,
            string localisation,
            int pollingRateHz,
            Dimensions dimensions,
            bool isWireless,
            double weightGrams,
            IO io,
            Color color)
            :base(manufacturer, name, model, price, pictureURL, url)
        {
            KeysType = keysType;
            FormFactor = formFactor;
            Layout = layout;
            Localisation = localisation;
            PollingRateHz = pollingRateHz;
            Dimensions = dimensions;
            IsWireless = isWireless;
            WeightGrams = weightGrams;
            IO = io;
            Color = color;
        }

        public override string GetPartInfo() =>
            "Компютърната клавиатура е периферно устройство, създадено\nпо подобие на бутоните на пишещата машина. Клавиатурите са\nсъздадени за въвеждане на текст и отделни символи и за\nконтролиране на различни компютърни операции.";

        public override string ToStringInCSV() => $"\"Keyboard\",\"{Manufacturer}\",\"{Name}\",\"{Model}\",\"{Price}\",\"{PictureURL}\",\"{URL}\",\"{KeysType}\",\"{FormFactor}\",\"{Layout}\",\"{Localisation}\",\"{PollingRateHz}\",\"{Dimensions.WidthMM},{Dimensions.HeightMM},{Dimensions.LengthMM}\",\"{IsWireless}\",\"{WeightGrams}\",\"{(int)IO}\",\"{(int)Color}\"";
    }
}
