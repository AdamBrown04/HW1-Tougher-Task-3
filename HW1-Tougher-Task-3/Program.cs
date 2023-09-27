//Write classes and create example objects for the following game. At the start of the game the player gets to choose their name.
//They start off with 3 health, a movement speed of 1, and a health regeneration speed of 0.1. All of these can be upgraded during play.
//There are lots of different weapons in the game, but all can be represented the same way, with a name, a strength, and a durability.
//The player is capable of holding a single weapon at a time. 
Console.WriteLine("Hello! Would you like to play this text based game? Y/N");
string playGame = Console.ReadLine();
string playGameUpper = playGame.ToUpper();

if (playGameUpper == "Y")
{
    character player = new character();

    Console.WriteLine("Enter your character's name: ");
    player.characterName = Console.ReadLine();
    if (player.characterName != "")
    {
        Console.WriteLine($"Welcome {player.characterName}! Welcome to the land of Anglia! \nHow did you get here? \n. . . " +
            $"\nThat doesn't matter \nWhat does matter is the re- \nWho am I? \n. . . \nLets just say I'm your guide \nAnyways, where was I? " +
            $"\nAhh yes, the reason why you're here! \nYou are here to vanquish Hell's beasts from this land!");
    }
    else
    {
        Console.WriteLine("Error: incorrect input");
    }

}
else if (playGameUpper == "N")
{
    Console.WriteLine("That's ok, maybe a different time then");
}

class character
{
    public string characterName = ""; //name of the character, only used for dialogue
    public float characterHealth = 3.0f; //how much health the character has 
    public float characterHealthRegeneration = 0.1f; //how much health the character regenerates each turn
    public int movementSpeed = 2; //how fast the character moves
    public int characterStrength = 3; //affects the melee damage of a character
                                      //e.g. if a club has 5 damage the strength would be added on top making it 8.
} 

class weapon
{
    public string weaponName = "";
    public int weaponStrength = 0;
    public int weaponDurability = 1;
}
