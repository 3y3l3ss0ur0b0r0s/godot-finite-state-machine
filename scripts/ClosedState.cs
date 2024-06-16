using Godot;
using System;

public partial class ClosedState : State
{
    public override void Enter()
    {
        // Make chest visible
        GetNode<Node3D>("chestBrownClosed").Visible = true;
        GetNode<GpuParticles3D>("Sparkles").Emitting = true;
    }

    public override void Exit() {
        GetNode<Node3D>("chestBrownClosed").Visible = false;
        GetNode<GpuParticles3D>("Sparkles").Emitting = false;
    }

    public override void Ready()
    {
        Events.ChestClicked += _OnChestClicked;
    }

    public void _OnChestClicked(object sender, EventArgs e) {
        fsm.TransitionTo("Shaking");
    }
}
