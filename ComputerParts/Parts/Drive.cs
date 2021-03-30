using System;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public abstract class Drive : Part
    {
        public int CapacityGB { get; set; }
        public string Interface { get; set; }
        //internal int CacheMB { get; set; }
        public double FormFactorInch { get; set; }
        public bool IsPortable { get; set; }

        protected const double SizeDifference = 1.073741824;

        protected Drive(
            string manufacturer, 
            string name, 
            string model, 
            decimal price,
            string pictureURL,
            string url,
            int capacityGB,
            string interf,
            //int cacheMB,
            double formFactorInch)
            :base(manufacturer, name, model, price, pictureURL, url)
        {
            CapacityGB = capacityGB;
            Interface = interf;
            //CacheMB = cacheMB;
            FormFactorInch = formFactorInch;
        }

        internal double GetActualCapacityGB() => Math.Round((double)CapacityGB / SizeDifference, 2);
    }
}
