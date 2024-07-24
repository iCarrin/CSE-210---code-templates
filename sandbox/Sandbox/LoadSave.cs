using Newtonsoft.Json;
using System.Text;

class LoadSave
{   
    
    private readonly string saveDirectory = "saves";
    private readonly string savePlantDirectory = "Plants";
    private readonly string catalogOfPlants = "All Plants";

    public LoadSave()
    {
        if (!Directory.Exists(saveDirectory))
        {
            Directory.CreateDirectory(saveDirectory);
        }
        if (!Directory.Exists(savePlantDirectory))
        {
            Directory.CreateDirectory(savePlantDirectory);
        }
    }

 
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
    public Dictionary<string,Plant> LoadCatalog() 
    {
         

        string[] fileName/*s*/ = Directory.GetFiles(savePlantDirectory);
        

        if (fileName.Count() > 0)
        {
            string file/*Name*/ = Path.GetFileName(fileName[0]/*Path*/);
            
            string[] fileInfo = new string[2];
            
            fileInfo[0] = PathToName(file/*Name*/);
            
            fileInfo[1] = fileName[0]/*Path*/;

            string filePath = fileInfo[1];

            
            if (!filePath.Contains(savePlantDirectory))
            {
                // Add the save directory to the file path

                filePath = Path.Combine(savePlantDirectory, filePath);
            }
            
            string[] fileContent = File.ReadAllLines(filePath);
            // Console.WriteLine(fileBigContent);
            // string[] fileContent = fileBigContent.Split("%%%");
            foreach (string s in fileContent) 
                {
                    Console.WriteLine(s);
                }
            Dictionary<string,Plant> allPlantsEver = new();
            foreach (string i in fileContent)
            {
                Plant plant;
                string[] p = i.Split("~~");
                foreach (string s in p) 
                {
                    Console.WriteLine(s);
                }
                List<string> benefic =[.. (p[8].Split("|") ?? Array.Empty<string>())];
                List<string> benefac = [.. (p[9]?.Split("|") ?? Array.Empty<string>())];
                if (p.Count() == 12)
                {
                    plant = new Perennial(p[0], double.Parse(p[1]), p[2], p[3], bool.Parse(p[4]), p[5], p[6], p[7], benefic, benefac, p[10], int.Parse(p[11]));
                }
                else 
                {
                    
                    plant = new Annual(p[0], double.Parse(p[1]), p[2], p[3], bool.Parse(p[4]), p[5], p[6], p[7], benefic, benefac, p[10]);
                }
            
                allPlantsEver.Add(p[0], plant);
            }
            return allPlantsEver;
            }
        else
        {
            return new Dictionary<string, Plant>();
        }
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
        string filePath = NameToPath(catalogOfPlants);

        // Check if the file path already contains the save directory
        if (!filePath.Contains(this.savePlantDirectory)) {
            // Add the save directory to the file path
            filePath = Path.Combine(this.savePlantDirectory, filePath);
        }

        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (KeyValuePair<string, Plant> kvp in catalog)
            {
                writer.WriteLine(kvp.Value.PlantInfoToString());
            }
        }
    }

    
}