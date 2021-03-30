using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using ComputerPartsLibrary;
using System.Linq;

namespace ComputerPartsApp
{
    public static class Items
    {
        const string ItemsSource = @"..\..\..\Items\Items.csv";
        public static List<Part> AllParts { get; private set; } = new List<Part>();
        public static List<Part> LoadedComputer { get; set; } = new List<Part>();
        public static List<Part> AddedPart { get; set; } = new List<Part>();
        public static Part AddedPartGUI { get; set; }

        public static void LoadItems() => Load(ItemsSource, AllParts);
        public static void LoadComputer(string computerSource) => Load(computerSource, LoadedComputer);

        public static void LoadPartGUI(StringReader partAsCSV)
        {
            Load(null, AddedPart, partAsCSV);
            AllParts.AddRange(AddedPart);
        }
        
        // Load Items from CSV file or text using TextFieldParser
        private static void Load(string source, List<Part> list, StringReader sr = null)
        {
            dynamic tfpSource;
            if (sr != null) tfpSource = sr;
            else tfpSource = source;

            using (TextFieldParser tfp = new TextFieldParser(tfpSource))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");
                list.Clear();

                while (!tfp.EndOfData)
                {
                    var currentItem = tfp.ReadFields();
                    Part currentItemObject = null;

                    // Transform current CSV line to Part
                    switch (currentItem[0])
                    {
                        case "CPU":
                            currentItemObject = new CPU(
                                currentItem[1], 
                                currentItem[2], 
                                currentItem[3], 
                                decimal.Parse(currentItem[4]), 
                                currentItem[5], 
                                currentItem[6], 
                                double.Parse(currentItem[7]), 
                                currentItem[8], 
                                int.Parse(currentItem[9]), 
                                currentItem[10], 
                                currentItem[11], 
                                int.Parse(currentItem[12]));
                            list.Add(currentItemObject);                          
                            break;
                        case "MotherBoard":
                            currentItemObject = new MotherBoard(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                currentItem[7],
                                currentItem[8],
                                currentItem[9],
                                currentItem[10]);
                            list.Add(currentItemObject);
                            break;
                        case "RAM":
                            currentItemObject = new RAM(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                int.Parse(currentItem[7]),
                                currentItem[8],
                                int.Parse(currentItem[9]));
                            list.Add(currentItemObject);
                            break;
                        case "VideoCard":
                            currentItemObject = new VideoCard(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                currentItem[7],
                                currentItem[8],
                                currentItem[9],
                                int.Parse(currentItem[10]));
                            list.Add(currentItemObject);
                            break;
                        case "PSU":
                            currentItemObject = new PSU(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                int.Parse(currentItem[7]),
                                Dimensions.Parse(currentItem[8]),
                                currentItem[9],
                                int.Parse(currentItem[10]),
                                int.Parse(currentItem[11]));
                            list.Add(currentItemObject);
                            break;
                        case "SSD":
                            currentItemObject = new SSD(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                int.Parse(currentItem[7]),
                                currentItem[8],
                                currentItem[9],
                                double.Parse(currentItem[10]),
                                bool.Parse(currentItem[11]),
                                int.Parse(currentItem[12]),
                                int.Parse(currentItem[13]));
                            list.Add(currentItemObject);
                            break;
                        case "HDD":
                            currentItemObject = new HDD(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                int.Parse(currentItem[7]),
                                currentItem[8],
                                int.Parse(currentItem[9]),
                                double.Parse(currentItem[10]),
                                int.Parse(currentItem[11]),
                                int.Parse(currentItem[12]),
                                bool.Parse(currentItem[13]));
                            list.Add(currentItemObject);
                            break;
                        case "Case":
                            currentItemObject = new Case(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                currentItem[7],
                                Dimensions.Parse(currentItem[8]),
                                int.Parse(currentItem[9]),
                                int.Parse(currentItem[10]),
                                int.Parse(currentItem[11]),
                                bool.Parse(currentItem[12]));
                            list.Add(currentItemObject);
                            break;
                        case "Monitor":
                            currentItemObject = new Monitor(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                double.Parse(currentItem[7]),
                                currentItem[8],
                                currentItem[9],
                                currentItem[10],
                                bool.Parse(currentItem[11]),
                                (IO)int.Parse(currentItem[12]),
                                Dimensions.Parse(currentItem[13]),
                                double.Parse(currentItem[14]),
                                (Color)int.Parse(currentItem[15]));
                            list.Add(currentItemObject);
                            break;
                        case "Mouse":
                            currentItemObject = new Mouse(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                currentItem[7],
                                int.Parse(currentItem[8]),
                                int.Parse(currentItem[9]),
                                double.Parse(currentItem[10]),
                                currentItem[11],
                                Dimensions.Parse(currentItem[12]),
                                bool.Parse(currentItem[13]),
                                (IO)int.Parse(currentItem[14]),
                                (Color)int.Parse(currentItem[15]));
                            list.Add(currentItemObject);
                            break;
                        case "Keyboard":
                            currentItemObject = new Keyboard(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                currentItem[7],
                                currentItem[8],
                                currentItem[9],
                                currentItem[10],
                                int.Parse(currentItem[11]),
                                Dimensions.Parse(currentItem[12]),
                                bool.Parse(currentItem[13]),
                                double.Parse(currentItem[14]),
                                (IO)int.Parse(currentItem[15]),
                                (Color)int.Parse(currentItem[16]));
                            list.Add(currentItemObject);
                            break;
                        case "Speakers":
                            currentItemObject = new Speakers(
                                currentItem[1],
                                currentItem[2],
                                currentItem[3],
                                decimal.Parse(currentItem[4]),
                                currentItem[5],
                                currentItem[6],
                                double.Parse(currentItem[7]),
                                double.Parse(currentItem[8]),
                                currentItem[9],
                                bool.Parse(currentItem[10]),
                                (IO)int.Parse(currentItem[11]),
                                Dimensions.Parse(currentItem[12]),
                                double.Parse(currentItem[13]),
                                (Color)int.Parse(currentItem[14]));
                            list.Add(currentItemObject);
                            break;
                        default:
                            throw new Exception($"Unknown part: \"{currentItem[0]}\"");
                    }
                }
                
            }
            
        }

        public static void SaveItems() => Save(ItemsSource, AllParts, false);
        public static void SaveComputer(string path)
        {
            // Reset price if discounted
            if(LoadedComputer[0].IsDiscounted)
            {
                LoadedComputer.Select(x => new
                {
                    PartInLoadedComputer = x,
                    PartInAllPartsDatabase = AllParts.Find(y => x.ToStringNoPrice() == y.ToStringNoPrice())
                })
                .ToList()
                .ForEach(x => x.PartInLoadedComputer.Price = x.PartInAllPartsDatabase.Price);
            }

            Save(path, LoadedComputer, false);
        }
        public static void SaveAddedPart() => Save(ItemsSource, AddedPart, true);

        // Save parts to CSV file
        private static void Save(string path, List<Part> list, bool append)
        {
            using (StreamWriter sw = new StreamWriter(path, append))
            {
                foreach (var item in list) sw.WriteLine(item.ToStringInCSV());
            }
        }
    }
}
