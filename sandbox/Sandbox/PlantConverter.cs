using Newtonsoft.Json;

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

        jo.Add("Plant Type", plant.GetType().Name);
        var fields = plant.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var field in fields) 
        {
            try {
                var fieldValue = field.GetValue(plant);
                jo.Add(field.Name, JToken.FromObject(fieldValue, serializer));
            } catch (Exception ex) {
                Console.WriteLine($"Error reading field: {ex.Message}");
            }
        }
        jo.WriteTo(writer);
    }

    public override object ReadJson (JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        string typeName = jo["Plant Type"].ToString();

        Plant plant;

        string plantName = jo["plantName"].ToString();
        (int, char) hardinessZone = jo["hardinessZone"].ToString();
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
            case "Plant":
                plant = new Plant(plantName, (int, char) hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, beneficiaries, benefactors, mutual);
                break;
            case "Flowering":
                string floweringTime = jo["floweringTime"].ToString() ?? "";
                plant = new Flowering(plantName, (int, char) hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, floweringTime, beneficiaries, benefactors, mutual);
                break;
            case "Harvestable":
                string harvestingTime = jo["harvestingTime"].ToString() ?? "";
                plant = new Harvestable(plantName, (int, char) hardinessZone, spacing, sunLevel, soilType, perinial, frostTolerant, plantRotationFamily,sowAndPlant, harvestingTime, beneficiaries, benefactors, mutual);
                break;
            default:
                throw new InvalidOperationException($"Unknown plant type: {typeName}");
        }
        return plant;
}