abstract class Plant
{
    private string plantName;
    private double spacing;
    private string sunLevel;
    private string soilType;
    private bool frostTolerant;
    private string plantRotationFamily;
    private string sowAndPlant;
    private string harvestTime;
    private List<string> beneficiaries;
    private List<string> benefactors;

    private string notes;

    public Plant()
    {

    }
    public Plant(string name, double spacing, string sunLevel, string soilType, bool frostTolerant, string plantRotationFamily, string sowAndPlant, string harvestTime, List<string> beneficiaries, List<string> benefactors, string notes)
    {
        plantName = name;
        this.spacing = spacing;
        this.sunLevel = sunLevel;
        this.soilType = soilType;
        this.frostTolerant = frostTolerant;
        this.plantRotationFamily = plantRotationFamily;
        this.sowAndPlant = sowAndPlant;
        this.harvestTime = harvestTime;
        this.beneficiaries = beneficiaries;
        this.benefactors = benefactors;
        this.notes = notes;
       
    }
   
    public string GetName()
    {
        return plantName;
    }

    // public void PrintAllLists(List<string> referanceList)
    // {
       
    //     if (beneficiaries.Count != 0) 
    //     {
    //         _ = SortSmallList(referanceList, beneficiaries);
    //         Console.WriteLine($"Plants that help {plantName}: ");
            
    //         for (int i = 0; i < beneficiaries.Count;)
    //         {
    //             Console.Write($"{beneficiaries[i]} ");
    //             i++;
    //             Console.Write($"{beneficiaries[i+1]} ");
    //             i++;
    //             Console.Write($"{beneficiaries[i+2]} ");
    //             i++;
    //             Console.Write($"{beneficiaries[i+3]} ");
    //             i++;
    //             Console.Write($"{beneficiaries[i+4]} ");
    //             i++;
    //             Console.WriteLine();  
    //         }

            
        // };
    //     if (benefactors.Count != 0) 
    //     {
    //         _ = SortSmallList(referanceList, beneficiaries);
    //         Console.WriteLine($"Plants that {plantName} helps \n{SortSmallList(referanceList, benefactors)}");
    //         for (int i = 0; i < benefactors.Count;)
    //         {
    //             Console.Write($"{benefactors[i]} ");
    //             i++;
    //             Console.Write($"{benefactors[i+1]} ");
    //             i++;
    //             Console.Write($"{benefactors[i+2]} ");
    //             i++;
    //             Console.Write($"{benefactors[i+3]} ");
    //             i++;
    //             Console.Write($"{benefactors[i+4]} ");
    //             i++;
    //             Console.WriteLine();  
    //         }
    //     };
    // }
    public List<string> Benefs(bool which)
    {
        List<string> benef = which ? beneficiaries : benefactors;
        return benef;
    }
    private List<string> SortSmallList(List<string> referanceList, List<string> toSort)
    {
         var sortedList = toSort
            .OrderBy(referanceList.IndexOf)
            .ToList();
        return sortedList;
    }

    public override string ToString()
    {
        return plantName;
        
    }
 
   

    public virtual string PlantInfoToString()
    
    {
            string bigBenefic = "";
            foreach (var Beneficiary in beneficiaries)
            {
                bigBenefic += $"|{Beneficiary}";
            }
            string bigBenefact = "";
            foreach (var Benefactor in benefactors)
            {
                bigBenefact += $"|{Benefactor}";
            }
        
        return plantName + "~~" + spacing + "~~" + sunLevel + "~~" + soilType + "~~" + frostTolerant + "~~" + plantRotationFamily + "~~" + sowAndPlant + "~~" + harvestTime + "~~" + bigBenefic + "~~" + bigBenefact + "~~" + notes;
    }
}