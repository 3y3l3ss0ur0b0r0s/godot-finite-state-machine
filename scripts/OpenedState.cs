using Godot;
using System;

public partial class OpenedState : State
{

    [Export] public AnimationPlayer animationPlayer;
    [Export] public AudioStreamPlayer3D audioStreamPlayer3D;

    public override void Enter()
    {
        // Start Timer node
        GetNode<Node3D>("chestBrownOpened").Visible = true;
        // Play sound
        GetNode<AudioStreamPlayer3D>("OpenedSound").Play();
        // Play animation
        animationPlayer.Play();
        // Make Light node visible
        GetNode<OmniLight3D>("Light").Visible = true;
        GetNode<Timer>("Timer").Start();
    }

    public override void Exit() 
    {
        GetNode<Node3D>("chestBrownOpened").Visible = false;
        GetNode<OmniLight3D>("Light").Visible = false;
        GetNode<Timer>("Timer").Stop();
    }

    private void _OnTimerTimeout() 
    {
        fsm.TransitionTo("Closed");
    }
}
