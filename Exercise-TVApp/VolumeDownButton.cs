namespace TVApp
{
    class VolumeDownButton : ICommand
    {

        IElectronicDevice device;

        public VolumeDownButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.VolumeDown();
        }

        public void Undo()
        {
            device.VolumeUp();
        }
    }
}