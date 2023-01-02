

using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
int NumberOfTimesRepeatedWrong = 0;
int One = 1;
//StartFunctions///////////////////////////////////////////////////////////////////////
StartFunctions();
void StartFunctions()
{
    ConsoleColor background = Console.BackgroundColor;
    ConsoleColor foreground = Console.ForegroundColor;

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Black;

    Console.Clear();

    ModePicker();
}
void ModePicker()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
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
        ToolUpgradeCostCalulatorMode();
    }
    else
    {
        int Result = WrongInpotRepeat();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        if (Result == 1)
        {
            ModeStarter();
        }
        else
        {
            EndRepeat();
            
        }
    }
}
//Modes----------------------------------------------------------------------------//
void PickaxeUpgradeChanceCounterMode()
{
    Console.ForegroundColor = ConsoleColor.White;
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

    Console.ForegroundColor = ConsoleColor.DarkBlue;

    int PickaxeBreakChance = 0;
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
    if (PickaxeBreakChance == 0)
    {
        int Result = WrongInpotRepeat();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        if (Result == 1)
        {
            PickaxeUpgradeChanceCounterMode();
        }
        else
        {
            EndRepeat();

        }
    }


    void PickaxeReachChanceCaluclator()

    {
        Console.WriteLine("Please enter the number of upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

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
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("It is imposible for the pickaxe to reach (" + PickaxeNumberOfUpgrades + ") upgrades - Chance = [Impossible]");
                    Console.WriteLine("With the max upgrade beeing (" + MaxUpgradeBeeing + ") with [" + MaxUpgradeChanceBeeing + "]");
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

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("The chance of the pickaxe reaching (" + PickaxeNumberOfUpgrades + ") upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("with the max upgrade beeing (" + MaxUpgradeBeeing + ") with [" + MaxUpgradeChanceBeeing + "] of happening");


    }

    RepeatPUCC();

    void RepeatPUCC()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("--Do You Want To Keep Useing The Same Mode [Y/N]--");
        string inpot = Console.ReadLine();

        if (inpot == "y" || inpot == "Y")
        {
            PickaxeUpgradeChanceCounterMode();
        }
        if (inpot == "n" || inpot == "N")
        {
            EndRepeat();
        }
    }

}


void ToolUpgradeCostCalulatorMode()
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
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    string inpot = Console.ReadLine();
    Console.WriteLine("");

    if (inpot == "VM" || inpot == "vm")
    {

    }
    if (inpot == "VP" || inpot == "vp")
    {

    }
    else
    {
        int Result = WrongInpotRepeat();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        if (Result == 1)
        {
            ToolUpgradeCostCalulatorMode();
        }
        else
        {
            EndRepeat();
        }
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
            EndRepeat();
        }
    }
}

//Functions==============================================================================//

int WrongInpotRepeat()
{
    int RepeatOrStop;
    int MaxNumberOfWrongRepeats = 4;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("!Wrong inpot try again![" + NumberOfTimesRepeatedWrong + "/" + (MaxNumberOfWrongRepeats - One) + "]");
    Console.WriteLine("");
    NumberOfTimesRepeatedWrong++;
    if (NumberOfTimesRepeatedWrong != MaxNumberOfWrongRepeats)
    {
        return RepeatOrStop = 1;

    }
    if (NumberOfTimesRepeatedWrong == MaxNumberOfWrongRepeats)
    {   
        if (NumberOfTimesRepeatedWrong == MaxNumberOfWrongRepeats)
        {
            NumberOfTimesRepeatedWrong = 0;
        }
        return RepeatOrStop = 0;
        
    }
    else
    {
        return 0;
    }

    
}
//EndFunctions++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
void EndRepeat()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("--Do You Want To Exit Application[Y/N]--");
    string inpot = Console.ReadLine();

    if (inpot == "n" || inpot == "N")
    {
        ModePicker();
    }
    else
    {
        Environment.Exit(0);
    }

}

EndRepeat();


