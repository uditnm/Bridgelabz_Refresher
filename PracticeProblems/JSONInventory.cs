using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeProblems
{
    internal class JSONInventory
    {
        string jsonfile = @"D:\bridgelabz\Bridgelabz_Refresher\PracticeProblems\items.json";
        public void inventory()
        {
            Console.WriteLine("1.wheats \n2.Rice \n3.Pulses");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name : ");
            var name = Console.ReadLine();
            Console.WriteLine("\nEnter weight : ");
            var weight = Console.ReadLine();
            Console.WriteLine("\nEnter Price per kg : ");
            var price = Console.ReadLine();

            var newitem = "{\"name\": \"" + name + "\", \"weight\": " + weight + ", \"price per kg\": " + price + "}";
            try
            {
                var json = File.ReadAllText(jsonfile);
                var jsonObj = JObject.Parse(json);
                var item = JObject.Parse(newitem);
                switch (ch)
                {
                    case 1:
                        var arr = jsonObj.GetValue("wheats") as JArray;
                        arr.Add(item);

                        jsonObj["wheats"] = arr;
                        break;
                    case 2:
                        var ar = jsonObj.GetValue("rice") as JArray;
                        ar.Add(item);

                        jsonObj["rice"] = ar;
                        break;
                    case 3:
                        var a = jsonObj.GetValue("pulses") as JArray;
                        a.Add(item);

                        jsonObj["pulses"] = a;
                        break;
                }
                

                string newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(jsonfile, newJsonResult);

                foreach (var i in jsonObj)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Error : " + ex.Message.ToString());
            }
        }

    }
}
