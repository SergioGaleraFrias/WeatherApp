using static System.Net.WebRequestMethods;

namespace WeatherApp
{
    public class EndPoints
    {
        public static string GetGeoApifyEndPoint(string city)
        {
            //return $"https://api.geoapify.com/v1/geocode/search?text=Bilbao&format=json&apiKey=8a836cae59814458875bcc2697a1de3c";
            return $"https://api.geoapify.com/v1/geocode/search?text={city}&format=json&apiKey={Config.GeoApifyKey}";
        }

        public static string GetWeatherEndPoint(float lat, float lon)
        {
            //var urld = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m,is_day&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min,uv_index_max&timezone=Europe%2FLondon";
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m,is_day,precipitation,rain&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min,uv_index_max&timezone=Europe%2FLondon";
            return url ;
        }

    }
}
