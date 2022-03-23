using System.Text.Json.Serialization;

namespace TomsoftZadatak_DomagojBajs.Pages
{ 
        public class ObracunArtikliModel
        {
            [JsonPropertyName("result")]
            public Result[] RezultatArtikli { get; set; }
        }

        public class Result
        {
            [JsonPropertyName("obracun_artikli")]
            public Obracun_Artikli[] ObracunArtikli { get; set; }
        }

        public class Obracun_Artikli
        {
            [JsonPropertyName("iznos")]
            public float Iznos { get; set; }
        }    
}
