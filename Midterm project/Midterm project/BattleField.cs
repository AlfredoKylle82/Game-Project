using System;
using System.Collections.Generic;
using System.Text;
using Midterm_Project.Weapons;
using Midterm_Project.Items;
using Midterm_Project.Characters;
using Midterm_project.Champions;

namespace Midterm_Project
{
    class BattleField
    {
        static void Main(string[] args)
        {
            //introduction
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            string valorantlegends = @"██╗   ██╗ █████╗ ██╗      ██████╗ ██████╗  █████╗ ███╗   ██╗████████╗    ██╗     ███████╗ ██████╗ ███████╗███╗   ██╗██████╗ ███████╗
██║   ██║██╔══██╗██║     ██╔═══██╗██╔══██╗██╔══██╗████╗  ██║╚══██╔══╝    ██║     ██╔════╝██╔════╝ ██╔════╝████╗  ██║██╔══██╗██╔════╝
██║   ██║███████║██║     ██║   ██║██████╔╝███████║██╔██╗ ██║   ██║       ██║     █████╗  ██║  ███╗█████╗  ██╔██╗ ██║██║  ██║███████╗
╚██╗ ██╔╝██╔══██║██║     ██║   ██║██╔══██╗██╔══██║██║╚██╗██║   ██║       ██║     ██╔══╝  ██║   ██║██╔══╝  ██║╚██╗██║██║  ██║╚════██║
 ╚████╔╝ ██║  ██║███████╗╚██████╔╝██║  ██║██║  ██║██║ ╚████║   ██║       ███████╗███████╗╚██████╔╝███████╗██║ ╚████║██████╔╝███████║
  ╚═══╝  ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝       ╚══════╝╚══════╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚══════╝
                                                                                                                                    ";
            Console.WriteLine("\n" + valorantlegends);
            Console.Write(" - Greetings, players!\n\nBefore we begin, what is your name, Player 1?: ");
            string player1Name = Console.ReadLine();
            Player player1 = new Player();
            player1.setPlayerName(player1Name);

            Console.Write("What is your name, Player 2?: ");
            string player2Name = Console.ReadLine();
            Player player2 = new Player();
            player2.setPlayerName(player2Name);

            string welcome = "\n - Welcome To Valorant Legends, " + player1Name + " & " + player2Name + "!         \n";

            foreach (char c in welcome)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }

            Console.Write("\nDo you want to know what this game is about? (yes/no): ");
            string about = Console.ReadLine();

            if (about == "yes")
            {
                Console.Write("\n  Our game, inspired by existing games called League of\n  Legends and Valorant, is a turn-based game where characters\n  make use of their own abilities and weapons to beat their\n  opponent.");
            }
            else if (about == "no")
            {
            }
            else
            {
                Console.Write("please input yes or no");
            }

            Console.Write("\n\nDo you want to know the instructions? (yes/no): ");
            string instructions = Console.ReadLine();

            if (instructions == "yes")
            {
                Console.Write("\n  The player can choose from a total of three characters\n  and three weapons depending on their liking. Every player\n  has two items in their inventory to help them win the\n  fight.");

            }
            else if (instructions == "no")
            {
            } 
            else
            {
                Console.Write("please input yes or no");
            }


            Console.Write("\n\nAre you ready to start? (yes/no): ");
            if (instructions == "no")
            {
                Console.Write("\n do you want to check the instructions? (yes/n");
                if (instructions == "yes")
                {
                    Console.Write("\n  The player can choose from a total of three characters\n  and three weapons depending on their liking. Every player\n  has two items in their inventory to help them win the\n  fight.");

                }
                else if (instructions == "no")
                {
                }
                else
                {
                    Console.Write("please input yes or no");
                }

            }
            else
            {
                Console.Write("please input yes or no");
            }
            string start = Console.ReadLine();

            Console.Clear();
            if (start == "yes")
            {
                Console.Write("\nEntering Champion Select...\n\n");
                Console.Clear();
            }
            else if (start == "no")
            {
                Console.Write("\nI think I read that as a yes. Entering Champion Select...\n\n");
                Console.Clear();
            }

            string random70 = " ";
            foreach (char c in random70)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }


            string random71 = "   . . . . .   ";
            foreach (char c in random71)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
            Console.Clear();

            string random72 = "   . . . . .   ";
            foreach (char c in random72)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
            Console.Clear();

            string random73 = "   . . . . .   ";
            foreach (char c in random73)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
            Console.Clear();

            string random74 = "   . . . . .   ";
            foreach (char c in random74)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
            Console.Clear();

            string random200 = @"
        ███╗   ██╗ ██████╗ ██╗    ██╗       ██╗████████╗███████╗    ████████╗██╗███╗   ███╗███████╗            
        ████╗  ██║██╔═══██╗██║    ██║       ██║╚══██╔══╝██╔════╝    ╚══██╔══╝██║████╗ ████║██╔════╝            
        ██╔██╗ ██║██║   ██║██║ █╗ ██║       ██║   ██║   ███████╗       ██║   ██║██╔████╔██║█████╗              
        ██║╚██╗██║██║   ██║██║███╗██║       ██║   ██║   ╚════██║       ██║   ██║██║╚██╔╝██║██╔══╝              
        ██║ ╚████║╚██████╔╝╚███╔███╔╝▄█╗    ██║   ██║   ███████║       ██║   ██║██║ ╚═╝ ██║███████╗            
        ╚═╝  ╚═══╝ ╚═════╝  ╚══╝╚══╝ ╚═╝    ╚═╝   ╚═╝   ╚══════╝       ╚═╝   ╚═╝╚═╝     ╚═╝╚══════╝            
                                                                                                               
