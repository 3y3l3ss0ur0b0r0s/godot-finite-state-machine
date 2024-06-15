using Godot;
using System;
using System.Collections.Generic;

public partial class StateMachine : Node
{
    [Export] public NodePath initialState;

    /*
        Called when node initially enters scene
        param: N/A
        return: N/A
    */
    public override void _Ready()
    {

    }

    /*
        Called every frame
        param: Elapsed time as double delta
        return: N/A
    */
    public override void _Process(double delta)
    {
   
    }
}
