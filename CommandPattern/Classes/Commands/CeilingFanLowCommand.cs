using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanLowCommand : Command
    {
        CeilingFan ceilingFan;
        Stack<int> previousSpeeds = new Stack<int>();

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            previousSpeeds.Push(ceilingFan.GetSpeed());
            ceilingFan.Low();
        }

        public void Undo()
        {
            if (previousSpeeds.Count == 0)
            {
                return;
            }

            int previousSpeed = previousSpeeds.Pop();

            switch (previousSpeed)
            {
                case 0:
                    ceilingFan.Off();
                    break;
                case 1:
                    ceilingFan.Low();
                    break;
                case 2:
                    ceilingFan.Medium();
                    break;
                case 3:
                    ceilingFan.High();
                    break;
            }
        }
    }
}
