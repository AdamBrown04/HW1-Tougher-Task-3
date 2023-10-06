//Write classes and create example objects for the following game. At the start of the game the player gets to choose their name.
//They start off with 3 health, a movement speed of 1, and a health regeneration speed of 0.1. All of these can be upgraded during play.
//There are lots of different weapons in the game, but all can be represented the same way, with a name, a strength, and a durability.
//The player is capable of holding a single weapon at a time. 
Console.WriteLine("Hello! Would you like to play this text based game? Y/N");
string playGame = Console.ReadLine();
string playGameUpper = playGame.ToUpper();
 
Character player = new Character(); //creates a new object based on character
//lines 11-14 create weapon objects for different rarities of weapons
Weapon mythicWeapon = new Weapon(); 
Weapon highWeapon = new Weapon();
Weapon meduimWeapon = new Weapon();
Weapon lowWeapon = new Weapon();
Random random = new Random(); //creats a new random oject for any number generation that will be needed

bool welcomed = false; //is used to see if a player is on their first iteration of the menu screen

Console.Clear();

while (playGameUpper == "Y")
{

    while (player.characterName == "")
    {
        Console.Write("Enter your character's name: "); //ask user what they want their characters name to be
        player.characterName = Console.ReadLine();
        Console.Clear(); //clears text from the console, this is to make it more readable
    }
    if (welcomed == false) //this sees if the player has just started the loop, if so it will welcome the player to the game
    {
        Console.WriteLine($"Hello { player.characterName}");
        welcomed = true; //changes state of welcome to ensure this code isn't ran again
    }
    Console.WriteLine($"What would you like to do {player.characterName}? \n1) Train Strength \n2) Train Speed" +
        $" \n3) Fight \n4) Shop \n5) Stats \n6) Exit"); //this is the menu system that the user will spend most of their time interacting with
    string option = Console.ReadLine(); //sees what the user wants to do

    switch (option)
    {
        case ("1"):            
            int chanceOfStrengthIncrease = random.Next(1, 101); //randomly generates the chance of the player strength increasing between 1 and 100
            if (chanceOfStrengthIncrease >= 80 && player.characterStrength < 20) //player requires at least a number of 80 to increase strength (makes it harder to incerease stats) and if player strength is less than 0
            {
                player.characterStrength = player.characterStrength + 1; //increases player strenth then outputs a message informing them
                Console.WriteLine($"Well done! Your training was successful and your stregnth was increased! \nYour new strength is {player.characterStrength}");
                Task.Delay(3000).Wait(); //used so the console isn't cleared instantly but rather gives the user time to read the message
                Console.Clear();
            }
            else if (player.characterStrength == 20) //if the player strength is equal to 20 then this code is ran, this is used to try and balance the game
            {
                Console.WriteLine("You have hit maximum strength!"); //informs the user that they're at maximum strength 
                Task.Delay(2000).Wait();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Unfortunately your stregnth didn't increase this time"); //informs the user there is no change in strength
                Task.Delay(2000).Wait();
                Console.Clear();
            }
            break;
        case ("2"):
            int chanceOfSpeedIncrease = random.Next(1, 101);//randomly generates the chance of the player speed increasing between 1 and 100
            if (chanceOfSpeedIncrease >= 80 && player.movementSpeed < 20) //player requires at least a number of 80 to increase speed (makes it harder to incerease stats) and is below 20
            {
                player.movementSpeed = player.movementSpeed + 1; //increases player strenth then outputs a message informing them
                Console.WriteLine($"Well done! Your training was successful and your movement speed was increased! " +
                    $"\nYour new strength is {player.movementSpeed}");
                Task.Delay(3000).Wait();
                Console.Clear();
            }
            else if(player.movementSpeed == 20) //is used when the user is it at the max speed
            {
                Console.WriteLine("You are at maximum speed!");
                Task.Delay(2000).Wait();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Unfortunately your movement speed didn't increase this time"); //informs the user there is no change in speed
                Task.Delay(2000).Wait();
                Console.Clear();
            }
            break;
        case ("3"):
            //wip
            break;
        case ("4"):
            Console.Clear();
            Console.WriteLine("Hello adventurer! \nWhat would you like to do? \n1) Buy mythic quality weapon (2000 gold) " +
                "\n2) Buy high quality weapon (1250 gold)\n3) Buy meduim quality weapon (750 gold) \n4) Buy low quality weapon (300 gold)" +
                "\n5) Back"); //a menu system to see what the user wants to buy/do
            int buyWeaponChoice = Convert.ToInt32(Console.ReadLine());

            switch (buyWeaponChoice) 
            {
                case 1:
                    player.money = player.money - 2000; //removes the price of the weapon from the user
                    if (player.money >= 0 && !player.holdingWeapon) //sees if the user has enough money buy the weapon and if they're holding a weapon
                    {
                        player.holdingWeapon = true; //changes it so the palyer is now holding a weapon so they can't get anymore
                        player.weaponRarityType = "mythic"; //states the rarity of the weapon (used when showing the user the player+weapon stats)
                        mythicWeapon.weaponDurability = random.Next(18, 39); //randomly generates the weapon's durability
                        mythicWeapon.weaponStrength = random.Next(20, 36); //randomly generates the weapons strength
                        Console.WriteLine($"Your new weapon has a stregnth of {mythicWeapon.weaponStrength} and has a durability of {mythicWeapon.weaponDurability}"); //outputs weapons stats to the user
                    }
                    else if(player.money < 0) //this is used when the player doesn't have enough money 
                    {
                        Console.WriteLine("You do not have enough money to buy this weapon");
                        player.money = player.money + 2000; //refunds the cost of the weapon so the player has the money they had before the store was opened
                    }
                    else if (player.holdingWeapon)
                    {
                        Console.WriteLine("You already have a weapon equipped! You can not get another weapon"); //informs the user that they currently have a weapon and can't buy anymore
                    }
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
                case 2:
                    player.money = player.money - 1250;
                    if (player.money >= 0 && !player.holdingWeapon)
                    {
                        player.holdingWeapon = true;
                        player.weaponRarityType = "rare";
                        highWeapon.weaponDurability = random.Next(20, 31);
                        highWeapon.weaponStrength = random.Next(15, 26);
                        Console.WriteLine($"Your new weapon has a stregnth of {highWeapon.weaponStrength} and has a durability of {highWeapon.weaponDurability}");
                    }
                    else if (player.money < 0)
                    {
                        Console.WriteLine("You do not have enough money to buy this weapon");
                        player.money = player.money + 750;
                    }
                    else if (player.holdingWeapon)
                    {
                        Console.WriteLine("You already have a weapon equipped! You can not get another weapon");
                    }
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
                case 3:
                    player.money = player.money - 750;
                    if (player.money >= 0 && !player.holdingWeapon)
                    {
                        player.holdingWeapon = true;
                        player.weaponRarityType = "uncommon";
                        meduimWeapon.weaponDurability = random.Next(12, 24);
                        meduimWeapon.weaponStrength = random.Next(7, 18);
                        Console.WriteLine($"Your new weapon has a stregnth of {meduimWeapon.weaponStrength} and has a durability of {meduimWeapon.weaponDurability}");
                    }
                    else if (player.money < 0)
                    {
                        Console.WriteLine("You do not have enough money to buy this weapon");
                        player.money = player.money + 750;
                    }
                    else if (player.holdingWeapon)
                    {
                        Console.WriteLine("You already have a weapon equipped! You can not get another weapon");
                    }
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
                case 4:
                    player.money = player.money - 300;
                    if(player.money >= 0 && !player.holdingWeapon)
                    {
                        player.holdingWeapon = true;
                        player.weaponRarityType = "common";
                        lowWeapon.weaponDurability = random.Next(5, 16);
                        lowWeapon.weaponStrength = random.Next(0, 11);
                        Console.WriteLine($"Your new weapon has a stregnth of {lowWeapon.weaponStrength} and has a durability of {lowWeapon.weaponDurability}");
                    }
                    else if(player.money < 0)
                    {
                        Console.WriteLine("You do not have enough money to buy this weapon");
                        player.money = player.money + 300;
                    }
                    else if (player.holdingWeapon)
                    {
                        Console.WriteLine("You already have a weapon equipped! You can not get another weapon");
                    }
                    
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("Returning to main menu"); //this is outputted to tell the user that they're returning to the main menu
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid input! Returning to main menu"); //this is outputed if the users input is invalid
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
            }

            break;
        case ("5"):
            showStats(); //this calls the function showStats, this is used to show the current stats of the player and their weapon
            break;
        case ("6"):
            playGameUpper = "GameEnded"; //this is displayed if the user wants to exit the game
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please enter one of the options!"); //this is displayed if the user enters an invalid input
            Task.Delay(1000).Wait();
            Console.Clear();
            break;

    }

}
    if(playGameUpper == "GameEnded") //this line is run if the user leaves the program part way through a game
{
    Console.WriteLine("I hope you've had fun and come back soon");
}
else //this is displayed if the user doesn't start the game at the begging of the program
{
    Console.WriteLine("That's ok, maybe a different time then");
}


