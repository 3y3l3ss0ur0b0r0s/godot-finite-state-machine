using Godot;
using System;

public partial class Events : Node
{
	public static event EventHandler ChestClicked;

	public static void Emit_ChestClicked()
		=> ChestClicked.Invoke(null, EventArgs.Empty);
}
