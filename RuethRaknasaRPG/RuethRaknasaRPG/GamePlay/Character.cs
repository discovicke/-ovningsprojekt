namespace RuethRaknasaRPG;

public class Character
{
    //CORE
    private String name             = "";
    private String description      = "";
    private int level               = 0;
    private int attributePoints     = 3;
    private int exp                 = 0;
    private int expMax              = 100;
    
    //Attributes
    private int strength            = 1;
    private int intelligence        = 1;
    private int wisdom              = 1;
    private int dexterity           = 1;
    private int constitution        = 1;
    private int charisma            = 1;
    
    //Stats
    private int hp                  = 0;
    private int hpMax               = 10;
    private int damage              = 0;
    private int damageMax           = 0;
    private int accuracy            = 0;
    private int defence             = 0;
    
    //General
    private int gold                = 100;
    private int inventory           = 0;
    private int inventoryMax        = 100;

    private void CalculateExp()
    {
        this.exp = this.level * 100;
    }
    
    private void CalculateStats()
    {
      this.hp= this.constitution * 10;
      this.damage = (int)(2 + Math.Sqrt(strength) + Math.Sqrt(intelligence) + Math.Sqrt(wisdom));
      this.damageMax = this.strength + this.intelligence * 2;
      this.accuracy = this.dexterity + this.wisdom * 2;
      this.defence = this.constitution + this.dexterity;
      this.inventoryMax = this.strength * 6;
    }
    
    public Character(String name, String description)
    {
        this.CalculateStats();
        
        this.name = name;
        this.description = description;
    }

    public String toString()
    {
        
        return this.name;
    }
}