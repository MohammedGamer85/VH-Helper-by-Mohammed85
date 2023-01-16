

using System.ComponentModel;
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

    Console.WriteLine("!!You can quite the app at any time by clicking [Enter] 5 times!!");

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
    Console.WriteLine("2-Tool Upgrade Cost Calulator [TUCC]");

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
    if (PickedMode != "TUCC" && PickedMode != "tucc" && PickedMode != "PUCC" && PickedMode != "pucc")
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
        float PickaxeNumberOfUpgrades = 0;
        Console.WriteLine("Please enter the number of upgrades");
        try
        {
            PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        }
        catch (Exception)
        {
            int Result = WrongInpotRepeat();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (Result == 1)
            {
                PickaxeReachChanceCaluclator();
                
            }
            else
            {
                EndRepeat();
                
            }
        }

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
        Console.WriteLine("--Do You Want To Keep Useing The Same Mode (PUCC) [Y/N]--");
        string inpot = Console.ReadLine();

        if (inpot == "y" || inpot == "Y")
        {
            PickaxeUpgradeChanceCounterMode();
        }
        if (inpot == "n" || inpot == "N")
        {
            EndRepeat();
        }
        else
        {
            EndRepeat();
        }
        if (inpot != "n" && inpot != "N" && inpot != "y" && inpot != "Y")
        {
            int Result = WrongInpotRepeat();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (Result == 1)
            {
                RepeatPUCC();
            }
            else
            {
                EndRepeat();
            }
        }
    }

}

