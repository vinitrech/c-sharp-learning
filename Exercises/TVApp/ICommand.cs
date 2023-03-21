namespace TVApp
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}