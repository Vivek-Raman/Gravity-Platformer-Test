public abstract class State
{
    /// <summary>
    /// Called on the first frame this state is set
    /// </summary>
    public virtual void OnStateEnter()
    {
        
    }

    /// <summary>
    /// Called every frame by the StateMachine
    /// </summary>
    public abstract void Tick();

    /// <summary>
    /// Called on the last frame this state is set
    /// </summary>
    public virtual void OnStateExit()
    {
        
    }
    
}