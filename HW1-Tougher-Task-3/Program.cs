//Write classes and create example objects for the following game. At the start of the game the player gets to choose their name.
//They start off with 3 health, a movement speed of 1, and a health regeneration speed of 0.1. All of these can be upgraded during play.
//There are lots of different weapons in the game, but all can be represented the same way, with a name, a strength, and a durability.
//The player is capable of holding a single weapon at a time. 
Console.WriteLine("Hello! Would you like to play this text based game? Y/N");
string playGame = Console.ReadLine();
string playGameUpper = playGame.ToUpper();

character player = new character();
Random random = new Random();

bool welcomed = false;

Console.Clear();

while (playGameUpper == "Y")
{

    while (player.characterName == "")
    {
        Console.Write("Enter your character's name: ");
        player.characterName = Console.ReadLine();
        Console.Clear();
    }
    if (welcomed == false)
    {
        Console.WriteLine($"Hello { player.characterName}");
        welcomed = true;
    }
    Console.WriteLine($"What would you like to do {player.characterName}? \n1) Train Strength \n2) Train Speed" +
        $" \n3) Fight \n4) Shop \n5) Stats \n6) Exit");
    string option = Console.ReadLine();

    switch (option)
    {
        case ("1"):
            int chanceOfStrengthIncrease = random.Next(1, 101);
            if (chanceOfStrengthIncrease >= 80)
            {
                player.characterStrength = player.characterStrength + 1;
                Console.WriteLine($"Well done! Your training was successful and your stregnth was increased! \nYour new strength is {player.characterStrength}");
                Task.Delay(3000).Wait();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Unfortunately your stregnth didn't increase this time");
                Task.Delay(2000).Wait();
                Console.Clear();
            }
            break;
        case ("2"):
            int chanceOfSpeedIncrease = random.Next(1, 101);
            if (chanceOfSpeedIncrease >= 80)
            {
                player.movementSpeed = player.movementSpeed + 1;
                Console.WriteLine($"Well done! Your training was successful and your movement speed was increased! " +
                    $"\nYour new strength is {player.movementSpeed}");
                Task.Delay(3000).Wait();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Unfortunately your movement speed didn't increase this time");
                Task.Delay(2000).Wait();
                Console.Clear();
            }
            break;
        case ("3"):
            //wip
            break;
        case ("4"):
            Task.Delay(500).Wait();
            Console.Clear();
            Console.WriteLine("Hello adventurer! \nWhat would you like to do? \n1) Buy mythic quality weapon (2000 gold) " +
                "\n2) Buy high quality weapon (1250 gold)\n3) Buy meduim quality weapon (750 gold) \n4) Buy low quality weapon (300 gold)" +
                "\n5) Back");
            int buyWeaponChoice = Convert.ToInt32(Console.ReadLine());

            switch (buyWeaponChoice) 
            {
                case 1:
                    player.money = player.money - 2000;
                    break;
                case 2:
                    player.money = player.money - 1250;
                    break;
                case 3:
                    player.money = player.money - 750;
                    break;
                case 4:
                    player.money = player.money - 300;
                    break;
                case 5:
                    Console.WriteLine("Returning to main menu");
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid input! Returning to main menu");
                    Task.Delay(2000).Wait();
                    Console.Clear();
                    break;
            }

            break;
        case ("5"):
            showStats();
            break;
        case ("6"):
            playGameUpper = "GameEnded";
            break;
        default:
            Console.WriteLine("Please enter one of the options");
            break;

    }

}
    if(playGameUpper == "GameEnded")
{
    Console.WriteLine("I hope you've had fun and come back soon");
}
else
{
    Console.WriteLine("That's ok, maybe a different time then");
}


void showStats()
{
    Console.WriteLine($"\nYour character stats are: \nHealth: {player.characterHealth} " +
        $"\nHealth Regeneration: {player.characterHealthRegeneration} \nMovement speed: {player.movementSpeed} \nStrength: {player.characterStrength}" +
        $"\nMoney: {player.money}");
}


class character
{
    public string characterName = ""; //name of the character, only used for dialogue
    public bool holdingWeapon = false; //sees if the player is currently holding a weapon
    public float characterHealth = 5.0f; //how much health the character has 
    public float characterHealthRegeneration = 0.1f; //how much health the character regenerates each turn
    public int money = 500; //amount of in-program currency the character has
    public int movementSpeed = 3; //how fast the character moves
    public int characterStrength = 3; //affects the melee damage of a character
                                      //e.g. if a club has 5 damage the strength would be added on top making it 8.
} 

class weapon
{
    public string weaponName = "";
    public int weaponStrength = 1;
    public int weaponDurability = 10;
}

//Console.Clear(); use to delete all text on screen ref: asked Oliver CW
//Task.Delay().Wait(); use to make program pause ref: stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
