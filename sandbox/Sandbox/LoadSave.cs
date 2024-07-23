using Newtonsoft.Json;
class LoadSave
{   
    
    private readonly string saveDirectory = "saves";

    public LoadSave()
    {
        if (!Directory.Exists(saveDirectory))
        {
            Directory.CreateDirectory(saveDirectory);
        }
    }

    // private JsonSerializerSettings GetJsonSettings()
    // {
    //     return new JsonSerializerSettings
    //     {
    //         Formatting = Formatting.Indented,
    //         TypeNameHandling = TypeNameHandling.Auto,
    //         Converters = new List<JsonConverter> { new PlantConverter() }
    //     };
    // }

    public List<string[]> GetSavedFiles()
    {
        List<string[]> savedFiles = new List<string[]>();

        string[] fileNames = Directory.GetFiles(saveDirectory);

        foreach (string filePath in fileNames)
        {
            string fileName = Path.GetFileName(filePath);

            string[] fileInfo = new string[2];
            fileInfo[0] = PathToName(fileName);
            fileInfo[1] = filePath;

            savedFiles.Add(fileInfo);

        }
        return savedFiles;
    }
    public Garden LoadFile(string fileName) 
    {
        string filePath = fileName;

        if (!filePath.Contains(saveDirectory))
        {
            // Add the save directory to the file path

            filePath = Path.Combine(saveDirectory, filePath);
        }

        string fileContent = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Garden>(fileContent);
    }
    public Plant LoadCatalog(string fileName) 
    {
        string filePath = fileName;

        if (!filePath.Contains(saveDirectory))
        {
            // Add the save directory to the file path

            filePath = Path.Combine(saveDirectory, filePath);
        }

        string[] fileContent = File.ReadAllText(filePath).Split("%%%");
        Dictionary<string,Plant> allPlantsEver = new();
        foreach (string i in fileContent)
        {
            string[] p = i.Split("~~");
            List<string> benefic = p[8].Split("|").ToList();
            List<string> benefac = p[9].Split("|").ToList();
            Plant plant = new(p[0], double.Parse(p[1]), p[2], p[3], bool.Parse(p[4]), p[5], p[6], p[7], benefic, benefac, p[10]);

        }

        return ;
    }
    
    public string NameToPath(string fileName) 
    {
        string lowerCaseName = fileName.ToLower();
        string safeFileName = lowerCaseName.Replace(" ", "-");

        return safeFileName;
    }
    public string PathToName(string filePath) 
    {
        string fileName = filePath.Replace("-", " ");
        string titleCaseName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fileName);

        return titleCaseName;
    }
    public void SaveFile(Garden plot) 
    {
        // Convert the quest name to a safe file path
        string filePath = NameToPath($"{plot.GetName()}.json");

        // Check if the file path already contains the save directory
        if (!filePath.Contains(this.saveDirectory)) {
            // Add the save directory to the file path
            filePath = Path.Combine(this.saveDirectory, filePath);
        }

        // Serialize the quest object to JSON format
        string fileContent = JsonConvert.SerializeObject(plot, Formatting.Indented);

        // Write the content to the file
        File.WriteAllText(filePath, fileContent);
    }
    public void SaveCatalog(Dictionary<string, Plant> catalog) 
    {
        // Convert the quest name to a safe file path
        string filePath = NameToPath("AllPlants.json");

        // Check if the file path already contains the save directory
        if (!filePath.Contains(this.saveDirectory)) {
            // Add the save directory to the file path
            filePath = Path.Combine(this.saveDirectory, filePath);
        }

        // Serialize the quest object to JSON format
        string fileContent = "";
        foreach (KeyValuePair<string,Plant> kvp in catalog)
        {
            fileContent += "%%%" + kvp.Value.PlantInfoToString();
        }

        // Write the content to the file
        File.WriteAllText(filePath, fileContent);
    }

    
}