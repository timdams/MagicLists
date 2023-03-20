using System.Text.Json;

namespace MagicLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> alleKaarten = LaadKaarten();

           
            
        }

        static List<Card> LaadKaarten(string path= "StayOut\\cards.json")
        {
            var json = File.ReadAllText(path);
            var allinfo = JsonSerializer.Deserialize<StayOut.Rootobject>(json);
            return allinfo.data.cards.ToList();
        }
    }
}