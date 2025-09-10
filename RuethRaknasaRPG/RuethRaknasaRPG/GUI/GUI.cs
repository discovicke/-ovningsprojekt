namespace RuethRaknasaRPG;

public class GUI
{
    public static void Title(String str)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        str = String.Format("====\t{0}\t=====\n", str);
       
        Console.Write(str);
        Console.ResetColor();
    }
    
    public static void MenuTitle(String str)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        str = String.Format(" === {0} ===\n", str);
       
        Console.Write(str);
        Console.ResetColor();
    }    
    
    public static void MenuOption(int val, String str)
    {
        str = String.Format(" - ({0}) : {1} \n", val, str);
       
        Console.Write(str);
    }
    public static void Announcement(String str)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        str = String.Format("\t(~) ({0})!\n", str);
       
        Console.Write(str);
        Console.ResetColor();
    }

    public static void GetInput(String str)
    {
        
        str = String.Format(" - {0} : ", str);
        
        Console.Write(str);
        
    }
    
}