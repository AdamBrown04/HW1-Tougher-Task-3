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
        Console.WriteLine($"Welcome {player.characterName}! This is the land of Anglia! You ar-\nHow did you get here? \n. . . " +
            $"\nThat doesn't matter, what does matter is the re- \nWho am I? \n. . . \nLets just say I'm your mentor \nAnyways, where was I? " +
            $"\nAhh yes, the reason why you're here! \nYou are here to save this land from raiders and many other of those evil types." +
            $"\nBut before we get onto that I must ensure you are trained correctly for the task ahead!" +
            $"\nFirst off lets work on your strength, after all you can barely lift up a sword never mind swing one!");
        
        Console.WriteLine("\nSo how are you going to train? \n*1)Idle as a sloth (strength stays the same) " +
            "\n2)Getting stuck in (strength increases by 1) \n3)Become a one man army (strength increase by 2 but movement speed decreases by 1)*");
        int strengthTraining = Convert.ToInt32(Console.ReadLine());
        switch (strengthTraining)
        {
            case (1):
                Console.WriteLine("What's your plan here then? \nBeat your foes by playing dead?");
                break;
            case (2):
                player.characterStrength = 4;
                Console.WriteLine($"Well done! We're finally getting somewhere \n*Your strength is {player.characterStrength}*");
                break;
            case (3):
                player.characterStrength =5;
                player.movementSpeed = 2;
                Console.WriteLine($"Bloody hell, I know I said to get stronger but this is something else! " +
                    $"\n*Your strength is {player.characterStrength} and your movement speed is {player.movementSpeed}*");
                break;
            default:
                Console.WriteLine("What are you even trying to do? That's not an option");
                break;
        }
        
        Console.WriteLine("\nNow that you have completed your first stage of training I feel like it's time to give you a weapon" +
            "\nI'm going to give you what every great hero starts with, you're going to ha- \nA sword!? Are you mad? You're no where good" +
            "enough for a sword! \nI'm going to give you a wooden stick! \n*You take the wooden stick*");
        weapon woodenStick = new weapon();
        woodenStick.weaponName = "A heros first weapon";
        woodenStick.weaponStrength = 1;
        woodenStick.weaponDurability = 500;

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
    public int movementSpeed = 3; //how fast the character moves
    public int characterStrength = 3; //affects the melee damage of a character
                                      //e.g. if a club has 5 damage the strength would be added on top making it 8.
} 

class weapon
{
    public string weaponName = "";
    public int weaponStrength = 0;
    public int weaponDurability = 1;
}
