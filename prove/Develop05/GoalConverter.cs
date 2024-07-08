using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;

public class GoalConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return typeof(Goal).IsAssignableFrom(objectType);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        Goal goal1 = (Goal)value;
        JObject jo = new JObject();

        jo.Add("Type", goal1.GetType().Name);

        AddFieldToJObject(jo, goal1, "goalName");
        AddFieldToJObject(jo, goal1, "pointsGiven");
       

        if (goal1 is ChecklistGoal checklistGoal)
        {
            AddFieldToJObject(jo, checklistGoal, "timesChecked");
            AddFieldToJObject(jo, checklistGoal, "timesToCheck");
        }

        jo.WriteTo(writer);
    }

    private void AddFieldToJObject(JObject jo, object obj, string feildName1)
    {
        FieldInfo field = obj.GetType().GetField(feildName1, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
        if (field != null)
        {
            object value = field.GetValue(obj);
            jo.Add(feildName1, value != null ? JToken.FromObject(value) : JValue.CreateNull());
        }
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
            return null;

        JObject jo = JObject.Load(reader);
        string type = jo["Type"]?.Value<string>();
        string goalName = jo["goalName"]?.Value<string>() ?? "";
        int pointsGiven = jo["pointsGiven"]?.Value<int>() ?? 0;

        Goal goal;

        switch (type)
        {
            case "SimpleGoal":
                goal = new SimpleGoal(goalName, pointsGiven);
                break;
            case "EternalGoal":
                goal = new EternalGoal(goalName, pointsGiven);
                break;
            case "ChecklistGoal":
                int timesChecked = jo["timesChecked"]?.Value<int>() ?? 0;
                int timesToCheck = jo["timesToCheck"]?.Value<int>() ?? 0;
                goal = new ChecklistGoal(goalName, pointsGiven, timesToCheck, timesChecked);
                break;
            default:
                throw new JsonSerializationException($"Unknown goal type: {type}");
        }

        return goal;
    }

    private void SetField(object obj, string feildName1, object value)
    {
        FieldInfo field = obj.GetType().GetField(feildName1, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
        if (field != null)
        {
            field.SetValue(obj, value);
        }
    }
}