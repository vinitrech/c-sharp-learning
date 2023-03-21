namespace TVApp
{
    class VolumeUpButton : ICommand
    {

        IElectronicDevice device;

        public VolumeUpButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.VolumeUp();
        }

        public void Undo()
        {
            device.VolumeDown();
        }
    }
}