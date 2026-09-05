namespace Patterns.StateMachine.StateMachine {
    public interface IState {
        void OnEnter(IState from = null) { }
        void OnExit() { }
        void Update() { }
        void FixedUpdate() { }
    }
}