using Godot;
using System;
using System.Collections.Generic;

public partial class StateMachine : Node
{
    [Export] public NodePath initialState;

    private Dictionary<string, State> _states;
    private State _currentState;

    /*
        Called when node initially enters scene
        param: N/A
        return: N/A
    */
    public override void _Ready()
    {
        // Load collection
        _states = new Dictionary<string, State>();

        // Go tthrough each state
        foreach (Node node in GetChildren()) {
            // Call .Ready() and .Exit() for the current state object
            if (node is StateMachine s) {
                _states[node.Name] = s;
                s.fsm = this;

                // Initialize
                s.Ready();

                // Reset
                s.Exit();
            }
        }

        // Get the correct state and call its .Enter() method
        _currentState = GetNode<State>(initialState);
        _currentState.Enter();
    }

    /*
        Called every frame
        param: Elapsed time as double delta
        return: N/A
    */
    public override void _Process(double delta)
    {
        _currentState.Update((float) delta);   
    }

    public override void _PhysicsProcess(double delta)
    {
        _currentState.PhysicsUpdate((float) delta);
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        _currentState.HandleInput(@event);
    }

    /*
        Transition between states
        param: Current state as string key
        return: N/A
    */
    public void TransitionTo(string key)
    {
        // Make sure key provided exists
        if (!_states.ContainsKey(key) || _currentState == _states[key])
            return;

        // Get out of current state
        _currentState.Exit();
        // Set new current state
        _currentState = _states[key];
        // Enter the new current state
        _currentState.Enter();
    }
}
