using Godot;
using System;

public partial class ClosedState : State
{
    public override void Enter()
    {
        // Make chest visible
        GetNode<Node3D>("chestBrownClosed").Visible = true;
        // Make Light node visible
        GetNode<Node3D>("Light").Visible = true;
        // Start Timer node
        GetNode<Timer>("Timer").Start();
    }

    public override void Exit() {
        GetNode<Node3D>("chestBrownClosed").Visible = false;
        GetNode<Node3D>("Light").Visible = false;
        GetNode<Timer>("Timer").Stop();
    }

    private void _OnTimerTimeout() 
    {
        fsm.TransitionTo("Shaking");
    }
}
