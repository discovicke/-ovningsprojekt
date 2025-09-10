namespace RuethRaknasaRPG;
using System.Collections;
using System;
using System.Collections.Generic;

public class StateGame 
    : State
{
    private ArrayList characterList;
    
    public StateGame(Stack<State> states, ArrayList _characterList)
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
        }
    }
    
    override public void Update()
    {
        GUI.MenuTitle("Game State");
        GUI.MenuOption(1, "Skapa karaktär");
        GUI.MenuOption(-1, "Avsluta");
        
        GUI.GetInput("Skriv ett nummer");
        
        //Update the state
        Console.WriteLine("[GAME]\tSkriv ett nummer: ");
        int nummer = int.Parse(Console.ReadLine()); //TryParse(Console.ReadLine())
        
        
        this.ProcessInput(nummer);
        
    }
}