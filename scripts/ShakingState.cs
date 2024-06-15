using Godot;
using System;

public partial class ShakingState : State
{
    [Export] public AnimationPlayer animationPlayer;

    public override void Enter()
    {
        // Make chest visible
        GetNode<Node3D>("chestBrownClosed").Visible = true;
        // Play animation
        animationPlayer.Play();
        // Make Light node visible
        GetNode<OmniLight3D>("Light").Visible = true;
        // Start Timer node
        GetNode<Timer>("Timer").Start();
    }

    public override void Exit() {
        GetNode<Node3D>("chestBrownClosed").Visible = false;
        GetNode<OmniLight3D>("Light").Visible = false;
        GetNode<Timer>("Timer").Stop();
    }

    private void _OnTimerTimeout() 
    {
        fsm.TransitionTo("Opened");
    }
}
