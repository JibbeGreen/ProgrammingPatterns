namespace ProgrammingPatterns 
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
        void Redo();
    }
}
