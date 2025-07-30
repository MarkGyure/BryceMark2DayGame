using System;
using TMPro;
using UnityEngine;

public class LeadsScript : MonoBehaviour
{
    [SerializeField] int currentLeadRep;
    public GameObject reportedLocation;
    public GameObject reportedDate;
    public GameObject reportedTime;
    public GameObject reporterName;
    public GameObject reportNumber;
    public void GenerateLead()
    {
        // New randomizer 
        var random = new System.Random();
        #region
        // Makes a list of values from locations enum
        DateTime date = new DateTime(2025, 1, 1);
        var locations = Enum.GetValues(typeof(Location));
        var firstNames = Enum.GetValues(typeof(FirstName));
        var lastNames = Enum.GetValues(typeof(LastName));
        var nicknames = Enum.GetValues(typeof(Nicknames));
        var letters = Enum.GetValues(typeof(Alphabet));
        var photoEvidence = Enum.GetValues(typeof(PhotoEvidence));
        var textEvidence = Enum.GetValues(typeof(TextEvidence));
        // Get a random value
        date = date.AddDays(random.Next(364));
        date = date.AddMinutes(random.Next(59));
        date = date.AddHours(random.Next(23));
        var randomLoc = locations.GetValue(random.Next(locations.Length));
        var randomFirstName = firstNames.GetValue(random.Next(firstNames.Length));
        var randomLastName = lastNames.GetValue(random.Next(lastNames.Length));
        var randomNickname = nicknames.GetValue(random.Next(nicknames.Length));
        var randomLetter = letters.GetValue(random.Next(letters.Length));
        // Get photo evidences
        var randomPhotoOne = photoEvidence.GetValue(random.Next(photoEvidence.Length));
        var randomPhotoSecond = photoEvidence.GetValue(random.Next(photoEvidence.Length));
        for(int i = 0; i < random.Next(2,5); i++)
        {

        }
        #endregion
        // Set new case
        reportedLocation.GetComponent<TextMeshProUGUI>().text = (FormatString(randomLoc.ToString()));
        reporterName.GetComponent<TextMeshProUGUI>().text = (randomFirstName + " \"" + (FormatString(randomNickname.ToString())) + "\" " + randomLastName);
        reportedDate.GetComponent<TextMeshProUGUI>().text = date.ToShortDateString();
        reportedTime.GetComponent<TextMeshProUGUI>().text = date.ToShortTimeString();
        reportNumber.GetComponent<TextMeshProUGUI>().text = ("#" + random.Next(9) + random.Next(9) + random.Next(9) + random.Next(9) + random.Next(9) + "-" + (FormatString(randomLetter.ToString())));
    }

    public string FormatString(string word)
    {
        string formattedString = "";

        for (int i = 0; i < word.ToCharArray().Length; i++)
        {
            if (char.IsUpper(word.ToCharArray()[i]) && i != 0)
            {
                formattedString = formattedString + " " + word.ToCharArray()[i];
            }
            else 
            {
                formattedString = formattedString + word.ToCharArray()[i];
            }
        }

        return formattedString;
    }

    //Enums
    #region 
    public enum Location
    {
        CascadeMountains,
        OlympicNationalPark,
        WillowCreek,
        BigCypressPreserve,
        SaltForkStatePark,
        HockingHillsStatePark,
        MountStHelens,
        CultusCreek
    }
    public enum FirstName
    {
        Oliver,
        Theodore,
        Henry,
        James,
        Lucas,
        Mark,
        Bryce,
        Will,
        Benjamin,
        Quincy,
        Michael,
        Max,
        Sadie,
        Jack,
        Dan,
        Owen,
        David,
        Matthew,
        Lauren,
        Jared,
        Mason,
        Chris,
        Ashton,
        Miles,
        Huda,
        Sofia,
        Amelia,
        Morgan,
        Bella,
        Sage,
        Elizabeth,
        Hannah,
        Charlie,
        Mary,
        Sam,
        Annie,
        Bianca,
        Audrick,
        Mike,
        Paige
    }
    public enum LastName 
    {
        Cabrera,
        Smith,
        Johnson,
        Williams,
        Brown,
        Jones,
        Miller,
        Davis,
        Garcia,
        Anderson,
        Taylor,
        Moore,
        Jackson,
        White,
        Harris,
        Walker,
        Robinson,
        Young,
        King,
        Hill,
        Green,
        Adams,
        Baker,
        Hall,
        Carter,
        Roberts,
        Evans,
        Parker,
        Collins,
        Edwards,
        Reyes,
        Morales,
        Cook,
        Rogers,
        Morgan,
        Reed,
        Cox,
        Bennet,
        Price,
        Sanders,
        Ross,
        Dayola,
        Castillo,
        Hawk,
        Pianosi
    }
    public enum Nicknames
    {
        Munch,
        Pudgy,
        TheDoc,
        Ace,
        Lucky,
        Junior,
        FastHands,
        LongShot,
        OneTrick,
        CoinFlip,
        WildCard,
        LilTrouble,
        ShortStack,
        ColdFeet,
        HotShot,
        LoudMouth,
        BigBack,
        BigBrain,
        SweetTalk,
        Charm,
        BigMan,
        LittleMan,
        Slowpoke,
        SleepyHead,
        Sunshine,
        Slick,
        Freckles,
        BlueEyes,
        BossMan,
        Captain,
        OldMan,
        Kiddo,
        Beans,
        Nugget,
        DramaQueen,
        Giggles,
        MamaBear,
        Bro,
        Speedy,
        Predator
    }
    public enum Alphabet
    { 
        A,
        B,
        C,
        D,
        E,
        F,
        H,
        G,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z
    }
    public enum PhotoEvidence
    {
        BlurrySilhouettes = 1,
        ThermalHeatCam =  2,
        InfraredTrailCam = 3,
        RedEyeReflection = 1,
        Footprints = 3,
        TreeDamage = 0,
        PileOfStackedRocks = 1,
        FurSamples = 1,
        HighUpBrokenBranches = 1,
        ClawMarks = 1,
        HandPrint = 3
    }
    public enum TextEvidence
    {
        MutilatedAnimalCarcasses = 1,
        Feces = 2,
        ThrownRocksAtCampSites = 3,
        MissingFood = 1,
        WoodKnocks = 3,
        Howls = 0,
        Whoops = 3,
        GrowlsAndGrunts = 1,
        RocksClacking = 2,
        BranchHitting = 2,
        WornTrail = 1,
        DisturbedNests = 1,
        OddSmell = 3,
        ShatteredTrailCam = 3,
        QuietZones = 1,
        BloodSplatter = 1,
    }
    #endregion
}
