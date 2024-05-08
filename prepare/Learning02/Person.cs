using system
class Person {

    private string givenName;
    private string familyName;
    public Person (){
        
    }

    public void EasternStyleName (){
        Console.WriteLine($"{this.familyName}, {givenName}")
    } public void WesternStyleName (){
        Console.WriteLine($"{givenName}, {this.familyName}")
    }

}