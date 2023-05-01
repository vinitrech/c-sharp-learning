using System;

namespace Records
{
    public record Info(string FullName, int Age);
    public record struct InfoAsStruct(string FullName, int Age); // struct record uses value-type parameters, the default is record class, which uses reference types

    public record JobInfo
    {
        public string Name { get; init; } = default; // init means the value will be assigned on initialization only
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var info = new Info("Full name", 14);
            var infoAsStruct = new InfoAsStruct("Full name 2", 52);
            var jobInfo = new JobInfo("Job name");
        }
    }
}