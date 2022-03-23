using System.Text.Json.Serialization;

namespace TomsoftZadatak_DomagojBajs.Models
{       
        public class ArtikliPoImenuModel
    {
        [JsonPropertyName("result")]
        public Result[] Rezultati { get; set; }
        }


        public class Result
        {
        [JsonPropertyName("artikli")]
        public Artikli[] Artikli { get; set; }
        }

        public class Artikli
        {
        [JsonPropertyName("id")]
        public int ArtiklId { get; set; }
        [JsonPropertyName("naziv")]
        public string ArtiklNaziv { get; set; }
        }    
}
