using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;

namespace ComputerPartsLibrary
{
    [Serializable()]
    public struct Dimensions
    {
        internal int WidthMM { get; private set; }
        internal int HeightMM { get; private set; }
        internal int LengthMM { get; private set; }

        public Dimensions(int widthMM, int heightMM, int lengthMM)
        {
            WidthMM = widthMM;
            HeightMM = heightMM;
            LengthMM = lengthMM;
        }

        public static Dimensions Parse(string dimensions)
        {
            var dimArr = dimensions.Split(',');
            return new Dimensions(int.Parse(dimArr[0]), int.Parse(dimArr[1]), int.Parse(dimArr[2]));
        }

        public override string ToString() => $"{WidthMM}, {HeightMM}, {LengthMM}";
    }

    public enum IO { Input, Output, InputAndOutput }

    public enum Color {
        [DescriptionAttribute("Черен")]
        Black,

        [DescriptionAttribute("Сив")]
        Grey,

        [DescriptionAttribute("Бял")]
        White }

    // Interface, implemented by peripherals
    interface IPeripheral
    {
        bool IsWireless { get; set; }
        IO IO { get; set; }
        Dimensions Dimensions { get; set; }
        double WeightGrams { get; set; }
        Color Color { get; set; }
    }

    // Class for Debug output
    public static class DebugFile
    {
        const string DebugFileURL = "..\\..\\..\\Items\\DebugFile.txt";

        public static void StartDebbuging() => Computer.ConfigurationChange += Write;
        public static void StopDebbuging() => Computer.ConfigurationChange -= Write;

        internal static void Write(object sender, Computer.ConfigurationChangeEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(DebugFileURL, true))
            {
                if(e.IsDisposed) sw.WriteLine($"{DateTime.Now}: Computer DISPOSED");
                else if (e.StartedFromConstructor) sw.WriteLine($"{DateTime.Now}: New Computer CREATED");
                //else if(e.StartedFromResetButton) sw.WriteLine($"{DateTime.Now}: Computer (ID: {(sender as Computer).ID}) DISPOSED");
                else if(e.IsAdded) sw.WriteLine($"{DateTime.Now}: Part {e.Part.ToString()} ADDED to Computer (new ID: {(sender as Computer).ID})");
                else if(!e.IsAdded) sw.WriteLine($"{DateTime.Now}: Part {e.Part.ToString()} REMOVED from Computer (new ID: {(sender as Computer).ID})");
            }
        }

        //public static void WriteOnReset(Computer pc)
        //{
        //    using(StreamWriter sw = new StreamWriter(DebugFileURL, true))
        //    {
        //        sw.WriteLine($"{DateTime.Now}: Computer DISPOSED");
        //    }
        //}
    }

    // Part hard copy through seialization
    internal static class PartDeepCloner
    {
        internal static Part DeepClone(Part part)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, part);
                ms.Position = 0;
                return bf.Deserialize(ms) as Part;
            }
        }
    }    
}
