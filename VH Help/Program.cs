

using System.Security.AccessControl;
using System.Threading.Channels;

while (true)
{
    ModePicker();

    void ModePicker()
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("Welcome to VH Helper, by Mohammed85!");
        Console.WriteLine("Pick Mode Between");
        Console.WriteLine("=========================================");
        Console.WriteLine("1-Pickaxe Upgrade Chance Counter [PUCC]");
        Console.WriteLine("2-In Making");

        ModeStarter();
    };

    void ModeStarter()
    {

        string PickedMode = Console.ReadLine();

        if (PickedMode == "PUCC")
        {

            PickaxeUpgradeChanceCounterMode();

        }
    };

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
        Console.WriteLine("6-{Testing} Required Matirals For (Number) Of Updgrades [RMFU]");

        string PickedPickaxe = Console.ReadLine();

        if (PickedPickaxe == "SP")
        {
            int PickaxeBrackChance = 10;

            Console.WriteLine("Please Enter The Number Of Upgrades");
            float PickaxeNumberOfUpgrades = Convert.ToInt32(Console.ReadLine());

            double PickaxeTotalUpgradeDividor = 100 * PickaxeNumberOfUpgrades;

            double PickaxeTotalUpgradeDivided = PickaxeTotalUpgradeDividor - (PickaxeBrackChance * PickaxeNumberOfUpgrades);

            double PickaxeReatchUpgradeChance = PickaxeTotalUpgradeDivided / PickaxeTotalUpgradeDividor;

            double PickaxeReatchUpgradeChanceResult = PickaxeReatchUpgradeChance * 100;

            Console.WriteLine("The Chance Of The Pickaxe Reatching (" + PickaxeNumberOfUpgrades + ") Upgrades = " + PickaxeReatchUpgradeChanceResult + "%");

        }
        if (PickedPickaxe == "VP")
        {

        }
        if (PickedPickaxe == "BCP")
        {

        }
        if (PickedPickaxe == "EP")
        {

        }
        if (PickedPickaxe == "PP")
        {

        }
        if (PickedPickaxe == "RMFU")
        {

        }
    };
}