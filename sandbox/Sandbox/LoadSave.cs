// using Newtonsoft.Json;
// public class LoadSave
// {
//     private readonly string saveDirectory = "allPlants";
//     public LoadSave()
//     {
//         if (!Directory.Exists(saveDirectory))
//         {
//             Directory.CreateDirectory(saveDirectory);
//         }
//     }

//     public void Save()
//     {
//        Plant myObject = new Plant();
//        string jsonString = JsonConvert.SerializeObject(myObject);
//     }

//     public List<string[]> GetSavedFiles()
//     {
//         List<string[]> savedFiles = new List<string[]>();

//         string[] fileNames = Directory.GetFiles(saveDirectory);

//         foreach (string filePath in fileNames)
//         {
//             string fileName = Path.GetFileName(filePath);

//             string[] fileInfo = new string[2];
//             fileInfo[0] = PathToName(fileName);
//             fileInfo[1] = filePath;

//             savedFiles.Add(fileInfo);

//         }
//         return savedFiles;
//     }
//     public Garden LoadFile(string fileName) 
//     {
//         string filePath = fileName;

//         if (!filePath.Contains(saveDirectory))
//         {
//             // Add the save directory to the file path
//             filePath = Path.Combine(saveDirectory, filePath);
//         }

//         string fileContent = File.ReadAllText(filePath);
//         return JsonConvert.DeserializeObject<Garden>(fileContent);
//     }
//     // public List<Plant> LoadPlantCatalog(string fileName) // I don't think I need this. I think I can deseralize a fixed list with a fixed location in the garden class
//     // {
//     //     string filePath = fileName;

//     //     if (!filePath.Contains(saveDirectory))
//     //     {
//     //         // Add the save directory to the file path
//     //         filePath = Path.Combine(saveDirectory, filePath);
//     //     }

//     //     string fileContent = File.ReadAllText(filePath);
//     //     return JsonConvert.DeserializeObject<List<Plant>>(fileContent);
//     // }
//     public string NameToPath(string fileName) 
//     {
//         string lowerCaseName = fileName.ToLower();
//         string safeFileName = lowerCaseName.Replace(" ", "-");

//         return safeFileName;
//     }
//     public string PathToName(string filePath) 
//     {
//         string fileName = filePath.Replace("-", " ");
//         string titleCaseName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fileName);

//         return titleCaseName;
//     }
//     public void SaveFile(Garden plot) 
//     {
//         // Convert the quest name to a safe file path
//         string filePath = this.NameToPath($"{plot.GetName()}.json");

//         // Check if the file path already contains the save directory
//         if (!filePath.Contains(this.saveDirectory)) {
//             // Add the save directory to the file path
//             filePath = Path.Combine(this.saveDirectory, filePath);
        // }

        // // Serialize the quest object to JSON format
        // string fileContent = JsonConvert.SerializeObject(plot, Formatting.Indented);

        // // Write the content to the file
        // File.WriteAllText(filePath, fileContent);
//     }

//     public void SavePlantList(List<Plant> catalog)
//     {
//         string filePath = this.NameToPath($"{catalog.GetName()}.json");

//         if (!filePath.Contains(this.saveDirectory)) 
//         {
//             // Add the save directory to the file path
//             filePath = Path.Combine(this.saveDirectory, filePath);
//         }

//         string fileContent = JsonConvert.SerializeObject(catalog, Formatting.Indented);
//         File.WriteAllText(filePath, fileContent);
//     }
// }