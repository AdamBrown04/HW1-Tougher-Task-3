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
    character player = new character();

    Console.WriteLine("Enter your character's name: ");
    player.characterName = Console.ReadLine();
    if (player.characterName != "")
    {
        Console.WriteLine("Pass");
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
    public string characterName = "";
    public float characterHealth = 3.0f; //float as you could take 1.5 damage instead of just whole numbers/allows greater attack variety 
    public float characterHealthRegeneration = 0.1f; //float as health is float
    public int movementSpeed = 1; 
} 