void ToolUpgradeCostCalulatorMode()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("Chosse The Type Of Pickaxe");
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("1-Vault Magnet [VM]");
    Console.WriteLine("2-Vault Pickaxe [VP]");
    //Console.WriteLine("3-");
    //Console.WriteLine("4-");
    //Console.WriteLine("5-");

    string inpot = Console.ReadLine();
    Console.WriteLine("");

    int NumberOfUpgradesDuribility = 0;
    int NumberOfUpgradesReach = 0;
    int NumberOfUpgradesSpeed = 0;
    int NumberOfUpgradesCopiously = 0;
    int AmountOfVaultBronze = 0;
    int AmountOfVaultPlating = 0;
    int AmountOfRedVaultEssense = 0;
    int AmountOfChromaticSteel = 0;
    int AmountOfSilverScrap = 0;
    int AmountOfNetheritScrap = 0;
    int AmountOfMagnitieIngot = 0;
        
    if (inpot == "VM" || inpot == "vm")
    {

    }
    if (inpot == "VP" || inpot == "vp")
    {
        int PVNumberOfDuribilityUpgrades = 0;
        int PVNumberOfReachUpgrades = 0;
        int PVNumberOfSpeedUpgrades = 0;
        int PVNumberOfCopiouslyUpgrades = 0;

        try
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Enter number of duribility upgrades");
            PVNumberOfDuribilityUpgrades = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of reach upgrades");
            PVNumberOfReachUpgrades = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of speed upgrades");
            PVNumberOfSpeedUpgrades = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of copiously upgrades");
            PVNumberOfCopiouslyUpgrades = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
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

        if (PVNumberOfDuribilityUpgrades > 0)
        {

            NumberOfUpgradesDuribility = PVNumberOfDuribilityUpgrades;
            AmountOfVaultBronze = AmountOfVaultBronze + PVNumberOfDuribilityUpgrades * 8;
            AmountOfVaultPlating = AmountOfVaultPlating + PVNumberOfDuribilityUpgrades * 8;
            AmountOfChromaticSteel = AmountOfChromaticSteel + PVNumberOfDuribilityUpgrades * 4;
            AmountOfNetheritScrap = AmountOfNetheritScrap + PVNumberOfDuribilityUpgrades * 2;
        }
        if (PVNumberOfReachUpgrades > 0)
        {

            NumberOfUpgradesReach = PVNumberOfReachUpgrades;
            AmountOfVaultBronze = AmountOfVaultBronze + PVNumberOfReachUpgrades * 8;
            AmountOfVaultPlating = AmountOfVaultPlating + PVNumberOfReachUpgrades * 4;
            AmountOfRedVaultEssense = AmountOfRedVaultEssense + PVNumberOfReachUpgrades * 2;
            AmountOfChromaticSteel = AmountOfChromaticSteel + PVNumberOfReachUpgrades * 6;
            AmountOfSilverScrap = AmountOfSilverScrap + PVNumberOfReachUpgrades * 4;
        }
        if (PVNumberOfSpeedUpgrades > 0)
        {

            NumberOfUpgradesSpeed = PVNumberOfSpeedUpgrades;
            AmountOfVaultBronze = AmountOfVaultBronze + PVNumberOfSpeedUpgrades * 16;
            AmountOfVaultPlating = AmountOfVaultPlating + PVNumberOfSpeedUpgrades * 4;
            AmountOfRedVaultEssense = AmountOfRedVaultEssense + PVNumberOfSpeedUpgrades * 1;
            AmountOfChromaticSteel = AmountOfChromaticSteel + PVNumberOfSpeedUpgrades * 6;
            AmountOfSilverScrap = AmountOfSilverScrap + PVNumberOfSpeedUpgrades * 2;
        }
        if (PVNumberOfCopiouslyUpgrades > 0)
        {

            NumberOfUpgradesCopiously = PVNumberOfCopiouslyUpgrades;
            AmountOfVaultBronze = AmountOfVaultBronze + PVNumberOfCopiouslyUpgrades * 16;
            AmountOfVaultPlating = AmountOfVaultPlating + PVNumberOfCopiouslyUpgrades * 4;
            AmountOfRedVaultEssense = AmountOfRedVaultEssense + PVNumberOfCopiouslyUpgrades * 4;
            AmountOfChromaticSteel = AmountOfChromaticSteel + PVNumberOfCopiouslyUpgrades * 6;
            AmountOfNetheritScrap = AmountOfNetheritScrap + PVNumberOfCopiouslyUpgrades * 4;
            AmountOfSilverScrap = AmountOfSilverScrap + PVNumberOfCopiouslyUpgrades * 16;
        }

        ResultTUCC();

    }
    if (inpot != "Vm" && inpot != "vm" && inpot != "VP" && inpot != "vp")
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

    void ResultTUCC()
    {

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("It will cost you");
        Console.WriteLine("================================");
        if (AmountOfVaultBronze > 0)
        {
            Console.WriteLine(AmountOfVaultBronze + " Vault Bronze");
        }
        if (AmountOfVaultPlating > 0)
        {
            Console.WriteLine(AmountOfVaultPlating + " Vault Plating");
        }
        if (AmountOfRedVaultEssense > 0)
        {
            Console.WriteLine(AmountOfRedVaultEssense + " Red Vault Essense");
        }
        if (AmountOfChromaticSteel > 0)
        {
            Console.WriteLine(AmountOfChromaticSteel + " Chromatic Steel");
        }
        if (AmountOfSilverScrap > 0)
        {
            Console.WriteLine(AmountOfSilverScrap + " Silver Scrap");
        }
        if (AmountOfNetheritScrap > 0)
        {
            Console.WriteLine(AmountOfNetheritScrap + " Netherit Scrap");
        }
        if (AmountOfMagnitieIngot > 0)
        {
            Console.WriteLine(AmountOfMagnitieIngot + " Magnitie Ingot");
        }
        Console.WriteLine("================================");
        if (NumberOfUpgradesDuribility > 0)
        {
            Console.WriteLine("For you to craft (" + NumberOfUpgradesDuribility + ") of [DurtibilityUpgrades]");
        }
        if (NumberOfUpgradesReach > 0)
        {
            Console.WriteLine("For you to craft (" + NumberOfUpgradesReach + ") of [ReachUpgrades]");
        }
        if (NumberOfUpgradesSpeed > 0)
        {
            Console.WriteLine("For you to craft (" + NumberOfUpgradesSpeed + ") of [SpeedUpgrades]");
        }
        if (NumberOfUpgradesCopiously > 0)
        {
            Console.WriteLine("For you to craft (" + NumberOfUpgradesCopiously + ") of [CopiouslyUpgrades]");
        }

        void SwitchMode()
        {
            Console.WriteLine("Do you want to know the chance of you getting the upgrades on a pickaxe");
            string inpot = Console.ReadLine();

            if (inpot == "y" || inpot == "Y")
            {
                PickaxeUpgradeChanceCounterMode();
            }
            if (inpot == "n" || inpot == "N")
            {
                EndRepeat();
            }
            if (inpot != "n" && inpot != "N" && inpot != "y" && inpot != "Y")
            {
                int Result = WrongInpotRepeat();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (Result == 1)
                {
                    SwitchMode();
                }
                else
                {
                    EndRepeat();
                }
            }
        }

        RepeatTUCC();
    }

    void RepeatTUCC()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("--Do You Want To Keep Useing The Same Mode (TUCC) [Y/N]--");
        string inpot = Console.ReadLine();

        if (inpot == "y" || inpot == "Y")
        {
            ToolUpgradeCostCalulatorMode();
        }
        if (inpot == "n" || inpot == "N")
        {
            EndRepeat();
        }
        if (inpot != "n" && inpot != "N" && inpot != "y" && inpot != "Y")
        {
            int Result = WrongInpotRepeat();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (Result == 1)
            {
                RepeatTUCC();
            }
            else
            {
                EndRepeat();
            }
        }
    }
}

//Functions==============================================================================//

int WrongInpotRepeat()
{
    int MaxNumberOfWrongRepeats = 4;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("!Wrong inpot try again![" + NumberOfTimesRepeatedWrong + "/" + (MaxNumberOfWrongRepeats - One) + "]");
    Console.WriteLine("");
    NumberOfTimesRepeatedWrong++;
    if (NumberOfTimesRepeatedWrong != MaxNumberOfWrongRepeats)
    {
        int RepeatOrStop =1;
        return RepeatOrStop;

    }
    if (NumberOfTimesRepeatedWrong == MaxNumberOfWrongRepeats)
    {
        if (NumberOfTimesRepeatedWrong == MaxNumberOfWrongRepeats)
        {
            NumberOfTimesRepeatedWrong = 0;
        }
        int RepeatOrStop =0;
        return RepeatOrStop;
        
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


