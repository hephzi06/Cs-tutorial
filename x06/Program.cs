using System.Globalization;


class Program
{

    public static void Main(string[] args){
        var titleInfo = CultureInfo.CurrentCulture.TextInfo;
        var stateCapital = new[]{
            new {name = "abia state", capital="umuahia", slogan="god's own state", governor="okezie ikpeazu"},
            new {name = "adamawa state", capital="yola", slogan="land of beauty", governor="ahmadu umaru fintiri"},
            new {name = "akwa ibom state", capital="uyo", slogan="land of promise", governor="udom gabriel emmanuel"},
            new {name = "anambra state", capital="awka", slogan="light of the nation", governor="charles soludo"},
            new {name = "bauchi state", capital="bauchi", slogan="pearl of tourism", governor="bala abdulkadir mohammed"},
            new {name="bayelsa State",    capital="yenagoa" ,  slogan="glory of all lands" ,        governor="douye diri"},
            new {name="benue State",  capital="makurdi" ,     slogan = "food basket of the nation", governor="samuel ortom"},
            new {name="borno state", capital="maiduguri", slogan="home of peace", governor="babagana umara zulum"},
            new {name="cross river state" , capital="calabar", slogan="the people's paradise", governor="benedict ayade"},
            new {name="delta state" , capital="asaba", slogan="	the big heart", governor="ifeanyi okowa"},
            new {name="ebonyi state" , capital="abakaliki", slogan="salt of the nation", governor="dave umahi"},
            new {name="edo state" , capital="benin city", slogan="heart beat of nigeria", governor="godwin obaseki"},
            new {name="ekiti state" , capital="ado-ekiti", slogan="land of honour and integrity", governor="john olukayode fayemi"},
            new {name="enugu state" , capital="enugu", slogan="coal city state", governor="ifeanyi ugwuanyi"},
            new {name="gombe state" , capital="gombe", slogan="jewel in the savannah", governor="muhammad inuwa yahaya"},
            new {name="imo state" , capital="owerri", slogan="eastern heartland", governor="hope odidika uzodinma"},
            new {name="jigawa state" , capital="dutse", slogan="the new world", governor="badaru abubakar"},
            new {name="kaduna state" , capital="kaduna", slogan="centre of learning ", governor="nasir ahmad el-rufai"},
            new {name="kano state" , capital="kano", slogan="centre of commerce", governor="abdullahi umar ganduje"},
            new {name="kastina state" , capital="kastina", slogan="home of hospitality", governor="aminu bello masari"},
            new {name="kebbi state" , capital="birnin kebbi", slogan="land of equity", governor="abubakar atiku bagudu"},
            new {name="kogi state" , capital="lokoja", slogan="the confluence state", governor="yahaya adoza bello"},
            new {name="kwara state" , capital="ilorin", slogan="state of harmony", governor="abdul rahman abdul razaq"},
            new {name="lagos state" , capital="ikeja", slogan="centre of excellence ", governor="babajide olusola sanwo-olu"},
            new {name="nasarawa state" , capital="lafia", slogan="home of solid minerals", governor="abdullahi sule"},
            new {name="niger state" , capital="minna", slogan="	the power state", governor="abubakar sani bello"},
            new {name="ogun state" , capital="abeokuta", slogan="gateway state", governor="dapo abiodun"},
            new {name="ondo state" , capital="akure", slogan="sunshine state", governor="rotimi akeredolu"},
            new {name="osun state" , capital="oshogbo", slogan="land of virtue", governor="isiaka adegboyega oyetola"},
            new {name="oyo state" , capital="ibadan", slogan="pace setter state", governor="oluseyi abiodun makinde"},
            new {name="plateau state" , capital="jos", slogan="	home of peace and tourism", governor="simon lalong"},
            new {name="rivers state" , capital="port harcourt", slogan="treasure base of the nation", governor="ezenwo nyesom wike"},
            new {name="sokoto state" , capital="sokoto", slogan="seat of the caliphate	", governor="aminu waziri tambuwal"},
            new {name="taraba state" , capital="jalingo", slogan="nature's gift to the nation", governor="darius ishaku"},
            new {name="yobe state" , capital="damaturu", slogan="pride of the sahel", governor="mai mala buni"},
            new {name="zamfara state" , capital="gasau", slogan="farming is our pride ", governor="bello muhammed mutawalle"},
            // new {name="fct" , capital="asaba", slogan="	the big heart", governor="ifeanyi okowa"},


        };
        Console.Write("Welcome to Nigeria Wiki \n Search using \" State name , Capital name , Slogan , Governor's name\" \n Enter name :  ");

        string option = Console.ReadLine().ToLower();
        for (int i = 0; i <= stateCapital.Length - 1; i++)
        {
                if(option  == stateCapital[i].name || option == stateCapital[i].capital || option == stateCapital[i].slogan ||option == stateCapital[i].governor ){
                    Console.WriteLine($"{titleInfo.ToTitleCase(stateCapital[i].name)}  {titleInfo.ToTitleCase(stateCapital[i].capital)} {titleInfo.ToTitleCase(stateCapital[i].slogan)} {titleInfo.ToTitleCase(stateCapital[i].governor)} ");
                }
        }
    }
}