                ███████╗ ██████╗ ██████╗     ██╗   ██╗ ██████╗ ██╗   ██╗    ████████╗ ██████╗                  
                ██╔════╝██╔═══██╗██╔══██╗    ╚██╗ ██╔╝██╔═══██╗██║   ██║    ╚══██╔══╝██╔═══██╗                 
                █████╗  ██║   ██║██████╔╝     ╚████╔╝ ██║   ██║██║   ██║       ██║   ██║   ██║                 
                ██╔══╝  ██║   ██║██╔══██╗      ╚██╔╝  ██║   ██║██║   ██║       ██║   ██║   ██║                 
                ██║     ╚██████╔╝██║  ██║       ██║   ╚██████╔╝╚██████╔╝       ██║   ╚██████╔╝                 
                ╚═╝      ╚═════╝ ╚═╝  ╚═╝       ╚═╝    ╚═════╝  ╚═════╝        ╚═╝    ╚═════╝                  
                                                                                                               
██████╗ ██╗ ██████╗██╗  ██╗     █████╗      ██████╗██╗  ██╗ █████╗ ███╗   ███╗██████╗ ██╗ ██████╗ ███╗   ██╗██╗
██╔══██╗██║██╔════╝██║ ██╔╝    ██╔══██╗    ██╔════╝██║  ██║██╔══██╗████╗ ████║██╔══██╗██║██╔═══██╗████╗  ██║██║
██████╔╝██║██║     █████╔╝     ███████║    ██║     ███████║███████║██╔████╔██║██████╔╝██║██║   ██║██╔██╗ ██║██║
██╔═══╝ ██║██║     ██╔═██╗     ██╔══██║    ██║     ██╔══██║██╔══██║██║╚██╔╝██║██╔═══╝ ██║██║   ██║██║╚██╗██║╚═╝
██║     ██║╚██████╗██║  ██╗    ██║  ██║    ╚██████╗██║  ██║██║  ██║██║ ╚═╝ ██║██║     ██║╚██████╔╝██║ ╚████║██╗
╚═╝     ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝  ╚═╝     ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝
                                                                                                         ";
            foreach (char e in random200)
            {
                Console.Write(e);
                System.Threading.Thread.Sleep(5);
            }
            Console.Clear();


            string jhinn1 = @"     ██╗██╗  ██╗██╗███╗   ██╗
     ██║██║  ██║██║████╗  ██║
     ██║███████║██║██╔██╗ ██║
██   ██║██╔══██║██║██║╚██╗██║
╚█████╔╝██║  ██║██║██║ ╚████║
 ╚════╝ ╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝
                             ";

