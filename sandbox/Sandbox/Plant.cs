abstract class Plant
{
    private string plantName;
    public string PlantName {get;}
    private double spacing;
    public double Spacing {get;}
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
    public string GetName()
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