using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VH_Help
{
    internal void EndRepete()
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
}