            Console.WriteLine("\n" + jhinn1);
            string jhinnn = @"#####&%&%#&&&&&&&&&%%%&&%@@&@@@@@&%&%@&%%%%%&&&&&&&@%@&@@@@@@@@@@&#,*%
######%&/%@&&&@&%%%&%&%@&&%@@@@@&&&&%&%%&&%%&&&&&&&&&@&&&@@@@@@@@(,,*#
##########@&&@&%%&&%&&&%&&&&&%&&%&%&%%&%&%%&&&&&&&&&&&&@&&&@@@@@@**/%%
########(@&&&&%%%%@%&%%&%%&@&&&@%&%%%%%&&&%%%%&&&&&&&&&&&@&@@@@@%%###%
########/@&&&&%%&&%%%&%%&%&%%%%%%&%&%%&%%%%%%#&&&&&&&&&&&&@&@@@@#*/(/#
%%%#####(@#&&#%%%&%%%%%&&%%%%%%%%%%%%&%%%%%%%#&&&&&&&&&&&&&&&@@@@%%%%%
%%%%%%%%#%&&&@@%%%%#%%#%&%%#%(#%##%%%%%%######%&&&&&&&&&&&&@&@@@@&&&&&
%%%%%%%%##&&@%&&@&%%#####%#(#(%/#/%############&&&&&&&&&&&&&&@@@&%&&&&
%%%%%%%%(&&&%%&&@&#%#%##(/%**&%**(*/((((##(###(%%%&&&&&@&&&&&&@&#@@%/@
%%%%%%%%(@%%#%##@&&&&*/**,*/%%#%&,,,,*/((((#@&&&&&&&&&&&&&&&@@@&(#@@@@
%%%%%%#.,@%&%(((@&@@@&@/,.#%#,.#&%(.,,,,%@%&&@&%&@/%%(/&&&&&&&&&@,(@@@
%&/.*((#%&&%%#(#&&%#%%%%#& ,.......%@&&&&&@&(#%#*&&../#%%%&&@&&&@%%##@
%%%&&%&%%%&&&#(/@#*,.,**(%%*. ..,,,.. /*..,/(#%#*.,/#(((((@&@&&@&&#@@%
%%&&&&&&&&@&@@&&&///.,, ..%#%,,..*/**,../*,..,.*#,,,**/*&&&@&@&@&@&@&@
&&&&&&&&&&&@@@@@&//(,,**,*&#%..,.//*,,,*,//.,,,,/,,,%&&%&@&@&@&&&&@&@@
&&&&&&&&&&@@@@@@&@&&,***,*&#%.,,*//,,,,,,,(.,,,#&%%%&@@@@@@&@&&&&&&&&&
&&&&&&&&@%@@@@@@@@/&&,,,,(%#%.,,,*//.,,,,,,(&%%%%%@@@@@@@&&@&&&&&#%@&@
%%&&&&&@&&@@@@@@@&@#%(*//&&#%.,,/%@*,,,,,,(&##%&%@@@&%&@@&&&&&&&&%%&&&
&&%&&&%@&&@&@@@@@@@(%@,./%%#&#@%&*,,,,,,,(&/%%&%@%%%&@@@&&&&&&&@&##&&@
&&&&@&%@&&@@@@@&@@@@%%&#@&&%%#%/      .#%,%#%&&@%&&&@@@@&&@@&&&&%%&&&&
&%&&&&%&&%@@&@@&@@@@&%&%&#*#%*.,,,,.  /&##%%&%&@&&@@@@&@@@@&@&#%%@%%%&
&&&&&%%%&&@@@@@&@@@@@&&&&%&&&&&@&@&%####%%%&&&&@@@@@@&@&&&@###%@@&%%&&
&%&&&%%%%@&@@&&&&@@@@@&%&&%%%(/. ./&/%%%%&%,%&@@@@@@&@&&%#(%&&@@&%&&&#
&%&&&%%%%&&&&%&#@&&&@@@&%%%&&&@@@@%#%%@&&@%&@@@@@@@&@#(#(&&&@@@@&&&%%#
&%%&&%@#%#&&&%&((@@%%%@@&&%@&&&&&&@%#&#(%@@@&@@@@&@//((@@&&@@@@@%&&%%#
&&%&&@%%%%%%&@&&(##@@&%@@@%@@@@@@@@%#%#@@@&@@@@&&##((@@&&&@@@@&&&&%,((
%&&%@%&%%#(/*%&&&&(#%@&&%@@@@@@@@@@@@@@@@@@@@&&/(//@#&&%@&&@&&&&,#,/,,
%%%@%&&&%/,*,,,#&%&@&%%@@&@@@@@@@@@@@@@@@@%%&&&((@@&&@@@@&@%%#%,/*.,.,";

            Console.WriteLine(jhinnn);



            string jhin4 = "\n- a meticulous criminal psychopath who believes murder is art.\n  Using his gun as his paintbrush, Jhin creates works of artistic\n  brutality horrifying victims and onlookers.\n\nABILITIES\n1. Dancing Grenade - Jhin launches a magical cartridge at an enemy.\n   It can deal up to four times the normal damage.\n2. Captive Audience - Jhin places an invisible lotus trap on the enemy.\n   It explodes dealing damage for the current and next round.\n3. Curtain Call - Jhin channels, transforming Whisper into a\n   shoulder-mounted mega-cannon. It deals huge amount of damage\n";

            foreach (char c in jhin4)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }

            Console.Write("\nEnter 'yes' when you're finished reading: ");
            string yes1 = Console.ReadLine();

            if (yes1 == "yes")
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
            string luciann = @"██╗     ██╗   ██╗ ██████╗██╗ █████╗ ███╗   ██╗
██║     ██║   ██║██╔════╝██║██╔══██╗████╗  ██║
██║     ██║   ██║██║     ██║███████║██╔██╗ ██║
██║     ██║   ██║██║     ██║██╔══██║██║╚██╗██║
███████╗╚██████╔╝╚██████╗██║██║  ██║██║ ╚████║
╚══════╝ ╚═════╝  ╚═════╝╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝
                                              ";
            Console.WriteLine("\n" + luciann);
            string lucian = @"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@&&@@&&&&&&&&&&%&&&&&&&&&%%%%%&&&#((#&@@@@&@@@@@@%&%%%%%%%&&@@
@@@@@@@@@&@@@@&&&&&&&&&%%%&&&%%%%&&%%%&&#//((###&@@@@@@@@&(%%%%%%%%&@@
@@@@@@@@&@@*&@&&*&&&&%%%%&&&&%#((##(((/////((((##%%&@@@#@&##/%%%%%&&@@
@@@@@@@@&&(&&%%&&(#&%%&&&&&%########(/////*//((###%%&&@&&@@%%%%%%%&&@@
@@@@@@@&@&&&%%%&&%#%&&&&&%%########(/****,**//((###%%&&@&@@&@,%%%%%&@@
@@@@@@@&@&%#%&&%%%%%&&&%%%%%####((//***,.**///((###%%&&&&@@&@*@@@&&&@@
@@@&@@@&@%%%%@%%%%%%&%%%%%%%####((((/**#%/*///(((##%%%&&&&&&(%@@@@@@@@
@@@%@@&&&&%%##%%&%%&%%%&%%%%%##((#(/**/(%@#*/(((((##%%%&&&&&*%@@@&&&@@
@@@#%@&&&&&%#%%%%%%%%%&&%%%%%##(//(@@&#(#%@&#*((##(#%%%&&&&% &&&@@@@@@
@@@%/#@&&&&&&&%%&&&%%%%%%&&%%#((//.#%%#@@@&&@&#/(#(%%%%&%&%#*&&&%%&&@@
@@@%/,%@&%%&&&%%&&&%%%%%%&&%%%#((//*((#@%%&@&@@&%%%&%%&&%%%.&&&&&&&&@@
@@@&(,.%@&%&&%%&&&%%%%%%%%&&%%##((*/////#&&# /%@@@%#&&%&%%# @&&%&&&&@@
@@@&%*..#&&&&%%&&&%%%%%%%%%&&%%##(/*///////////(##%@(*##&&. @%%&%%&&@@
@@@@&#, ,#&&%%%&&&%%%%%#%%%%&&%%##(//((((##((((((#%@(&@&  /@@&%%%%&&@@
@@@@&#%..,(&&&&&&%%%%%%%%%%&&&%%##(((##&#///(((((%&(%%..%%&&@@@@&(&&@@
@@@@%/,,..,*&&&&&&%%%%%%%%%%%%%###((/((&&&%#//*(%&%@&/.#%%%%%%&@@@@@@@
@@@&%(*,,..,,#&&&&%%%%%%%%&%%%##((//***/#&&&&%(##@ &//%%%%%%%%%%%%&@@@
@@@@&%#*,....,*&&&&&&&&&&&%%%###((((/((((/&&&&&@, #.%%%%%%%%%%%%%%&&@@
@@@@%%%%*,....,,#&&&&&&&&&%%##&@@&&@&&&&&@@(%%/(,,%#%###%%%%%%%%%%%&@@
@@@@&%#%((((/*. ,*#@&&&&&&&%%%%%##%##//%&&&&&@%,*%#########%%%%%%%%&@@
@@@@@%%%%&&%%@%/. ./#@&&&&&&%%%%&&&&&&%%%#&&&( (#############%%%%%%&@@
@@@@@%&&%&&#&& @&#/ .*#&@&&&&&%######%&&&&&&,(####################%&@@
@@@@&@&&&&#&%&%*(#%&(,.*#%@&&&%%######%&&&*%######################%&@@
@@@@@&&&&&&&&&%%&/%%%@%/.,(%&@%%%%%%%%&&%/%#######################%&@@
@@@@@&&&&&&&&@&&#&&#%&#&&#/,*(&@&&@@@@&&*%%#####################%%%&@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@&&%%%@@@@@#&#@&&&&&&&&&&&&&&&&&&&&&&&&@@@@";

            Console.WriteLine(lucian);
            string lucian2 = "\n- a Sentinel of Light, a grim hunter of undying spirits, pursuing\n  them relentlessly and annihilating them with his twin relic pistols. \n\nABILITIES\n1. Piercing Light - Lucian fires a laser in a line in the direction\n   of the target enemy, dealing physical damage to all enemies within.\n2. Ardent Blaze - Lucian fires a shot in the target direction that\n   explodes in a cross pattern upon hitting an enemy or reaching\n   the end of its path. It marks its enemies, bonus damage for\n   the next round.\n3. The Culling - Lucian channels his gun, rapidly\n   firing shots in the enemy’s direction dealing huge damage.\n";

            foreach (char c in lucian2)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }

            Console.Write("\nEnter 'yes' when you're finished reading: ");
            string yes2 = Console.ReadLine();

            if (yes2 == "yes")
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
            string teemoo = @"████████╗███████╗███████╗███╗   ███╗ ██████╗ 
╚══██╔══╝██╔════╝██╔════╝████╗ ████║██╔═══██╗
   ██║   █████╗  █████╗  ██╔████╔██║██║   ██║
   ██║   ██╔══╝  ██╔══╝  ██║╚██╔╝██║██║   ██║
   ██║   ███████╗███████╗██║ ╚═╝ ██║╚██████╔╝
   ╚═╝   ╚══════╝╚══════╝╚═╝     ╚═╝ ╚═════╝ 
                                             ";

            Console.WriteLine("\n" + teemoo);

            string teemo = @"&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&#&@%&&&#&%&&&&&&&&&&&&&&&&&&&&&&%##%%&&/
&&&&&&&&&&&&&&&&&&&&&&&%%#%%%&&%%%##&&&%&&&&&&&&&&&&&&&&#%##/%*%%&&(/&
&&&&&&&&&&&&%%%%&&&&&&%%((#(((#%%%@&@@@&&&%&&&&&&&&&&&&%%#&**(%##*%,*(
&&&&&&&&&&&%%%%%%&&&&#######%%@@#*#&#%@@@@/,&&&&&&&&%&%%.*,*,,*,.#&%/&
&&&&&%((/***.%%%%&&&&&&%%&@%@&%@@%*..,*#%%#( #&///#%//,/(((##((*.&%,*&
&&%&#%&/*/,,..&%&&&&&&&&@@(&@//@%.  ,,(#(&((*@@@&#%**(/%%&&&&#/,*%&&&&
&&%@@%(%%&(*,*,,@/%,@@@&(&,%*&%(***/%@@@@&@&@&&%%%%%%&&(&&&&%#(.@&/(#*
&&&@@####(%#&(#(@/,#%@@#@@@@&&@*%%%%%%&&&&&%&&&&&#,*##%#/(&&%(.*@#%*/(
&&&&%&&&&%##%#@/(/**#%@@&&&&&@(%%%%&&&&@@@@@@&&&%%&%%%%( . /*.%#%%%/(/
&&&&&&&&&&&&@##*(((&#%&&&&&&&@@@@@@&%%%@@&&&&&%%%&@@&&%%%(/, %(&&#%&%%
&&&&&&&&&&&&@&###&*&&&&&&@@@@&&%%%#&%@&&&%%%%%#####%&&@&%%%(/* (%&@&&&
&&&&&&%/,*%&&%@@(@&&&&@@@&&&%%#/*&@&%%%%&&#(#%&###((**//(((##(/ &&&&&&
&%%%%/,%&&@@@&#%&&&&@@&@@@@@#*...,,(###&((////((((/,,,,,***,. ,/%&%&&&
%(*,(#%&&&&&#/@&&&@@@&%%%%#(,     ..,*((((((((/*.......,,,**,,. .&&&&&
%%%&%##(#%%&*@@&&@@&&&%@%%&(*     .,,,,....      .....,,*/***..&&&%&&&
%%%%%&&%%%&/@@@@@@%%%%#/////  #&&@@/***,*..... ..,,,,///***/,*./*..   
%%%%%%%%&&%/@@@@@%##(%////.    ..*///*,#,,...,,,**//((/(###(#(.,/(##%%
%%%&%%&&%%%&%@@@@##//,...    ...,*/&,,,,,,,***//(((#%@@&%&&(*..,*&&&&&
%%%%%%&%&&&%&/@@@%/,,,..........,,,,,*,,,**/(((#(#@&%%%%%%%#(,*#&&&&&@
##*%%%&&%%&%&&&&&%,,,,,,,,,,,,,,******///(/(##(@@@%%%%%%#(#*,.(%%%#%**
*###%%&&&%%&#%%&&/*,*,*******//////(((((((#@&&%%%%%%%%&&&#/,../(,/(#/#
##%%&&&&&&&&&&&&&*(/(%((#((((((((####&@&&&&%%%%%#&&&@@%#%#/*,,(/*&%%&%
&&&&&&&&&&&&&&&%%%&%&%@@&@&&@@@@@@&&&&&%%%%#%#(#&%%%%#&&&&&&@&#&%&&&&&
%&&&&%%%%%%%%%%%%%%%(#@@@&&&&@%%%&%&&%%%%&&@&&%(((/(&&&&&&/(%%,#//,(/*
%&&&&%%%#%%%%%%%%%%%%%%%&&&&@&&@&&%%&&%&&&%///(((@#.,,/#@&&%@##&&@@&&@
%%%%%%%%%&&&&%%%%%%%%%%%&&&&@%((#((%#@&%((/*//@(#*#%.#(((/&&&@&@%@@&&&
((##%#%%&&%%%#%%%%%%######&@@#((/*/(%%@%(///%&%##%#%&&&((/,&&@%,#@&@&@";

            Console.WriteLine(teemo);

            string teemo2 = "\n- a member of the Troll Slaiyers and uses his past experiences\n  in League of Legends to help deal with trolls.\n\nABILITIES\n1. Blinding Dart - Obscures an enemy's vision with a powerful venom,\n   dealing damage to the target unit.\n2. Toxic Shot - Each of Teemo's attacks will poison the target, dealing\n   damage on impact and an additional damage next round.\n3. Noxious Trap - Teemo throws an explosive poisonous trap using one of\n   the mushrooms stored in his pack. It detonates,\n   dealing additional damage next round.\n";

            foreach (char c in teemo2)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }
            Console.Write("\nEnter 'yes' when you're finished reading: ");
            string yes3 = Console.ReadLine();

            if (yes3 == "yes")
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }





            string random = "\nBefore you both start, here is the list of weapons. Each weapon\nconsumes ammo and a character has a total of 150 ammo.     \n\n";

            foreach (char c in random)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }

            string weapons = @"██╗    ██╗███████╗ █████╗ ██████╗  ██████╗ ███╗   ██╗███████╗
██║    ██║██╔════╝██╔══██╗██╔══██╗██╔═══██╗████╗  ██║██╔════╝
██║ █╗ ██║█████╗  ███████║██████╔╝██║   ██║██╔██╗ ██║███████╗
██║███╗██║██╔══╝  ██╔══██║██╔═══╝ ██║   ██║██║╚██╗██║╚════██║
╚███╔███╔╝███████╗██║  ██║██║     ╚██████╔╝██║ ╚████║███████║
 ╚══╝╚══╝ ╚══════╝╚═╝  ╚═╝╚═╝      ╚═════╝ ╚═╝  ╚═══╝╚══════╝
                                                             ";

            Console.WriteLine(weapons);

            string bigguns = "1. Vandal - Has 75 attack damage. Has 40%\n   chance of hitting headshots (additional 150 attack damage).\n   Consumes 25 ammo.\n2. Operator -  Can only fire once, has 150 attack damage.\n   Has a chance of 20% hitting headshots (additional 150\n   attack damage). Consumes 45 ammo.\n3. Guardian - Can only fire once, has 125 attack damage.\n   Has 40% chance of hitting headshots (additional 150\n   attack damage). Consumes 35 ammo.    \n\n";

            foreach (char c in bigguns)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }


            Console.Write("\nEnter 'yes' when you're finished reading the details: ");
            string yes4 = Console.ReadLine();

            if (yes4 == "yes")
            {
                Console.Clear();
            }
            else if (yes4 == "no")
            {
                Console.Clear();
            }

            string items = @"██╗████████╗███████╗███╗   ███╗███████╗
██║╚══██╔══╝██╔════╝████╗ ████║██╔════╝
██║   ██║   █████╗  ██╔████╔██║███████╗
██║   ██║   ██╔══╝  ██║╚██╔╝██║╚════██║
██║   ██║   ███████╗██║ ╚═╝ ██║███████║
╚═╝   ╚═╝   ╚══════╝╚═╝     ╚═╝╚══════╝
                                    ";

            Console.WriteLine("\n" + items);
            string random5 = "Below is a list of items given to players. Each player will have one of each item.\n";

            foreach (char c in random5)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(1);
            }

            string corp = @"&&&#/*(/,,/((###%%%%%%%%%%&#*(%&&&&&&&&&&@@@@@@@@( /@@&&&&&&&&&&&%%%%%%%#######%%%%&&&&&&&&@@@@@@@@@
&&%%/**##&#/,.,*(#%%(**(%%%(/#,/&&&&&&&&&&&&@@@@@( /@&&&&&&&%%%%%####((##%%%%#((##%%%&&&&@@@@@@@@@@&
&&%%(*,/#,/%&%%/,/(#%((%*,##/#/(,(&&&&&&&&&&&@@@@( /@&&@&&&%%##%%#%%#%%%%((((((((###%%&&&&%%&&&&&&&&
%%%%#/,,%%/.(%&#***///*&@@/,#&&%%/,%&&&&&&&&&&&@@( /@@&&&%%#(#%%%%%%%%%////(#%%%%%%%&%//((%%&&&&&&&&
%%%%#(***(%%#(&@&%((%####%&#(&@&%&(,#&%%&&&&&&&&&( /&&&%%#(%&%%//**%%%#**/%%%%&@&#,/(#%&(##%%%%%%&&&
##%%%%((*,*,(&,,%##%#/%&&@@&%%#@@@&%,(&&%%%&&&&&&( /&&%%%&&&&(((///(%%%%%%%%&#((%*/(#%&@#(#%%%%%%&&&
%#/**(#((/**&@%(*(&@@@%###%&&&&#%@@*.*#&&%##%%&&&( /&&%##(@&&//(///*&&%%&#&/#%/,*/(%&@@@&&##%%%#%#&&
&%%,#@#/****,%/,@@@&@@@&#/#%(&@&%#&&,,/(%%%###%&&( /&&%%#(&&&&%/***#%&&%%((%*%*(///####%&&/#%%##%%%&
*#%&(,#@@@#/@@%(#%@@%,(@@@@@%##@@&#%&*,*/(##(##%%( /&%%#((@@@&&%%#(&@@&&&(*(%#*(%#((#%%&&((%%#(/%%#%
#,(&%##/***(#@@(@%, *@@@&&@@@&%(%(((#&%,*//(((#%%/ /&%#(/%&&&%&@&&&%#%%&&&&(&(#*(&*,(%&@&#////#%%&#%
&&(,(@@&%%#&@&#.  ..%@@@@&&&@&#%((&(#&%&(,/,*(##%/ /&%(/*#%&&%%&&&&%(%&%%%&&&#/#*//(%&&@@@&&&&%&&&#%
&&&&/,#@@@&&(&@#*/. (((#&%%%&&&&%//(&%&%%%%#&,*##/ /&%((#%%#&&&&&%%%&%/((#(%%#%/&%%&%&#*/((##&&&&##%
&&&&&%*.#@@#(%((%@&#.(%%%%%#%%&&%###*/#&&%%%&&%*(/ /&%#(&&&&&&&&&%#%%&%##,.,/#&%&%%@%&,*(###(&&@##&&
&&&&%%&%*,,*,,*%(#&&&#,/((&%#(((/(%(//**&@&%*,,*** /&%#&&&&/&%&&&&&&&&%%(*.*%&&%%&@@/&**/(%@&@(#%&&&
&&&%%%%%&%#(/**,,(#%%%%#*((((((((((((#&&#(((#,/(#/ /&%#%&/(#&#&&%&&&&&&#(%#%%%&&&&%@&&%@@@%/(#%&&&&&
&&&&&%%%%%%%#(**,,,/&%%&%(,/((((##&&&&#%@@&&&%*/(/ /%%#(((((((%&&&@&%&%&&&%%&&&&&%#&&&&(*/(%%&&&&&&&
&&&&&&&%%%%%%%#(//*,,*&%%&&%/%&&@&%(#%(,,,,,*,*(#/ *%%%%%%#((%&&&&#%&&&%%&&%%%&&%%%&&&&&%/(#%%%&&&&&
&&&&&&&&&%%%%####((/*,,/&&&&&#&@@@&/.,,,,****//#%/ /&&&&%%%####((//%&&%#%#%%#(&&%%&&*((((##%%%%&&&&&
@@&&&&&&&&&&%%%###(((*/@@#./&##@&,,*/*****///##%%/ /&&&&&&&&&&&%%##(&%(((##//&&&@#((%%%%%%%%%&&&&@@&
";

            Console.WriteLine("\n" + corp);

            Console.Write("1. Corrupting Potion - Corrupting Potion can be    2. Elixir of Wrath - Deals 175 Damage.\n   used even at full health and mana. By  \n   consuming all three charges you can restore     The item can only be used twice.\n   a total of 450 health and 300 mana.");

            Console.Write("\n\nEnter 'yes' when you're finished reading: ");
            string yes5 = Console.ReadLine();

            if (yes5 == "yes")
            {
                Console.Clear();
            }
            else if (yes5 == "no")
            {
                Console.Clear();
            }

            string havefun = "\nLooks like you're ready to go! Good luck and have fun in the game! 😊";

            foreach (char c in havefun)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(30);
            }



            //player profile for player 1


            Console.Clear();



            Console.WriteLine(player1Name + ", Choose your champion [1] Jhin  [2] Lucian  [3] Teemo :");
            String championSelected = Console.ReadLine();
            if (championSelected.Equals("1"))
            {
                Character Jhin = CharacterFactory.createCharacter(1000, 500);
                Jhin.addAbility(Ability_Factory.createDancingGrenadeAbility(50, 50, "Dancing Grenade"));
                Jhin.addAbility(Ability_Factory.createCaptiveAudienceAbility(100, 50, "Captive Audience"));
                Jhin.addAbility(Ability_Factory.createCurtainCallAbility(200, 100, "Curtain Call"));
                Jhin.addItem(ItemFactory.createCorruptingPotionItem(150, 100, "Corrupting Potion", 0, 3));
                Jhin.addItem(ItemFactory.createElixirOfWrathItem(0, 0, "Elixir of Wrath", 175, 2));

                player1.setCharacter(Jhin);
                Console.WriteLine("\nGood Choice of Champion!\n");

            }
            else if (championSelected.Equals("2"))

            {
                Character Lucian = CharacterFactory.createCharacter(1000, 500);
                Lucian.addAbility(Ability_Factory.createPiercingLightAbility(100, 50, "Piercing Light"));
                Lucian.addAbility(Ability_Factory.createArdentBlazeAbility(50, 65, "Ardent Blaze"));
                Lucian.addAbility(Ability_Factory.createTheCullingAbility(175, 100, "TheCullingAbility"));
                Lucian.addItem(ItemFactory.createCorruptingPotionItem(150, 100, "Corrupting Potion", 0, 2));
                Lucian.addItem(ItemFactory.createElixirOfWrathItem(0, 0, "Elixir of Wrath", 175, 2));

                player1.setCharacter(Lucian);
                Console.WriteLine("\nGood Choice of Champion!\n");

            }
            else if (championSelected.Equals("3"))
            {
                Character Teemo = CharacterFactory.createCharacter(1000, 500);
                Teemo.addAbility(Ability_Factory.createBlindingDartAbility(50, 50, "Blinding Dart"));
                Teemo.addAbility(Ability_Factory.createToxicShotAbility(50, 50, "Toxic Shot"));
                Teemo.addAbility(Ability_Factory.createNoxiousTrapAbility(50, 50, "Noxious Trap"));
                Teemo.addItem(ItemFactory.createCorruptingPotionItem(150, 100, "Corrupting Potion", 0, 2));
                Teemo.addItem(ItemFactory.createElixirOfWrathItem(0, 0, "Elixir of Wrath", 175, 2));

                player1.setCharacter(Teemo);
                Console.WriteLine("\nGood Choice of Champion!\n");

            } else {
                Console.WriteLine("Please pick a champion by pressing [1], [2], [3]");
            }

            //Weapons

            Console.WriteLine(player1Name + ", Choose your weapon [1] Vandal  [2] Operator  [3]  Guardian :");
            String selectedWeapon1 = Console.ReadLine();
            if (selectedWeapon1.Equals("1"))
            {
                Weapon Vandal = WeaponFactory.createVandal(75, 150, "Vandal");

                player1.getCharacter().setWeapon(Vandal);

                Console.WriteLine("\nGood Choice of Weapon!\n");

            }
            else if (selectedWeapon1.Equals("2"))
            {
                Weapon Operator = WeaponFactory.createOperator(150, 150, "Operator");

                player1.getCharacter().setWeapon(Operator);
                Console.WriteLine("\nGood Choice of Weapon!\n");

            }
            else if (selectedWeapon1.Equals("3"))
            {
                Weapon Guardian = WeaponFactory.createGuardian(125, 150, "Guardian");

                player1.getCharacter().setWeapon(Guardian);
                Console.WriteLine("\nGood Choice of Weapon!\n");

            }
            else
            {
                Console.WriteLine("Please pick a weapon by pressing [1], [2], [3]");
            }

            //player profile for player 2


            Console.Clear();

            Console.WriteLine(player2Name + " Choose your champion [1] Jhin  [2] Lucian  [3] Teemo :");
            String championSelected2 = Console.ReadLine();
            if (championSelected2.Equals("1"))
            {
                Character Jhin2 = CharacterFactory.createCharacter(1000, 500);
                Jhin2.addAbility(Ability_Factory.createDancingGrenadeAbility(50, 50, "Dancing Grenade"));
                Jhin2.addAbility(Ability_Factory.createCaptiveAudienceAbility(100, 50, "Captive Audience"));
                Jhin2.addAbility(Ability_Factory.createCurtainCallAbility(200, 100, "Curtain Call"));
                Jhin2.addItem(ItemFactory.createCorruptingPotionItem(150, 100, "Corrupting Potion", 0, 3));
                Jhin2.addItem(ItemFactory.createElixirOfWrathItem(0, 0, "Elixir of Wrath", 175, 2));
                player2.setCharacter(Jhin2);
                Console.WriteLine("\nGood Choice of Champion!\n");
            }
            else if (championSelected2.Equals("2"))
            {
                Character Lucian2 = CharacterFactory.createCharacter(1000, 500);
                Lucian2.addAbility(Ability_Factory.createPiercingLightAbility(100, 50, "Piercing Light"));
                Lucian2.addAbility(Ability_Factory.createArdentBlazeAbility(50, 65, "Ardent Blaze"));
                Lucian2.addAbility(Ability_Factory.createTheCullingAbility(175, 100, "TheCullingAbility"));
                Lucian2.addItem(ItemFactory.createCorruptingPotionItem(150, 100, "Corrupting Potion", 0, 3));
                Lucian2.addItem(ItemFactory.createElixirOfWrathItem(0, 0, "Elixir of Wrath", 175, 2));
                player2.setCharacter(Lucian2);
                Console.WriteLine("\nGood Choice of Champion!\n");
            }
            else if (championSelected2.Equals("3"))
            {
                Character Teemo2 = CharacterFactory.createCharacter(1000, 500);
                Teemo2.addAbility(Ability_Factory.createBlindingDartAbility(50, 50, "Blinding Dart"));
                Teemo2.addAbility(Ability_Factory.createToxicShotAbility(50, 50, "Toxic Shot"));
                Teemo2.addAbility(Ability_Factory.createNoxiousTrapAbility(50, 50, "Noxious Trap"));
                Teemo2.addItem(ItemFactory.createCorruptingPotionItem(150, 100, "Corrupting Potion", 0, 3));
                Teemo2.addItem(ItemFactory.createElixirOfWrathItem(0, 0, "Elixir of Wrath", 175, 2));

                player2.setCharacter(Teemo2);
                Console.WriteLine("\nGood Choice of Champion!\n");

            }
            else
            {
                Console.WriteLine("Please pick a champion by pressing [1], [2], [3]");
            }

            Console.WriteLine(player2Name + " Choose your weapon [1] Vandal  [2] Operator  [3]  Guardian :");
            String selectedWeapon2 = Console.ReadLine();
            if (selectedWeapon2.Equals("1"))
            {
                Weapon Vandal2 = WeaponFactory.createVandal(75, 150, "Vandal");
                player2.getCharacter().setWeapon(Vandal2);
                Console.WriteLine("\nGood Choice of Weapon!\n");


            }
            else if (selectedWeapon2.Equals("2"))
            {
                Weapon Operator2 = WeaponFactory.createOperator(150, 150, "Operator");
                player2.getCharacter().setWeapon(Operator2);
                Console.WriteLine("\nGood Choice of Weapon!\n");
            }
            else if (selectedWeapon2.Equals("3"))
            {
                Weapon Guardian2 = WeaponFactory.createGuardian(125, 150, "Guardian");
                player2.getCharacter().setWeapon(Guardian2);
                Console.WriteLine("\nGood Choice of Weapon!\n");
            }else
            {
                Console.WriteLine("Please pick a weapon by pressing [1], [2], [3]");
            }


            Console.Clear();
            doBattle(player1, player2);
        }


        public static void doBattle(Player player1, Player player2)
        {
            Ability previousAbility1 = null;
            Ability previousAbility2 = null;

            while (player1.getCharacter().getHp() > 0 && player2.getCharacter().getHp() > 0)
            {

                //Player 1 Turn
                Console.WriteLine("Player 1 turn");

                Console.WriteLine("Your current stats: ");
                Console.Write("HP: " + player1.getCharacter().getHp() + "\nMana: " + player1.getCharacter().getMana() + "\nAmmo: " + player1.getCharacter().getWeapon().getWeaponAmmo() + "\n");

                Console.WriteLine("Choose your attack [1] Weapon  [2] Ability [3] Items");
                string attackChosen1 = Console.ReadLine();

                if (attackChosen1.Equals("1"))
                {

                    player1.getCharacter().getWeapon().useWeapon(player1, player2);
                    previousAbility1 = null;
                }
                else if (attackChosen1.Equals("2"))
                {

                    Console.WriteLine("Your Abilities: ");
                    if (player1.getCharacter().getAbilityNames().Length > 0)
                    {
                        for (int i = 0; i < player1.getCharacter().getAbilityNames().Length; i++)
                        {
                            Console.WriteLine("[" + i + "] " + player1.getCharacter().getAbilityNames()[i]);
                        }
                    }
                    Console.WriteLine("Choose your ability: ");
                    int choice = int.Parse(Console.ReadLine());

                    player1.getCharacter().getAbility(player1.getCharacter().getAbilityNames()[choice]).useAbility(player1, player2, previousAbility1);
                    previousAbility1 = player1.getCharacter().getAbility(player1.getCharacter().getAbilityNames()[choice]);
                }
                else
                {
                    Console.WriteLine("Your Items: ");
                    if (player1.getCharacter().getItemNames().Length > 0)
                    {
                        for (int i = 0; i < player1.getCharacter().getItemNames().Length; i++)
                        {
                            Console.WriteLine("[" + i + "] " + player1.getCharacter().getItemNames()[i]);
                        }
                        Console.WriteLine("Choose your Item: ");
                        int choice = int.Parse(Console.ReadLine());

                        player1.getCharacter().getItem(player1.getCharacter().getItemNames()[choice]).useItem(player1, player2);
                        previousAbility1 = null;
                    }
                }


                //Player 2 Turn
                Console.WriteLine("player 2 turn");

                Console.WriteLine("Your current stats: ");
                Console.WriteLine("HP: " + player2.getCharacter().getHp() + "\nMana: " + player2.getCharacter().getMana() + "\nAmmo: " + player2.getCharacter().getWeapon().getWeaponAmmo() + "\n");

                Console.WriteLine("Choose your attack [1] Weapon  [2] Ability [3] Item");
                string attackChosen2 = Console.ReadLine();

                if (attackChosen2.Equals("1"))
                {
                    player2.getCharacter().getWeapon().useWeapon(player2, player1);


                    previousAbility2 = null;
                }
                else if (attackChosen2.Equals("2"))
                {

                    Console.WriteLine("Your Abilities: ");
                    if (player2.getCharacter().getAbilityNames().Length > 0)
                    {
                        for (int i = 0; i < player2.getCharacter().getAbilityNames().Length; i++)
                        {
                            Console.WriteLine("[" + i + "] " + player2.getCharacter().getAbilityNames()[i]);
                        }
                    }
                    Console.WriteLine("Choose your ability: ");
                    int choice = int.Parse(Console.ReadLine());

                    player2.getCharacter().getAbility(player2.getCharacter().getAbilityNames()[choice]).useAbility(player2, player1, previousAbility2);
                    previousAbility2 = player2.getCharacter().getAbility(player2.getCharacter().getAbilityNames()[choice]);
                }
                else
                {
                    Console.WriteLine("Your Items: ");
                    if (player2.getCharacter().getItemNames().Length > 0)
                    {
                        for (int i = 0; i < player2.getCharacter().getItemNames().Length; i++)
                        {
                            Console.WriteLine("[" + i + "] " + player2.getCharacter().getItemNames()[i]);
                        }
                        Console.WriteLine("Choose your Item: ");
                        int choice = int.Parse(Console.ReadLine());

                        player2.getCharacter().getItem(player2.getCharacter().getItemNames()[choice]).useItem(player2, player1);
                        previousAbility1 = null;
                    }
                }


            }

            if (player2.getCharacter().getHp() <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                string random24 = @"   ___                            _         _       _   _                    _ 
  / __\___  _ __   __ _ _ __ __ _| |_ _   _| | __ _| |_(_) ___  _ __  ___   / \
 / /  / _ \| '_ \ / _` | '__/ _` | __| | | | |/ _` | __| |/ _ \| '_ \/ __| /  /
/ /__| (_) | | | | (_| | | | (_| | |_| |_| | | (_| | |_| | (_) | | | \__ \/\_/ 
\____/\___/|_| |_|\__, |_|  \__,_|\__|\__,_|_|\__,_|\__|_|\___/|_| |_|___/\/   
                  |___/                                                        ";

                foreach (char e in random24)
                {
                    Console.Write(e);
                    System.Threading.Thread.Sleep(5);
                }

                Console.WriteLine("Player 1 has Won the Game!");
            }
            else if (player1.getCharacter().getHp() <= 0)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                string random24 = @"   ___                            _         _       _   _                    _ 
  / __\___  _ __   __ _ _ __ __ _| |_ _   _| | __ _| |_(_) ___  _ __  ___   / \
 / /  / _ \| '_ \ / _` | '__/ _` | __| | | | |/ _` | __| |/ _ \| '_ \/ __| /  /
/ /__| (_) | | | | (_| | | | (_| | |_| |_| | | (_| | |_| | (_) | | | \__ \/\_/ 
\____/\___/|_| |_|\__, |_|  \__,_|\__|\__,_|_|\__,_|\__|_|\___/|_| |_|___/\/   
                  |___/                                                        ";

                foreach (char e in random24)
                {
                    Console.Write(e);
                    System.Threading.Thread.Sleep(5);
                }

                Console.WriteLine("Player 2 has Won the Game!");

                Console.Clear();
            }
        }

    }
}
