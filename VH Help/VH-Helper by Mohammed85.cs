

using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;


StartFunctions();
void StartFunctions()
{
    ConsoleColor background = Console.BackgroundColor;
    ConsoleColor foreground = Console.ForegroundColor;

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;

    Console.Clear();

    ModePicker();
}
void ModePicker()
{       
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("=========================================");
        Console.WriteLine("Welcome to VH Helper, by Mohammed85!");
        Console.WriteLine("Pick a mode");
        Console.WriteLine("=========================================");
        Console.WriteLine("1-Pickaxe Upgrade Chance Counter [PUCC]");
        Console.WriteLine("2-{NON WORKING}Tool Upgrade Cost Calulator [TUCC]");

        ModeStarter();
}

void ModeStarter()
{

    string PickedMode = Console.ReadLine();

    if (PickedMode == "PUCC" || PickedMode == "pucc")
    {
        PickaxeUpgradeChanceCounterMode();
    }
    if (PickedMode == "TUCC" || PickedMode == "tucc")
    {
        ToolUpgradeCostCalulator();
    }
}

void PickaxeUpgradeChanceCounterMode()
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("Choose the type of Pickaxe");
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("1-Scrapy Pickaxe [SP]");
    Console.WriteLine("2-Vault Pickaxe [VP]");
    Console.WriteLine("3-Black Chromatic Pickaxe [BCP]");
    Console.WriteLine("4-Echoing Pickaxe [EP]");
    Console.WriteLine("5-Prismatic Pickaxe [PP]");

    string PickedPickaxe = Console.ReadLine();
    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.DarkYellow;

    int PickaxeBreakChance = 10;
    string MaxUpgradeBeeing;
    string MaxUpgradeChanceBeeing;

    if (PickedPickaxe == "SP" || PickedPickaxe == "sp")
    {   

        PickaxeBreakChance = 10;
        MaxUpgradeBeeing = "9";
        MaxUpgradeChanceBeeing = "1%";
        PickaxeReachChanceCaluclator();
    }
    if (PickedPickaxe == "VP" || PickedPickaxe == "vp")
    {
        PickaxeBreakChance = 5;
        MaxUpgradeBeeing = "19";
        MaxUpgradeChanceBeeing = "less than 1%";
        PickaxeReachChanceCaluclator();
    }
    if (PickedPickaxe == "BCP" || PickedPickaxe == "bcp")
    {
        PickaxeBreakChance = 4;
        MaxUpgradeBeeing = "24";
        MaxUpgradeChanceBeeing = "less than 1%";
        PickaxeReachChanceCaluclator();
    }
    if (PickedPickaxe == "EP" || PickedPickaxe == "ep")
    {
        PickaxeBreakChance = 3;
        MaxUpgradeBeeing = "32";
        MaxUpgradeChanceBeeing = "less than 1%";
        PickaxeReachChanceCaluclator();
    }
    if (PickedPickaxe == "PP" || PickedPickaxe == "pp")
    {
        PickaxeBreakChance = 1;
        MaxUpgradeBeeing = "99";
        MaxUpgradeChanceBeeing = "less than 1%";
        PickaxeReachChanceCaluclator();
    }


    void PickaxeReachChanceCaluclator()
    {
        Console.WriteLine("Please enter the number of upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeReatchUpgradeChance;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 1;
        int NumberOfTimesRepeated = 0;
        while (true)
        {
            if (NumberOfTimesRepeated != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBreakChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 * (TempVar1 / 100);
                NumberOfTimesRepeated++;

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It is imposible for the pickaxe to reach (" + PickaxeNumberOfUpgrades + ") upgrades - Chance = [Impossible]");
                    Console.WriteLine("With the max upgrade beeing ("+ MaxUpgradeBeeing +") with ["+ MaxUpgradeChanceBeeing +"]");
                    RepeatPUCC();
                }

            }
            else
            {
                PickaxeReatchUpgradeChance = TempVar3;
                break;
            }
        }

        double PickaxeReatchUpgradeChanceResult = Math.Ceiling((PickaxeReatchUpgradeChance * 100));

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The chance of the pickaxe reaching (" + PickaxeNumberOfUpgrades + ") upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("with the max upgrade beeing ("+ MaxUpgradeBeeing +") with ["+ MaxUpgradeChanceBeeing +"] of happening");
    }
}

RepeatPUCC();

    void RepeatPUCC()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("");
        Console.WriteLine("--Do You Want To Keep Useing The Same Mode [Y/N]--");
        string inpot = Console.ReadLine();

        if (inpot == "y" || inpot == "Y")
        {
            PickaxeUpgradeChanceCounterMode();
        }
        if (inpot == "n" || inpot == "N")
        {
            EndRepete();
        }
    }


void ToolUpgradeCostCalulator()
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("Chosse The Type Of Pickaxe");
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("1-Vault Magnet [VM]");
    Console.WriteLine("2-Vault Pickaxe [VP]");
    //Console.WriteLine("3-");
    //Console.WriteLine("4-");
    //Console.WriteLine("5-");
    Console.WriteLine("");

    string inpot = Console.ReadLine();

    if (inpot == "VM" || inpot == "vm")
    {
        
    }
    if (inpot == "VP" || inpot == "vp")
    {
        
    }



    RepeateTUCC();

    void RepeateTUCC()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("");
        Console.WriteLine("--Do You Want To Keep Useing The Same Mode [Y/N]--");
        string inpot = Console.ReadLine();

        if (inpot == "y" || inpot == "Y")
        {
            PickaxeUpgradeChanceCounterMode();
        }
        if (inpot == "n" || inpot == "N")
        {
            EndRepete();
        }
    }
}

void EndRepete()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("--Do You Want To Exit Application[Y/N]--");
    string inpot = Console.ReadLine();

    if (inpot == "y" || inpot == "Y")
    {
        Environment.Exit(0);
    }
    if (inpot == "n" || inpot == "N")
    {
        ModePicker();
    }

}

EndRepete();