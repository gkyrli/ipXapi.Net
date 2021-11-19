using System.Text.Json.Serialization;
using ipXapi.Net.JsonConverters;

namespace ipXapi.Net.Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Security
    {
        [JsonPropertyName("is_proxy")]
        public bool IsProxy { get; set; }
        
        [JsonConverter(typeof(AnyToString))]
        [JsonPropertyName("proxy_type")]
        public string ProxyType { get; set; }

        [JsonPropertyName("is_crawler")]
        public bool IsCrawler { get; set; }

        [JsonPropertyName("crawler_name")]
        public string CrawlerName { get; set; }

        [JsonConverter(typeof(AnyToString))]
        [JsonPropertyName("crawler_type")]
        public string CrawlerType { get; set; }

        [JsonPropertyName("is_tor")]
        public bool IsTor { get; set; }

        [JsonConverter(typeof(AnyToString))]
        [JsonPropertyName("threat_level")]
        public string ThreatLevel { get; set; }

        [JsonConverter(typeof(AnyToString))]
        [JsonPropertyName("threat_types")]
        public string ThreatTypes { get; set; }
    }

    public class Connection
    {
        [JsonPropertyName("asn")]
        public int Asn { get; set; }

        [JsonPropertyName("isp")]
        public string Isp { get; set; }
    }

    public class IpInfo
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("regionName")]
        public string RegionName { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("isp")]
        public string Isp { get; set; }

        [JsonPropertyName("org")]
        public string Org { get; set; }

        [JsonPropertyName("as")]
        public string As { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("areaCode")]
        public string AreaCode { get; set; }

        [JsonPropertyName("dmaCode")]
        public string DmaCode { get; set; }

        [JsonPropertyName("inEU")]
        public int InEU { get; set; }

        
        [JsonPropertyName("euVATrate")]
        [JsonConverter(typeof(EuVATConverter))]
        public int? EuVATrate { get; set; }

        [JsonPropertyName("continentCode")]
        public string ContinentCode { get; set; }

        [JsonPropertyName("continentName")]
        public string ContinentName { get; set; }

        [JsonPropertyName("locationAccuracyRadius")]
        public string LocationAccuracyRadius { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonPropertyName("currencySymbol_UTF8")]
        public string CurrencySymbolUTF8 { get; set; }

        [JsonPropertyName("currencyConverter")]
        public double CurrencyConverter { get; set; }

        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        [JsonPropertyName("callingCode")]
        public string CallingCode { get; set; }
        
        [JsonConverter(typeof(AnyToString))]
        [JsonPropertyName("languageCode")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("security")]
        public Security Security { get; set; }

        [JsonPropertyName("connection")]
        public Connection Connection { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }


}