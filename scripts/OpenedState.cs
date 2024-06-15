using Godot;
using System;

public partial class OpenedState : State
{

    [Export] public AnimationPlayer animationPlayer;

    public override void Enter()
    {
        // Start Timer node
        GetNode<Node3D>("chestBrownOpened").Visible = true;
        // Play animation
        animationPlayer.Play();
        GetNode<Timer>("Timer").Start();
    }

    public override void Exit() {
        GetNode<Node3D>("chestBrownOpened").Visible = false;
        GetNode<Timer>("Timer").Stop();
    }

    private void _OnTimerTimeout() 
    {
        fsm.TransitionTo("Closed");
    }
}
