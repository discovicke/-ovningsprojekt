namespace RuethRaknasaRPG;
using System.Collections;
using System;
using System.Collections.Generic;
public class StateMainMenu 
    : State
{
    Character character;
    
    protected ArrayList characterList;
    
    public StateMainMenu(Stack<State> states, ArrayList _characterList)
        : base(states)
    {
        this.characterList = _characterList;
    }
    
    public void ProcessInput(int nummer)
    {
        switch (nummer)
        {
            case -1:
                this._end = true;
                break;
            case 1:
                break;
            case 2:
                this.states.Push(new StateCharacterCreation(this.states, this.characterList));
                break; 
            case 3:
                Console.WriteLine(this.characterList.Count);
                break;
        }
    }

 
    override public void Update()
    {
        GUI.MenuTitle("Game State");
        GUI.MenuOption(1, "Nytt spel");
        GUI.MenuOption(2, "Skapa karaktär");
        GUI.MenuOption(3, "Se karaktärer");
        GUI.MenuOption(-1, "Avsluta");
        //Update the state
        
        GUI.GetInput("Skriv ditt val:\t");
        int nummer = int.Parse(Console.ReadLine()); //TryParse(Console.ReadLine())
        
        this.ProcessInput(nummer);
    }
}