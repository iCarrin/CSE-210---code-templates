using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

public class PlantConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return typeof(Plant).IsAssignableFrom(objectType);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) 
    {
        JObject jo = new JObject();
        Plant plant = (Plant)value;

        jo.Add("PlantType", plant.GetType().Name);
        
        var fields = plant.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var field in fields) 
        {
            try 
            {
                var fieldValue = field.GetValue(plant);
                jo.Add(field.Name, JToken.FromObject(fieldValue, serializer));
            } 
            catch (Exception ex) 
            {
                Console.WriteLine($"Error reading field: {ex.Message}");
            }
        }
        // jo.Add("plantName", plant.GetName());
        // jo.Add("hardinessZone", JToken.FromObject(plant.hardinessZone));
        // jo.Add("spacing", JToken.FromObject(plant.spacing));
        // jo.Add("sunLevel", JToken.FromObject(plant.sunLevel));
        // jo.Add("soilType", JToken.FromObject(plant.soilType));
        // jo.Add("perinial", JToken.FromObject(plant.perinial));
        // jo.Add("frostTolerant", JToken.FromObject(plant.frostTolerant));
        // jo.Add("plantRotationFamily", JToken.FromObject(plant.plantRotationFamily));
        // jo.Add("sowAndPlant", JToken.FromObject(plant.sowAndPlant));
        // jo.Add("beneficiaries", JToken.FromObject(plant.beneficiaries));
        // jo.Add("benefactors", JToken.FromObject(plant.benefactors));
        // jo.Add("mutual", JToken.FromObject(plant.mutual));

        // if (plant is Flowering flowering)
        // {
        //     jo.Add("floweringTime", JToken.FromObject(flowering.FloweringTime));
        // }
        // else if (plant is Harvestable harvestable)
        // {
        //     jo.Add("harvestTime", JToken.FromObject(harvestable.HarvestTime));
        // }

        jo.WriteTo(writer);
    }

    public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        string typeName = jo["Plant Type"].ToString();

        Plant plant;

        string plantName = jo["plantName"].ToString();
        string hardinessZone = jo["hardinessZone"].ToString();
        string sunLevel = jo["sunLevel"].ToString();
        string soilType = jo["soilType"].ToString();
        string plantRotationFamily = jo["plantRotationFamily"].ToString();
        string sowAndPlant = jo["sowAndPlant"].ToString();
        int spacing = (int)jo["spacing"];
        bool perinial = (bool)jo["perinial"];
        bool frostTolerant = (bool)jo["frostTolerant"];
        List<string> beneficiaries = jo["beneficiaries"].ToObject<List<string>>();
        List<string> benefactors = jo["benefactors"].ToObject<List<string>>();
        List<string> mutual = jo["mutual"].ToObject<List<string>>();

        switch(typeName) 
        {
            // case "Plant":
            //     plant = new Plant(plantName, hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, beneficiaries, benefactors, mutual);
            //     break;
            case "Flowering":
                string floweringTime = jo["floweringTime"].ToString() ?? "";
                plant = new Flowering(plantName, /*hardinessZone,*/ spacing,/* sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant,*/ floweringTime, beneficiaries, benefactors, mutual);
                break;
            case "Harvestable":
                string harvestingTime = jo["harvestingTime"].ToString() ?? "";
                plant = new Harvestable(plantName, /*hardinessZone,*/ spacing, /*sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant,*/ harvestingTime, beneficiaries, benefactors, mutual);
                break;
            default:
                throw new InvalidOperationException($"Unknown plant type: {typeName}");
        }
        return plant;
    }
}