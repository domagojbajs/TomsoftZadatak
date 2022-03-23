using System.Text.Json.Serialization;

namespace TomsoftZadatak_DomagojBajs
{
   
        public class ObracunPlacanjaModel
        {
        [JsonPropertyName("result")]
        public Result[] Rezultati { get; set; }
        }

        public class Result
        {
        [JsonPropertyName("obracun_placanja")]
        public Obracun_Placanja[] ObracunPlacanja { get; set; }
        }

        public class Obracun_Placanja
        {
            [JsonPropertyName("vrste_placanja_uid")]
            public string VrstePlacanjaUid { get; set; }

            [JsonPropertyName("naziv")]
            public string NazivPlacanja { get; set; }

            [JsonPropertyName("iznos")]
            public float Iznos { get; set; }

            [JsonPropertyName("nadgrupa_placanja_uid")]
            public string NadgrupaPlacanjaUid { get; set; }

            [JsonPropertyName("nadgrupa_placanja_naziv")]
            public string NadgrupaPlacanjaNaziv { get; set; }
        }

    }

