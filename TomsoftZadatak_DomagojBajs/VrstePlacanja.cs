using System.Text.Json.Serialization;
namespace TomsoftZadatak_DomagojBajs.Shared
{
   
        public class VrstePlacanja
        {
            [JsonPropertyName("result")]
            public Result[] RezultatiVrstePlacanja { get; set; }
        }
    
        public class Result
        {
            [JsonPropertyName("vrsta_placanja")]
            public Vrsta_Placanja[] VrstaPlacanja { get; set; }
        }

        public class Vrsta_Placanja
        {
            [JsonPropertyName("vrsta_placanja_uid")]
            public string VrstaPlacanjaUid { get; set; }

            [JsonPropertyName("naziv")]
            public string NazivVrstePlacanja { get; set; }

            [JsonPropertyName("fiskalna_oznaka")]
            public string FiskalnaOznaka { get; set; }
        }

    }

