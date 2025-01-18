using System.Text.Json.Serialization;

namespace WebAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight, Mage, Cleric
    }
}
