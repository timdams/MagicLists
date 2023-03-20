using MagicLists.StayOut;
using System.Text.Json.Serialization;

namespace MagicLists
{
    public class Card
    {
        [JsonPropertyName("artist")]
        public string Artist { get; set; }


        [JsonPropertyName("convertedManaCost")]
        public float ConvertedManaCost { get; set; }

        public Identifiers identifiers { get; set; }

        [JsonPropertyName("manaCost")]
        public string ManaCost { get; set; }

        [JsonPropertyName("manaValue")]
        public float ManaValue { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("types")]
        public string[] Types { get; set; }

        [JsonPropertyName("flavorText")]
        public string FlavorText { get; set; }

    }
}
