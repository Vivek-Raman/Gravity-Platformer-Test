using UnityEngine;

public class StateMachine : MonoBehaviour
 {
     [SerializeField] private State initialState = null;
     private State currentState = null;
     
     private void Start()
     {   
         // sets initial state as current state
         SetState(initialState);
     }
 
     /// <summary>
     /// Transitions to the given state
     /// </summary>
     /// <param name="state">State to transition to</param>
     public void SetState(State state)
     {
         if (state == null)
         {
             return;
         }
         
         currentState.OnStateExit();
         currentState = state;
         currentState.OnStateEnter();
     }
     
     private void Update()
     {
         currentState.Tick();
     }
 }