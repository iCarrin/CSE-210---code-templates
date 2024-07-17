using System;
using Newtonsoft.Json;
class Program
{
    static void Main(string[] args)
    {
        List<Plant> testPlantList = new List<Plant>();
        PlantBuilder test = new PlantBuilder();
        

    // void StartMenu()
    // {
    //     // Implementation
    // }

    // void Menu()
    // {
    //     // Implementation
    // }

        Picker<string> what = new Picker<string>();
        bool done = false;
        while (done == false)
        {
            Plant testPlant = test.BuildPlant();
            testPlantList.Add(testPlant);
            testPlant.PrintPlantInfo();
            Console.WriteLine("are you done?");
            done = what.GetUserBoolChoice("Y", "N");
        }

        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };
        string gonBeSeralized = JsonConvert.SerializeObject(testPlantList, settings);

                // Write the content to the file
        File.WriteAllText("stuff.Json", gonBeSeralized);


        string fileContent = File.ReadAllText("stuff.Json");
        List<Plant> plants = JsonConvert.DeserializeObject<List<Plant>>(fileContent, settings);
        //Dictionary<string, Plant> catalog2 = plants.ToDictionary(plant => plant.GetName(), plant => plant);

        foreach (Plant p in plants)
        {
            p.ToString();
        }


        Console.ReadLine();
        foreach (Plant p in plants)
        {
            p.PrintPlantInfo();
        }

    //plants grow in a range of tempratures. I need to acount for that
    // soil type isn't hodling up. need well drained and stuff like that
    // need soil ph
    // watering needs
    //fix the .ToUpper problem espessially when it's typing out the benifical lists
// hardniess zones only matter with perinial

    }
}