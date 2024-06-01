using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptList = new List<Scripture>//list that is populated with new scriptures
        {
            new Scripture("Moses 1:39", "39 For behold, this is my work and my glory—to bring to pass the immortality and eternal elife of man."),
            new Scripture("Exodus 20:3-17", "2 I am the Lord thy God, which have brought thee out of the land of Egypt, out of the house of bondage. 3 Thou shalt have no other gods before me. 4 Thou shalt not make unto thee any graven image, or any likeness of any thing that is in heaven above, or that is in the earth beneath, or that is in the water under the earth: 5 Thou shalt not bow down thyself to them, nor serve them: for I the Lord thy God am a jealous God, visiting the iniquity of the fathers upon the children unto the third and fourth generation of them that hate me; 6 And shewing mercy unto thousands of them that love me, and keep my commandments. 7 Thou shalt not take the name of the Lord thy God in vain; for the Lord will not hold him guiltless that taketh his name in vain. 8 Remember the sabbath day, to keep it holy. 9 Six days shalt thou labour, and do all thy work: 10 But the seventh day is the sabbath of the Lord thy God: in it thou shalt not do any work, thou, nor thy son, nor thy daughter, thy manservant, nor thy maidservant, nor thy cattle, nor thy stranger that is within thy gates: 11 For in six days the Lord made heaven and earth, the sea, and all that in them is, and rested the seventh day: wherefore the Lord blessed the sabbath day, and hallowed it. 12 Honor thy father and thy mother: that thy days may be long upon the land which the Lord thy God giveth thee. 13 Thou shalt not kill. 14 Thou shalt not commit adultery. 15 Thou shalt not steal. 16 Thou shalt not bear false witness against thy neighbour. 17 Thou shalt not covet thy neighbour's house, thou shalt not covet thy neighbour's wife, nor his manservant, nor his maidservant, nor his ox, nor his ass, nor any thing that is thy neighbour's."),
            new Scripture("Abraham 3:22-23", "22 Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; 23 And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born."),
            new Scripture("Joshua 24:15", "15 And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord."),
            new Scripture("Alma 32:21", "21 And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.")
        };  
        
        Random rando = new Random();
        
        int scripture = rando.Next(0,scriptList.Count);//get a random number to represent one of the possible verse
        scriptList[scripture].RunScripture();//run the memorizer method for what ever was selected

    
    }
}