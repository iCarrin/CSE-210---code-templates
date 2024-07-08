using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

public class ManagerConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return (objectType == typeof(Manager));
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        Manager manager = (Manager)value;
        JObject jo = new JObject();

        // Serialize the totalScore
        jo.Add("totalScore", JToken.FromObject(manager.GetType().GetField("totalScore", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(manager)));

        // Serialize the allGoals list
        JArray goalsArray = new JArray();
        var allGoals = (List<Goal>)manager.GetType().GetField("allGoals", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(manager);
        foreach (var goal in allGoals)
        {
            goalsArray.Add(JToken.FromObject(goal, new JsonSerializer { Converters = { new GoalConverter() } }));
        }
        jo.Add("allGoals", goalsArray);

        jo.WriteTo(writer);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        
        int totalScore = jo["totalScore"].Value<int>();
        List<Goal> allGoals = jo["allGoals"].ToObject<List<Goal>>(new JsonSerializer { Converters = { new GoalConverter() } });
        return new Manager(totalScore, allGoals);
    }
}