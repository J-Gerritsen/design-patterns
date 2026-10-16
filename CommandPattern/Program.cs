using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage"));
            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class
            Command livingRoomLightOn = new LightOnCommand(livingRoomLight);
            Command livingRoomLightOff = new LightOffCommand(livingRoomLight);
            Command kitchenLightOn = new LightOnCommand(kitchenLight);
            Command kitchenLightOff = new LightOffCommand(kitchenLight);
            Command fanOn = new CeilingFanHighCommand(livingRoomFan);
            Command fanMedium = new CeilingFanMediumCommand(livingRoomFan);
            Command fanLow = new CeilingFanLowCommand(livingRoomFan);
            Command fanOff = new CeilingFanOffCommand(livingRoomFan);
            Command garageUp = new GarageDoorUpCommand(garageDoor);
            Command garageDown = new GarageDoorDownCommand(garageDoor);
            Command stereoOn = new StereoOnWithCdCommand(stereo);
            Command stereoOff = new StereoOffCommand(stereo);

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3, fanOn, fanOff);
            remoteControl.SetCommand(4, garageUp, garageDown);
            remoteControl.SetCommand(5, stereoOn, stereoOff);
            remoteControl.SetCommand(6, fanMedium, fanOff);

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button
            Console.WriteLine("Livingroom");
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("Kitchen");
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("Fan");
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("Garage");
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("Stereo");
            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("Fan medium");
            remoteControl.OnButtonWasPushed(6);
            remoteControl.UndoButtonWasPushed();
        }
    }
}