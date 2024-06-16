using Godot;
using System;

public partial class ChestClickManager : StaticBody3D
{
	private void _OnInputEvent(Node camera, InputEvent @event, Vector3 position, Vector3 normal, long shapeIdx) {
		if (@event is InputEventMouseButton mouseEvent) {
			GD.Print("Chest clicked");
			Events.Emit_ChestClicked();
		}
	}
}
