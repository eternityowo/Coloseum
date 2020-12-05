namespace Coloseum.Components.Events.InputEvents
{
    internal struct InputMoveEvent
    {
        public int PlayerNumber;
        public MoveState State;
        public float Axis;
    }

    enum MoveState
    {
        Horizontal,
        Vertical,
        Stop
    }
}