using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLists.StayOut
{

    public class Rootobject
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
    }

    public class Meta
    {
        public string date { get; set; }
        public string version { get; set; }
    }

    public class Data
    {
        public int baseSetSize { get; set; }
        public Card[] cards { get; set; }
        public string code { get; set; }
        public bool isFoilOnly { get; set; }
        public bool isOnlineOnly { get; set; }
        public bool isPartialPreview { get; set; }
        public string keyruneCode { get; set; }
        public string[] languages { get; set; }
        public string mtgoCode { get; set; }
        public string name { get; set; }
        public string releaseDate { get; set; }
        public Sealedproduct[] sealedProduct { get; set; }
        public int tcgplayerGroupId { get; set; }
        public object[] tokens { get; set; }
        public int totalSetSize { get; set; }
        public Translations translations { get; set; }
        public string type { get; set; }
    }

    public class Translations
    {
    }

    public class Identifiers
    {
        public string mtgjsonV4Id { get; set; }
        public string scryfallId { get; set; }
        public string scryfallIllustrationId { get; set; }
        public string scryfallOracleId { get; set; }
        public string mcmId { get; set; }
        public string tcgplayerProductId { get; set; }
    }

    public class Legalities
    {
        public string alchemy { get; set; }
        public string brawl { get; set; }
        public string commander { get; set; }
        public string duel { get; set; }
        public string explorer { get; set; }
        public string future { get; set; }
        public string gladiator { get; set; }
        public string historic { get; set; }
        public string historicbrawl { get; set; }
        public string legacy { get; set; }
        public string modern { get; set; }
        public string oathbreaker { get; set; }
        public string pauper { get; set; }
        public string paupercommander { get; set; }
        public string penny { get; set; }
        public string pioneer { get; set; }
        public string predh { get; set; }
        public string premodern { get; set; }
        public string standard { get; set; }
        public string vintage { get; set; }
    }

    public class Purchaseurls
    {
        public string tcgplayer { get; set; }
    }

    public class Leadershipskills
    {
        public bool brawl { get; set; }
        public bool commander { get; set; }
        public bool oathbreaker { get; set; }
    }

    public class Sealedproduct
    {
        public string category { get; set; }
        public Identifiers1 identifiers { get; set; }
        public string name { get; set; }
        public Purchaseurls1 purchaseUrls { get; set; }
        public string releaseDate { get; set; }
        public string subtype { get; set; }
        public string uuid { get; set; }
        public int productSize { get; set; }
    }

    public class Identifiers1
    {
        public string tcgplayerProductId { get; set; }
    }

    public class Purchaseurls1
    {
        public string tcgplayer { get; set; }
    }

}
