using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace MudBlazor.Examples.Data.Models
{
    public class Element
    {
       
        public int UsiaArmada { get; set; }
        public string TypeArmada { get; set; }
        public string NoPol { get; set; }

        [JsonPropertyName("small")]
        public string KodeArmada { get; set; }
        public string BU { get; set; }
        

        public override string ToString()
        {
            return $"{KodeArmada} - {TypeArmada}";
        }
    }
}