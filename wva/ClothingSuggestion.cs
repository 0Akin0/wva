using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wva {
    public class ClothingSuggestion {
        public WeatherData Weather { get; set; }

        public ClothingSuggestion(WeatherData weather) {
            Weather = weather;
        }

        public List<string> SuggestClothing() {
            var suggestions = new List<string>();

            if (Weather.Status == WeatherStatus.Rain) {
                if (Weather.WindStrength > 50) {
                    suggestions.Add("raincoat");
                }
                else {
                    suggestions.Add("umbrella");
                }
            }

            if (Weather.Temperature>=20) {
                suggestions.Add("t-shirt");
                suggestions.Add("shorts");
            }
            else {
                suggestions.Add("sweater");
                suggestions.Add("long pants");
            }

            return suggestions;
        }
    }
}
