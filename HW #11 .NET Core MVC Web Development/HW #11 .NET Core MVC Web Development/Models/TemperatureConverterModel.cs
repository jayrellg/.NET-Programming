using System.ComponentModel.DataAnnotations;

namespace HW__11_.NET_Core_MVC_Web_Development.Models
{
    public class TemperatureConverterModel
    {
        [Required(ErrorMessage = "Please enter a temperature.")]
        public float? OriginalTemperature { get; set; }

        public float ConvertedTemperature { get; set; }
        [Required]
        public string Scale { get; set; } = "Celsius";        // By Default set to Celsius



        public void ConvertTemperature()
        {
            if (OriginalTemperature == null)
            {
                ConvertedTemperature = 0; 
                return;
            }

            if (Scale == "Celsius")
            {
                ConvertedTemperature = (OriginalTemperature.Value - 32) * 5 / 9;
            }
            else
            {
                ConvertedTemperature = (OriginalTemperature.Value * 9 / 5) + 32;
            }
        }


    }
}
