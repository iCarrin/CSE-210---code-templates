using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Plant> testPlantList = new Dictionary<string, Plant>();
        PlantBuilder test = new PlantBuilder();
        // Dictionary<string, Plant> alreadySorted = new Dictionary<string, Plant>
        // {
        //     { "Calendula", new Plant("tomato")},
        //     { "Marigold", new Plant("tomato")},
        //     { "Basil", new Plant("tomato")},
        //     { "Beans", new Plant("tomato")},
        //     { "Collards", new Plant("tomato")},
        //     { "Borage", new Plant("tomato")},
        //     { "Brocolli", new Plant("chive")}, 
        //     { "Asparagus", new Plant("tomato")} 
              
        // };

        // Plant test = new Plant("big tomato");
        // test.beneficiaries.Add ("Asparagus", new Plant("tomato"));
        // test.beneficiaries.Add ("Basil", new Plant("tomato"));
        // test.beneficiaries.Add ("Beans", new Plant("tomato"));
        // test.beneficiaries.Add ("Borage", new Plant("tomato"));
        // test.beneficiaries.Add ("Calendula", new Plant("tomato"));
        // test.beneficiaries.Add ("Marigold", new Plant("tomato"));
       
        
        // test.benefactors.Add ("Asparagus", new Plant("tomato"));
        // test.benefactors.Add ("Collardss", new Plant("tomato"));
        // // string hotsauce = test.GetCompanionList(alreadySorted);
        // // Console.WriteLine(hotsauce);
        // test.GetCompanionList(alreadySorted);
        

    void StartMenu()
    {
        // Implementation
    }

    void Menu()
    {
        // Implementation
    }

    Plant name = test.BuildPlant();
    testPlantList.Add("tomatoe", name);
    testPlantList["tomatoe"].PrintPlantInfo();

    //plants grow in a range of tempratures. I need to acount for that
    // soil type isn't hodling up. need well drained and stuff like that
    // need soil ph
    // watering needs


    }
}