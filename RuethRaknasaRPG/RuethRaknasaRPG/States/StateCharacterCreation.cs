namespace RuethRaknasaRPG;
using System.Collections;
using System;
using System.Collections.Generic;
public class StateCharacterCreation
    : State
{
    //variabler
    ArrayList characterList;
    //privata funktioner
    private void CreateCharacter()
    {
        String name = "";
        String description = "";
        GUI.GetInput("Vad heter du?\t");
        name = Console.ReadLine();
        GUI.GetInput("Berätta lite om dig själv och vad som har hänt hittills.\t"); 
        description = Console.ReadLine();

        
        this.characterList.Add(new Character(name, description));;
                    
        GUI.Announcement("Karaktär skapad!");
    }

    
    public StateCharacterCreation(Stack<State> states, ArrayList _characterList)
        : base(states) 
    {
    
    
    
        this.characterList = _characterList;
        //Push the next state
        /*this.states.Push(new StateGame(this.states));*/
    }
   
    public void ProcessInput(int nummer) 
        {
            switch (nummer)
            {
                case -1:
                    this._end = true;
                    break;
                case 1:
                    this.CreateCharacter();
                    break;
        }
        }
    
 
    override public void Update()
        {
            GUI.MenuTitle("Karaktärsskapare");
            GUI.MenuOption(1, "Skapa karaktär");
            GUI.MenuOption(2, "Ändra karaktär");
            GUI.MenuOption(3, "Radera karaktär");
            GUI.MenuOption(-1, "Avsluta");
        
            GUI.GetInput("Skriv ditt val:\t");
            int nummer = int.Parse(Console.ReadLine()); //TryParse(Console.ReadLine())
    
        
            this.ProcessInput(nummer);
        }
}