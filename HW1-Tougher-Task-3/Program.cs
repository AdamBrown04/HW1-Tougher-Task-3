//Write classes and create example objects for the following game. At the start of the game the player gets to choose their name.
//They start off with 3 health, a movement speed of 1, and a health regeneration speed of 0.1. All of these can be upgraded during play.
//There are lots of different weapons in the game, but all can be represented the same way, with a name, a strength, and a durability.
//The player is capable of holding a single weapon at a time. 
Console.WriteLine("Hello! Would you like to play this text based game? Y/N");
string playGame = Console.ReadLine();
string playGameUpper = playGame.ToUpper();

character player = new character();
Random random = new Random();

while (playGameUpper == "Y")
{

    while (player.characterName == "")
    {
        Console.WriteLine("Enter your character's name: ");
        player.characterName = Console.ReadLine();
    }
    Console.WriteLine($"Hello {player.characterName} \nYour character stats are: \nHealth: {player.characterHealth} " +
        $"\nHealth Regeneration: {player.characterHealthRegeneration} \nMovement speed: {player.movementSpeed} \nStrength: {player.characterStrength}" +
        $"\nMoney: {player.money} \n\nWhat would you like to do? \n1) Train \n2) Fight \n3) Shop \n4) Exit");
    string option = Console.ReadLine();

    switch (option)
    {
        case ("1"):
            int chanceOfStrengthIncrease = random.Next(1, 7);
            if (chanceOfStrengthIncrease >= 5)
            {
                player.characterStrength = player.characterStrength + 1;
                Console.WriteLine($"Well done! Your training was successful and your stregnth was increased! \nYour new strength is {player.characterStrength}");
            }
            else
            {
                Console.WriteLine("Unfortunately your stregnth didn't increase this time");
            }
            break;
        case ("2"):
            //wip
            break;
        case ("3"):
            //wip
            break;
        case ("4"):
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
    


class character
{
    public string characterName = ""; //name of the character, only used for dialogue
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

//Console.Clear(); use to delete all text on screen
