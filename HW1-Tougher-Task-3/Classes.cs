class Character
{
    public string characterName = ""; //name of the character, only used for dialogue
    public string weaponRarityType = ""; //This is used to show that stats of weapons
    public bool holdingWeapon = false; //sees if the player is currently holding a weapon
    public float characterHealth = 5.0f; //how much health the character has 
    public float characterHealthRegeneration = 0.1f; //how much health the character regenerates each turn
    public int money = 500; //amount of in-program currency the character has
    public int movementSpeed = 3; //how fast the character moves
    public int characterStrength = 3; //affects the melee damage of a character
                                      //e.g. if a weapon has 5 damage the strength would be added on top making it 8.
}

class Weapon
{
    public string weaponName = ""; //no weapon names implemented yet (could use to distinguish types of weapon)
    public int weaponStrength; //how much damage the weapon does by itself
    public int weaponDurability; //how many hits the weapon can do before it breaks (may add a repair feature)
}

class Enemy : Character
{
    public string enemyDifficulty = ""; //the level of difficulty of the enemy 
}
