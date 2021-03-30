using System;
using System.Diagnostics;
using System.IO;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public abstract class Part : IComparable<Part>
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string PictureURL { get; set; }
        public string URL { get; set; }
        //internal bool IsPeripheral { get; set; }
        public bool IsDiscounted { get; set; }
        
        protected Part(string manufacturer, string name, string model, decimal price, string pictureURL, string url)
        {
            Manufacturer = manufacturer;
            Name = name;
            Model = model;
            Price = price;
            PictureURL = pictureURL;
            URL = url;
            IsDiscounted = false;
        }

        public override string ToString() => Manufacturer + " " + Name + " " + Model + " | " + $"{Price:C}";
        public string ToStringNoPrice() => Manufacturer + " " + Name + " " + Model;
        public string ToStringInFile() => $"{GetType().Name,-20} | {Manufacturer,-20} | {Name,-20} | {Model,-20} | {Price,-20:C}";
        public abstract string ToStringInCSV();

        public override int GetHashCode() => ToString().GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj == null) throw new ArgumentNullException();
            return obj is Part p && Manufacturer.Equals(p.Manufacturer) && Name.Equals(p.Name) && Model.Equals(p.Model);
        }

        internal bool ApplyCoupon(string coupon)
        {
            if (IsDiscounted) throw new Exception("Item already discounted");
            if (DiscountDictionary.CouponCheck(coupon, out int discount))
            {
                Price -= Math.Round(Price * discount / 100, 2);
                return IsDiscounted = true;
            }
            //else throw new Exception("Invalid coupon code");
            else return false;
        }

        public void ViewInBrowser() => Process.Start(URL);
        public void ViewPicture() => Process.Start(Path.GetFullPath(PictureURL));

        public abstract string GetPartInfo();

        public int CompareTo(Part other)
        {
            if (other == null) throw new ArgumentNullException();
            return Price.CompareTo(other.Price);
        }
    }
}
