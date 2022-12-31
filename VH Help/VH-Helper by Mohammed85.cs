

using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;


    ModePicker();
    void ModePicker()
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("Welcome to VH Helper, by Mohammed85!");
        Console.WriteLine("Pick Mode Between");
        Console.WriteLine("=========================================");
        Console.WriteLine("1-Pickaxe Upgrade Chance Counter [PUCC]");
        Console.WriteLine("2-{NON WORKING}Matral Calulator [MC]");

        ModeStarter();
    };

    void ModeStarter()
    {

        string PickedMode = Console.ReadLine();

        if (PickedMode == "PUCC")

        PickaxeUpgradeChanceCounterMode();
    
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
    
    if (PickedPickaxe == "SP")
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

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = " + PickaxeReatchUpgradeChanceResult + "%");

    }
    if (PickedPickaxe == "VP")
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

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = " + PickaxeReatchUpgradeChanceResult + "%");
    }
    if (PickedPickaxe == "BCP")
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

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = " + PickaxeReatchUpgradeChanceResult + "%");
    }
    if (PickedPickaxe == "EP")
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

        Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = " + PickaxeReatchUpgradeChanceResult + "%");
    }
    if (PickedPickaxe == "PP")
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