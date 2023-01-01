

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
    Console.ForegroundColor = ConsoleColor.Black;
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

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    if (PickedPickaxe == "SP" || PickedPickaxe == "sp")
    {
        int PickaxeBrackChance = 10;

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

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It Is Imposible For The Pickaxe To Reatch (" + PickaxeNumberOfUpgrades + ") Upgrades Chance = [Imposible]");
                    Console.WriteLine("With The Max Upgrade Being (9) With [1%]");
                    RepeatePUCC();
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
        Console.WriteLine("With The Max Upgrade Being (9) With [1%]");

    }
    if (PickedPickaxe == "VP" || PickedPickaxe == "vp")
    {
        int PickaxeBrackChance = 5;

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

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It Is Imposible For The Pickaxe To Reatch (" + PickaxeNumberOfUpgrades + ") Upgrades Chance = [Imposible]");
                    Console.WriteLine("With The Max Upgrade Being (19) With [Less Than 1%]");
                    RepeatePUCC();
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
        Console.WriteLine("With The Max Upgrade Being (19) With [Less Than 1%]");

    }
    if (PickedPickaxe == "BCP" || PickedPickaxe == "bcp")
    {
        int PickaxeBrackChance = 4;

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

                if (TempVar3 < 0 || TempVar3 == 0 || PickaxeNumberOfUpgrades == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It Is Imposible For The Pickaxe To Reatch (" + PickaxeNumberOfUpgrades + ") Upgrades Chance = [Imposible]");
                    Console.WriteLine("With The Max Upgrade Being (24) With [Less Than 1%]");
                    RepeatePUCC();
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
        Console.WriteLine("With The Max Upgrade Being (24) With [Less Than 1%]");

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
                    RepeatePUCC();
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
                    RepeatePUCC();
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

    
    RepeatePUCC();

    void RepeatePUCC()
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