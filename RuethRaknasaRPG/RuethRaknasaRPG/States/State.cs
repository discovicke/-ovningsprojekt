using System.Collections;
using System;
using System.Collections.Generic;

namespace RuethRaknasaRPG;

public class State
{
    protected Stack<State> states;
    protected bool _end = false;
    
    //State stack
    public State(Stack<State> states)
    {
        this.states = states;
        
        /*Console.WriteLine(this.states.GetHashCode());*/ //Debug line för att se om staten pushats rätt
        
    }

    public bool requestEnd()
    {
        return this._end;
    }

    virtual public void Update()
    {
        //Update the state
        
    }
    
}