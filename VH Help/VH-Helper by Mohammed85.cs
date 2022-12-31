

using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
StartFunctions();
void StartFunctions()
{
    ConsoleColor background = Console.BackgroundColor;
    ConsoleColor foreground = Console.ForegroundColor;

    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Gray;

    Console.Clear();

    ModePicker();
}
void ModePicker()
{
        Console.WriteLine("=========================================");
        Console.WriteLine("Welcome to VH Helper, by Mohammed85!");
        Console.WriteLine("Pick Mode Between");
        Console.WriteLine("=========================================");
        Console.WriteLine("1-Pickaxe Upgrade Chance Counter [PUCC]");
        Console.WriteLine("2-{NON WORKING}Matral Calulator [MC]");

        ModeStarter();
}

void ModeStarter()
{

    string PickedMode = Console.ReadLine();

    if (PickedMode == "PUCC" || PickedMode == "pucc")
    {
        PickaxeUpgradeChanceCounterMode();
    }
    if (PickedMode == "MC" || PickedMode == "mc")
    {
        Console.WriteLine("NON-Working");
    }
}

void PickaxeUpgradeChanceCounterMode()
{
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("Chosse The Type Of Pickaxe");
    Console.WriteLine("++++++++++++++++++++++++++");
    Console.WriteLine("1-Scrapy Pickaxe [SP]");
    Console.WriteLine("2-Vault Pickaxe [VP]");
    Console.WriteLine("3-Black Chromatic Pickaxe [BCP]");
    Console.WriteLine("4-Echoing Pickaxe [EP]");
    Console.WriteLine("5-Prismatic Pickaxe [PP]");

    string PickedPickaxe = Console.ReadLine();
    Console.WriteLine("");
    
    if (PickedPickaxe == "SP" || PickedPickaxe == "sp")
    {
        int PickaxeBrackChance = 10;

        Console.WriteLine("Please Enter The Number Of Upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeTotalUpgradeDividor = 100 * PickaxeNumberOfUpgrades;

        double PickaxeTotalUpgradeDivided;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 0;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 + TempVar1;
                NumberOfTimesRepeted++;
            }
            else
            {
                TempVar3 = TempVar3 + 100;
                PickaxeTotalUpgradeDivided = TempVar3;
                break;
            }
        }

        double PickaxeReatchUpgradeChance = PickaxeTotalUpgradeDivided / PickaxeTotalUpgradeDividor;

        double PickaxeReatchUpgradeChanceResult = PickaxeReatchUpgradeChance * 100;

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("With The Max Upgrade Being (20) With [5%]");
    }
    if (PickedPickaxe == "VP" || PickedPickaxe == "vp")
    {
        int PickaxeBrackChance = 5;

        Console.WriteLine("Please Enter The Number Of Upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeTotalUpgradeDividor = 100 * PickaxeNumberOfUpgrades;

        double PickaxeTotalUpgradeDivided;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 0;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 + TempVar1;
                NumberOfTimesRepeted++;
            }
            else
            {
                TempVar3 = TempVar3 + 100;
                PickaxeTotalUpgradeDivided = TempVar3;
                break;
            }
        }

        double PickaxeReatchUpgradeChance = PickaxeTotalUpgradeDivided / PickaxeTotalUpgradeDividor;

        double PickaxeReatchUpgradeChanceResult = PickaxeReatchUpgradeChance * 100;

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("With The Max Upgrade Being (40) With [2.5%]");

    }
    if (PickedPickaxe == "BCP" || PickedPickaxe == "bcp")
    {
        int PickaxeBrackChance = 4;

        Console.WriteLine("Please Enter The Number Of Upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeTotalUpgradeDividor = 100 * PickaxeNumberOfUpgrades;

        double PickaxeTotalUpgradeDivided;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 0;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 + TempVar1;
                NumberOfTimesRepeted++;
            }
            else
            {
                TempVar3 = TempVar3 + 100;
                PickaxeTotalUpgradeDivided = TempVar3;
                break;
            }
        }

        double PickaxeReatchUpgradeChance = PickaxeTotalUpgradeDivided / PickaxeTotalUpgradeDividor;

        double PickaxeReatchUpgradeChanceResult = PickaxeReatchUpgradeChance * 100;

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = [" + PickaxeReatchUpgradeChanceResult + "%]");
        Console.WriteLine("With The Max Upgrade Being (50) With [2%]");
    }
    if (PickedPickaxe == "EP" || PickedPickaxe == "ep")
    {
        int PickaxeBrackChance = 3;

        Console.WriteLine("Please Enter The Number Of Upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeTotalUpgradeDividor = 100 * PickaxeNumberOfUpgrades;

        double PickaxeTotalUpgradeDivided;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 0;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 + TempVar1;
                NumberOfTimesRepeted++;
            }
            else
            {
                TempVar3 = TempVar3 + 100;
                PickaxeTotalUpgradeDivided = TempVar3;
                break;
            }
        }

        double PickaxeReatchUpgradeChance = PickaxeTotalUpgradeDivided / PickaxeTotalUpgradeDividor;

        double PickaxeReatchUpgradeChanceResult = PickaxeReatchUpgradeChance * 100;

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = " + PickaxeReatchUpgradeChanceResult + "%");
        Console.WriteLine("With The Max Upgrade Being (67) With [1%]");
    }
    if (PickedPickaxe == "PP" || PickedPickaxe == "pp")
    {
        int PickaxeBrackChance = 1;

        Console.WriteLine("Please Enter The Number Of Upgrades");
        float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

        double PickaxeTotalUpgradeDividor = 100 * PickaxeNumberOfUpgrades;

        double PickaxeTotalUpgradeDivided;
        double TempVar1;
        double TempVar2 = 100;
        double TempVar3 = 0;
        int NumberOfTimesRepeted = 0;
        while (true)
        {
            if (NumberOfTimesRepeted != (PickaxeNumberOfUpgrades - 1))
            {
                TempVar1 = TempVar2 - PickaxeBrackChance;
                TempVar2 = TempVar1;
                TempVar3 = TempVar3 + TempVar1;
                NumberOfTimesRepeted++;
            }
            else
            {
                TempVar3 = TempVar3 + 100;
                PickaxeTotalUpgradeDivided = TempVar3;
                break;
            }
        }

        double PickaxeReatchUpgradeChance = PickaxeTotalUpgradeDivided / PickaxeTotalUpgradeDividor;

        double PickaxeReatchUpgradeChanceResult = PickaxeReatchUpgradeChance * 100;

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = " + PickaxeReatchUpgradeChanceResult + "%");
    }

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

};
void EndRepete()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("--Do You Want To Exit [Y/N]--");
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