namespace RuethRaknasaRPG;
using System.Collections;
using System;
using System.Collections.Generic;

public class Spel
{
    //variabler
    private bool _end;
    public bool End
    {
        get{ return this._end; }
        set{ this._end = value; }
    }
    
    private Stack<State> states;
    private ArrayList characterList;
    
    //privata funktioner
    private void InitVariables()
    {
        this._end = false;
    }
    
    private void InitCharacterList()
    {
        this.characterList = new ArrayList();
    }
    
    private void InitStates()
    {
        this.states = new Stack<State>();
        /*Console.WriteLine(this.states.GetHashCode());*/
        
        //Push the first state
        this.states.Push(new StateMainMenu(this.states, this.characterList));
    }
    
    //Constructors and destructors
    public Spel()
    {
     this.InitVariables();
     this.InitCharacterList();
     this.InitStates();
    }

    public void Run()
    {
        //game loop
        while (this.states.Count > 0)
        {
                this.states.Peek().Update(); //(this.states.Count > 0)

                if (this.states.Peek().requestEnd())
                    this.states.Pop();
        }
        //game over
        Console.WriteLine("\n\tSpelet är över...");
    }
}