void showStats() //this is a function that will show the user the players and weapon stats
{
    Console.Clear();
    if (!player.holdingWeapon) //this will run if the user does not have a weapon
    {
        Console.WriteLine($"Your character stats are: \nHealth: {player.characterHealth} " +
                $"\nHealth Regeneration: {player.characterHealthRegeneration} \nMovement speed: {player.movementSpeed} \nStrength: {player.characterStrength}" +
                $"\nMoney: {player.money} \n\nYou currently do not have a weapon");
    }
    else //this will run if the user does have a weapon, it uses a switch case to see what sort of weapon the user has at the current calling of the function
    {
        switch (player.weaponRarityType)
        {
            case "mythic":
                Console.WriteLine($"Your character stats are: \nHealth: {player.characterHealth} " +
                $"\nHealth Regeneration: {player.characterHealthRegeneration} \nMovement speed: {player.movementSpeed} \nStrength: {player.characterStrength}" +
                $"\nMoney: {player.money} \n\nYour weapon stats are: \nWeapon damage: {mythicWeapon.weaponStrength} \nWeapon durability: {mythicWeapon.weaponDurability}" +
                $"\nWeapon rarity: {player.weaponRarityType}");
                break;
            case "rare":
                Console.WriteLine($"Your character stats are: \nHealth: {player.characterHealth} " +
                $"\nHealth Regeneration: {player.characterHealthRegeneration} \nMovement speed: {player.movementSpeed} \nStrength: {player.characterStrength}" +
                $"\nMoney: {player.money} \n\nYour weapon stats are: \nWeapon damage: {highWeapon.weaponStrength} \nWeapon durability: {highWeapon.weaponDurability}" +
                $"\nWeapon rarity: {player.weaponRarityType}");
                break;
            case "uncommon":
                Console.WriteLine($"Your character stats are: \nHealth: {player.characterHealth} " +
                $"\nHealth Regeneration: {player.characterHealthRegeneration} \nMovement speed: {player.movementSpeed} \nStrength: {player.characterStrength}" +
                $"\nMoney: {player.money} \n\nYour weapon stats are: \nWeapon damage: {meduimWeapon.weaponStrength} \nWeapon durability: {meduimWeapon.weaponDurability}" +
                $"\nWeapon rarity: {player.weaponRarityType}");
                break;
            case "common":
                Console.WriteLine($"Your character stats are: \nHealth: {player.characterHealth} " +
                $"\nHealth Regeneration: {player.characterHealthRegeneration} \nMovement speed: {player.movementSpeed} \nStrength: {player.characterStrength}" +
                $"\nMoney: {player.money} \n\nYour weapon stats are: \nWeapon damage: {lowWeapon.weaponStrength} \nWeapon durability: {lowWeapon.weaponDurability}" +
                $"\nWeapon rarity: {player.weaponRarityType}");
                break;
        }
        
    }
    Task.Delay(5000).Wait();
    Console.Clear();
}





//references for code that I have taken from others
//Console.Clear(); use to delete all text on screen ref: asked Oliver CW (another member of the class)
//Task.Delay().Wait(); use to make program pause ref: stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
