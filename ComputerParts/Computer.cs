using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace ComputerPartsLibrary
{
   public class Computer : IEnumerable<Part>
    {
        private List<Part> Parts { get; set; }
        public decimal Price { get; set; }
        public int ID { get; set; }
        public bool SavedToFile { get; set; }
        public int Count { get; set; }

        public Computer()
        {
            Parts = new List<Part>(11);
            Count = Parts.Count;
            ID = GetHashCode();
            SavedToFile = false;

            OnConfigurationChanged(new ConfigurationChangeEventArgs(true, false));
        }

        public Computer(List<Part> parts) : this(parts.ToArray()) { }

        public Computer(params Part[] parts)
        {
            Parts = new List<Part>(parts.Length);
            foreach (var part in parts) Parts.Add(PartDeepCloner.DeepClone(part));
            Count = Parts.Count;
            foreach (var part in Parts) Price += part.Price;
            ID = GetHashCode();
            SavedToFile = false;

            OnConfigurationChanged(new ConfigurationChangeEventArgs(true, false));
        }

        // Configuration change event
        internal static event EventHandler<ConfigurationChangeEventArgs> ConfigurationChange;

        // Configuration change event Invoker
        internal void OnConfigurationChanged(ConfigurationChangeEventArgs args) => ConfigurationChange?.Invoke(this, args);

        // Configuration change Event Arguments class
        internal class ConfigurationChangeEventArgs : EventArgs
        {
            internal bool StartedFromConstructor { get; private set; }
            //internal bool StartedFromResetButton { get; private set; }
            internal Part Part { get; private set; }
            internal bool IsAdded { get; set; }
            internal bool IsDisposed { get; set; }

            internal ConfigurationChangeEventArgs(bool startedFromConstructor, bool isDisposed)
            {
                StartedFromConstructor = startedFromConstructor;
                IsDisposed = isDisposed;
            }
            internal ConfigurationChangeEventArgs(Part part, bool isAdded) : this(false, false)
            {
                Part = part;
                IsAdded = isAdded;
            }
        }

        public void AddPart(Part part) 
        {
            // Remove part of the same type, if already exists
            if (this.Any(x => x.GetType() == part.GetType())) RemovePart(this[part.GetType()]);

            Parts.Add(PartDeepCloner.DeepClone(part));
            Price += part.Price;
            Count = Parts.Count;
            ID = GetHashCode();
            SavedToFile = false;

            OnConfigurationChanged(new ConfigurationChangeEventArgs(part, true));
        }

        public void RemovePart(Part part)
        {
            Price -= part.Price;
            Parts.Remove(part);
            Count = Parts.Count;
            ID = GetHashCode();
            SavedToFile = false;

            OnConfigurationChanged(new ConfigurationChangeEventArgs(part, false));
        }

        public void ForgetAbout() => OnConfigurationChanged(new ConfigurationChangeEventArgs(false, true));


        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var part in this) sb.AppendLine(part.ToString());
            return sb.ToString();
        }

        public override int GetHashCode() => ToString().GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj == null) throw new ArgumentNullException();
            // Check if two Computer have the same set of parts (ignoring order)
            return obj is Computer pc && new HashSet<Part>(Parts).SetEquals(pc);
        }

        // Saves current Computer to human-readable text file, showing price info
        public void SaveToReceipt(string dir)
        {
            using (StreamWriter sw = new StreamWriter(dir))
            {
                for (int i = 0; i < 100; i++) sw.Write("-");
                sw.WriteLine();
                sw.WriteLine($"{"Type",-20} | {"Manufacturer",-20} | {"Name",-20} | {"Model",-20} | {"Price",-20:C}");
                for (int i = 0; i < 100; i++) sw.Write("-");
                sw.WriteLine();

                //foreach (var part in Parts) sw.WriteLine(part.ToStringInFile());
                foreach (var part in this) sw.WriteLine(part.ToStringInFile());

                for (int i = 0; i < 100; i++) sw.Write("-");
                sw.WriteLine();

                //sw.WriteLine($"{DateTime.Today.ToLongDateString(),50} Total: {Price:C}");
                //for (int i = 0; i < 100; i++) sw.Write("-");

                if(Parts.Any(x => x.IsDiscounted))
                {
                    sw.WriteLine($"{DateTime.Now,50} Total (PROMO PRICE): {Price:C}");
                    for (int i = 0; i < 100; i++) sw.Write("-");
                }
                else
                {
                    sw.WriteLine($"{DateTime.Now,50} Total: {Price:C}");
                    for (int i = 0; i < 100; i++) sw.Write("-");
                }

            }
        }

        // IEnumerable interface implementation
        public IEnumerator<Part> GetEnumerator() => Parts.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Parts.GetEnumerator();

        // Custom indexer (part type "Name")
        public Part this[string partName]
        {
            get
            {
                foreach (var part in this) if (part.GetType().Name == partName) return part;               
                return null;
            }
        }
        // Custom indexer(part type)
        public Part this[Type partName]
        {
            get
            {
                foreach (var part in this) if (partName.Name == part.GetType().Name) return part;               
                return null;
            }
        }

        public void ReCalculatePrice()
        {
            Price = 0;
            foreach (var part in this) Price += part.Price;
        }

        // Applies coupon for each part, returns false on failure
        public bool ApplyCoupon(string coupon)
        {
            foreach (var part in this)
            {
                if (!part.ApplyCoupon(coupon)) return false;

            }
            ReCalculatePrice();
            SavedToFile = false;
            return true;
        }

        public void SortByPrice() => Parts.Sort();
    }
}
