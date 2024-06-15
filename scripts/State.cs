using Godot;
using System;

public partial class State : Node
{
    // Public reference to a state machine instance so any state can trigger it to transition to another state
    public StateMachine fsm;

    public virtual void Enter() {};
    public virtual void Exit() {};
    
    public virtual void Ready() {};
    public virtual void Update(float delta) {};
    public virtual void PhysicsUpdate(float delta) {};
    public virtual void HandleInput(InputEvent @event) {};
}
