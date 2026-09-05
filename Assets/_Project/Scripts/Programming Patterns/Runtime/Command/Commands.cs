namespace Patterns.Command
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
        void Redo();
    }
}
