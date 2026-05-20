using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOOORAHHAH
{
    internal static class ItemService
    {
        public static List<Product> LoadFromCSV(string csvpath)
        {
            List<Product> products = new List<Product>();
            if (!File.Exists(csvpath)) return products;
            // Skip 1 skips the first row which is the headers
            var lines = File.ReadAllLines(csvpath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 4)
                {
                    try
                    {

                        string name = parts[0];
                        int quantity = int.Parse(parts[1]);
                        double price = double.Parse(parts[2]);
                        int id = int.Parse(parts[3]);

                        products.Add(new Product(name, quantity, price, id));
                    }
                    catch
                    {

                    }
                }
            }
            return products;
        }
        public static void SaveCSV(string csvpath, List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(csvpath))
            {
                writer.WriteLine("Name,Quantity,price,ID");

                foreach (var p in products)
                {
                    string line = $"{p.InvName},{p.InvQuantity},{p.InvPrice},{p.InvID}";
                    writer.WriteLine(line);
                }

            }

        }
    }
}

