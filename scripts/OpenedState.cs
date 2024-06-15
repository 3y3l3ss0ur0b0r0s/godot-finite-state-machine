using Godot;
using System;

public partial class OpenedState : State
{
    public override void Enter()
    {
        // Start Timer node
        GetNode<Timer>("Timer").Start();
    }

    public override void Exit() {
        GetNode<Timer>("Timer").Stop();
    }

    private void _OnTimerTimeout() 
    {
        fsm.TransitionTo("Closed");
    }
}
