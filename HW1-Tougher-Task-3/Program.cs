//Write classes and create example objects for the following game. At the start of the game the player gets to choose their name.
//They start off with 3 health, a movement speed of 1, and a health regeneration speed of 0.1. All of these can be upgraded during play.
//There are lots of different weapons in the game, but all can be represented the same way, with a name, a strength, and a durability.
//The player is capable of holding a single weapon at a time. 

Console.WriteLine("Welcome player! What is your name?");
string userName = Console.ReadLine();

Console.WriteLine($"Hello {userName}! Would you like to play this text based adventure game? Y/N");
string playGame = Console.ReadLine();
string playGameUpper = playGame.ToUpper();

if (playGameUpper == "Y")
{
    Console.WriteLine("Enter your character's name: ");
    string  characterName = Console.ReadLine();
    if (characterName != "")
    {
        Console.WriteLine($"What class would you like {characterName} to be?");
        string classChoice = Console.ReadLine();
        string classChoiceLower = classChoice.ToLower();
        if (classChoiceLower == "mage")
        {
            mage player = new mage();
            player.characterName = characterName;
        }
        else if (classChoiceLower == "barbarian")
        {
            barbarian player = new barbarian();
            player.characterName = characterName;
        }
        else if (classChoiceLower == "rouge")
        {
            rouge player = new rouge();
            player.characterName = characterName;
        }
    }
    else
    {
        Console.WriteLine("Error: incorrect input");
    }

}
else if (playGameUpper == "N")
{
    Console.WriteLine($"That's ok, maybe a different time then {userName}");
}
else
{
    Console.WriteLine("Error: incorrect input");
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

class mage : character
{
    public float characterHealthRegeneration = 0.3f;
    public int characterStrength = 2;
}

class barbarian : character
{
    public float characterHealth = 4.0f;
    public int movementSpeed = 1;
    public int characterStrength = 5;
}

class rouge : character
{
    public float characterHealth = 2.0f;
    public int movementSpeed = 3;
    public float characterHealthRegeneration = 0.2f;
}
