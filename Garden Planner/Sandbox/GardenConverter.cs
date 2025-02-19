using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

public class GardenConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return typeof(Garden).IsAssignableFrom(objectType);
    }

    public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        
        if (jo == null)
        {
            throw new JsonSerializationException("Failed to load JObject");
        }
        Garden plot;
        
           
            string name = jo["name"].ToString();
            double area = (double)jo["area"];
            string sunExposure = jo["sunExposure"].ToString();
            int growingZone = (int)jo["growingZone"];
           //List<string> plantsInGarden = jo["plnatsInGarden"].ToObject<List<string>>();
            

            plot = new Garden(name, area, sunExposure, growingZone, null, null);
           
            serializer.Populate(jo.CreateReader(), plot);
        
        return plot;
    }

   
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) 
    {
        JObject jo = new JObject();
        
        Garden plot = (Garden)value;
        
      

        // Get all fields (public and non-public) of the goal
        var fields = plot.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        
        // Iterate through each field and add its value to the JSON object
        foreach (var field in fields) {
            try {
                var fieldValue = field.GetValue(plot);
                jo.Add(field.Name, JToken.FromObject(fieldValue, serializer));
            } catch (Exception ex) {
                Console.WriteLine($"Error reading field {field}: {ex.Message}");
            }
        }
        jo.WriteTo(writer);
    }
}