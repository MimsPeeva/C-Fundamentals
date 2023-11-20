using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> list = new List<Furniture>();
            string input;
            string regex = @">>([A-Za-z]+)<<(\d+\.\d+|\d+)!(\d+)";
            while ((input = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, regex))
                {
                    Furniture furniture = new Furniture();
                    furniture.Name = match.Groups[1].Value;
                    furniture.Price = decimal.Parse(match.Groups[2].Value);
                    furniture.Quantity = int.Parse(match.Groups[3].Value);
                list.Add(furniture);
                }
                
            }
            decimal totalPrice = 0;
            Console.WriteLine("Bought furniture:");
            foreach  (Furniture furniture in list)
            {
                Console.WriteLine(furniture.Name);
                totalPrice += furniture.Total();
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
   public class Furniture
   {
        public string Name { get; set; }    
        public decimal Price { get; set; }
        public int  Quantity { get; set; }
    public decimal Total()
    { return Price*Quantity; }
   }
}