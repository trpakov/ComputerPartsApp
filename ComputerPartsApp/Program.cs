using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComputerPartsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            #region Part Initialization Test
            //var cpu1 = new CPU(
            //    "Intel",
            //    "Celeron",
            //    "G4900 ",
            //    94.65m,
            //    "http://nikem-bg.net/laptop/60294.jpg",
            //    "http://nikem-bg.net/computer-components/Intel-G4900-3.1G-2M-BOX-LGA1151/",
            //    3.1,
            //    "Coffee Lake",
            //    2,
            //    "Desktop",
            //    "14nm",
            //    2048
            //    );

            //var mb1 = new MotherBoard(
            //    "GigaByte",
            //    "AORUS",
            //    "B360M",
            //    192.07m,
            //    "http://nikem-bg.net/laptop/60815.jpg",
            //    "http://nikem-bg.net/computer-components/Gigabyte-B360M-AORUS-GAMING-3/",
            //    "MicroATX",
            //    "1151",
            //    "Intel B360",
            //    "DDR4");

            //var ram1 = new RAM(
            //    "Kingston",
            //    "HyperX FURY",
            //    "HX424C15FB",
            //    61.71m,
            //    "http://nikem-bg.net/laptop/60736.jpg",
            //    "http://nikem-bg.net/computer-components/Kingston-HyperX-FURY-4GB-2400MHz-DDR4-CL15-Black-HX424C15FB-4/",
            //    4,
            //    "DDR4",
            //    2400);

            //var vidCard1 = new VideoCard(
            //    "Sapphire",
            //    "PULSE Radeon",
            //    "11267-19-20G",
            //    232.89m,
            //    "http://nikem-bg.net/laptop/57863.jpg",
            //    "http://nikem-bg.net/computer-components/SAPPHIRE-PULSE-Radeon-RX-560-2GD5-11267-19-20G/",
            //    "AMD RX 560 ",
            //    "PCI Express 3.0",
            //    "GDDR5",
            //    4);

            //var psu1 = new PSU(
            //    "AeroCool",
            //    "PSU VX PLUS", 
            //    "A-PFC ACPN-VS80AEY", 
            //    99.48m, 
            //    "http://nikem-bg.net/laptop/61626.jpg", 
            //    "http://nikem-bg.net/computer-components/AeroCool-PSU-VX-PLUS-800W-RGB-A-PFC-ACPN-VS80AEY.1R/", 
            //    800, 
            //    new Dimensions(150, 86, 140), 
            //    "ATX", 
            //    83, 
            //    120);


            //var SSD1 = new SSD(
            //    "Samsung", 
            //    "860 EVO", 
            //    "MZ-76E250B", 
            //    127.16m, 
            //    "http://nikem-bg.net/laptop/59214.jpg", 
            //    "http://nikem-bg.net/computer-components/SSD-Samsung-860-EVO-250GB-3D-V-NAND-Slim-SATA-MZ-76E250B-EU/", 
            //    250, 
            //    "SATA III", 
            //    512, 
            //    2.5, 
            //    false, 
            //    550, 
            //    520);

            //var case1 = new Case(
            //    "DeepCool",
            //    "TESSERACT ",
            //    "DP-CCATX-TSRBKBL",
            //    65.61m,
            //    "http://nikem-bg.net/laptop/55117.jpg",
            //    "http://nikem-bg.net/computer-components/Case-DeepCool-TESSERACT-SW-Window-USB-3.0/",
            //    "ATX",
            //    new Dimensions(210, 452, 472),
            //    9,
            //    7,
            //    6,
            //    true);

            //var monitor = new Monitor(
            //    "Acer",
            //    "Predator",
            //    "XB240HBbmjdpr",
            //    474m,
            //    "http://nikem-bg.net/laptop/60377.jpg",
            //    "http://nikem-bg.net/computer-components/Acer-Predator-XB240HBbmjdpr-24in-144Hz-1ms-UM.FX0EE.B01/",
            //    24,
            //    "Full HD",
            //    "LED",
            //    "TN",
            //    false,
            //    IO.Output,
            //    new Dimensions(312, 45, 23),
            //    7000,
            //    Color.Black);

            //var mouse = new Mouse(
            //    "Cougar",
            //    "MINOS X2",
            //    "CG3MMX2WOB0001",
            //    36.64m,
            //    "http://nikem-bg.net/laptop/58603.jpg",
            //    "http://nikem-bg.net/computer-components/COUGAR-MINOS-X2-Gaming-Mouse-CG3MMX2WOB0001/",
            //    "Optical",
            //    3000,
            //    5,
            //    94,
            //    "ADNS-3050",
            //    new Dimensions(67, 40, 122),
            //    false,
            //    IO.Input,
            //    Color.Black);

            //var keyboard = new Keyboard(
            //    "Cooler Master",
            //    "DEVASTATOR II",
            //    "SGB-3030-KKMF1",
            //    57.39m,
            //    "http://nikem-bg.net/laptop/58804.jpg",
            //    "http://nikem-bg.net/computer-components/Cooler-Master-DEVASTATOR-II-Blu-LED-Desktop/",
            //    "Mechanical",
            //    "Full-size",
            //    "QWERTY",
            //    "English",
            //    125,
            //    new Dimensions(450, 36, 147),
            //    true,
            //    1200,
            //    IO.Input,
            //    Color.Black);
            #endregion - Deprecated
            #region Features Test

            //Console.WriteLine();
            ////AdminLogin.PassWordHash("defaultPassword");
            ////AdminLogin.CheckUsername("Administrator");
            //Console.WriteLine(AdminLogin.Check("Administrator", AdminLogin.Field.Username) && AdminLogin.Check("defaultPassword", AdminLogin.Field.Password));


            //foreach (var item in Items.AllParts) Console.WriteLine(item);
            ////Console.WriteLine((Items.AllParts[Items.AllParts.Count - 1] as Monitor).Color);
            //var keyboard = Items.AllParts[9];
            //var speakers = Items.AllParts[10];
            ////keyboard.ViewPicture();

            ////Items.SaveItems();
            //DebugFile.StartDebbuging();
            //var myPC = new Computer();
            //foreach (var part in Items.AllParts) myPC.AddPart(part);
            //myPC.RemovePart(myPC["Keyboard"]);
            //myPC.SaveToReceipt("..\\..\\Items\\pc.txt");
            //string cpu = "CPU";
            //var cpus = from part in myPC
            //               where part.GetType().Name.Equals(cpu)
            //               select part;

            // var logList = cpus.ToList();
            //foreach (var part in cpus) Console.WriteLine(part.Manufacturer);
            ////Console.WriteLine(logList.Max(x => x.Price));
            //Console.WriteLine(myPC[typeof(CPU)]);
            //Console.WriteLine((myPC as IEnumerable<Part>).Min(x => x.Price));
            //Console.WriteLine(Mathematics.GetMostExpensivePart(myPC).GetType());
            //Console.WriteLine("!!!!!!!!" + Mathematics.CalculateSimpleInterest(376, 25, 9));
            ////foreach (var part in myPC) Console.Write(part.Price + " ");
            //Console.WriteLine(Mathematics.CalculateMedian(myPC));

            //var pc1 = new Computer(Items.AllParts.ToArray());
            //var pc2 = new Computer(Items.AllParts.ToArray());
            //pc2["CPU"].Manufacturer = "AMD";
            //Console.WriteLine(pc1.Equals(pc2));
            //Console.WriteLine();
            //Console.WriteLine(pc2);
            //Console.WriteLine();
            //Console.WriteLine(pc1.GetHashCode());
            //Console.WriteLine(pc2.GetHashCode());
            //Console.WriteLine(myPC.GetHashCode());
            //Console.WriteLine((Items.AllParts.Find(x => x.GetType().Name == "CPU") as Part).GetPartInfo());
            //Console.WriteLine();

            #endregion
        }
    }
}
