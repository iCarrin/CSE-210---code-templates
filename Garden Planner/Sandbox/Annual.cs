class Annual : Plant
{
   public Annual() : base()
   {

   }

    public Annual(string name, double spacing, string sunLevel, string soilType, bool frostTolerant, string plantRotationFamily, string sowAndPlant, string harvestTime, List<string> beneficiaries, List<string> benefactors, string notes) 
    : base(name, spacing, sunLevel, soilType, frostTolerant, plantRotationFamily, sowAndPlant, harvestTime, beneficiaries, benefactors, notes)
    {
        
    }
    
}