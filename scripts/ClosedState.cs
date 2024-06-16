using Godot;
using System;

public partial class ClosedState : State
{
    public override void Enter()
    {
        // Make chest visible
        GetNode<Node3D>("chestBrownClosed").Visible = true;
        GetNode<GpuParticles3D>("Sparkles").Emitting = true;
        GetNode<Timer>("Timer").Start();
    }

    public override void Exit()
    {
        GetNode<Node3D>("chestBrownClosed").Visible = false;
        GetNode<GpuParticles3D>("Sparkles").Emitting = false;
        GetNode<Timer>("Timer").Stop();
    }

    private void _OnArea3DInputEvent(Camera3D camera, InputEvent @event, Vector3 clickPosition, Vector3 clickNormal, long shapeIdx) 
    {
        if (@event is InputEventMouseButton btn && btn.ButtonIndex == MouseButton.Left && @event.IsPressed()) {
            GD.Print("Clicked chest");
            fsm.TransitionTo("Shaking");
        }
    }
}
