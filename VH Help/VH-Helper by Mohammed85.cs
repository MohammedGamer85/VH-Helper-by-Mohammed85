

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
    if (PickedPickaxe == "SP" || PickedPickaxe == "sp")
    {
        int PickaxeBreakChance = 10;

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
                    Console.WriteLine("With the max upgrade beeing (9) with [1%]");
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
        Console.WriteLine("with the max upgrade beeing (9) with [1%]");

    }
    if (PickedPickaxe == "VP" || PickedPickaxe == "vp")
    {
        int PickaxeBreakChance = 5;

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

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It's imposible for the pickaxe to reach (" + PickaxeNumberOfUpgrades + ") upgrades - Chance = [Impossible]");
                    Console.WriteLine("with the max upgrade beeing (19) with [less than 1%]");
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
        Console.WriteLine("with the max upgrade being (19) with [less than 1%]");

    }
    if (PickedPickaxe == "BCP" || PickedPickaxe == "bcp")
    {
        int PickaxeBrackChance = 4;

        Console.WriteLine("Please enter the number of upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeReatchUpgradeChance;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 1;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 * (TempVar1 / 100);
                NumberOfTimesRepeted++;

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It's imposible for the pickaxe to reach (" + PickaxeNumberOfUpgrades + ") upgrades - Chance = [Impossible]");
                    Console.WriteLine("with the max upgrade beeing (24) with [less than 1%]");
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
        Console.WriteLine("The chance of the pickaxe reaching (" + PickaxeNumberOfUpgrades + ") Upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("with the max upgrade beeing (24) with [less than 1%]");

    }
    if (PickedPickaxe == "EP" || PickedPickaxe == "ep")
    {
        int PickaxeBrackChance = 3;

        Console.WriteLine("Please Enter The Number Of Upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeReatchUpgradeChance;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 1;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 * (TempVar1 / 100);
                NumberOfTimesRepeted++;

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 33)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It Is Imposible For The Pickaxe To Reatch (" + PickaxeNumberOfUpgrades + ") Upgrades Chance = [Imposible]");
                    Console.WriteLine("With The Max Upgrade Being (32) With [Less Than 1%]");
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
        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("With The Max Upgrade Being (32) With [Less Than 1%]");

    }
    if (PickedPickaxe == "PP" || PickedPickaxe == "pp")
    {
        int PickaxeBrackChance = 1;

        Console.WriteLine("Please Enter The Number Of Upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeReatchUpgradeChance;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 1;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 * (TempVar1 / 100);
                NumberOfTimesRepeted++;

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It Is Imposible For The Pickaxe To Reatch (" + PickaxeNumberOfUpgrades + ") Upgrades Chance = [Imposible]");
                    Console.WriteLine("With The Max Upgrade Being (99) With [Less Than 1%]");
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
        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("With The Max Upgrade Being (99) With [Less Than 1%]");

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
};

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
    


    RepeateTUCC

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