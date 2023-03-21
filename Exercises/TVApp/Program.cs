using System;

namespace TVApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton pb = new PowerButton(TV);
            VolumeUpButton vu = new VolumeUpButton(TV);
            VolumeDownButton vd = new VolumeDownButton(TV);

            pb.Execute();
            pb.Undo();

            vu.Execute();
            vu.Undo();

            vd.Execute();
            vd.Undo();
        }
    }
}