using CommandPatternDemo.Romote.Concretes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Romote
{
    public class RemoteControl
    {
        CommandBase[] OnCommand;
        CommandBase[] OffCommand;
        CommandBase UndoCommand;

        public RemoteControl()
        {
            OnCommand = new CommandBase[7];
            OffCommand = new CommandBase[7];


            CommandBase noCommand = new NoCommand();

            // Fill in all with no command content
            for (int i = 0; i < 7; i++)
            {
                OnCommand[i] = noCommand;
                OffCommand[i] = noCommand;
            }

            UndoCommand = noCommand;
        }

        public void SetCommand(int slot, CommandBase onCommand, CommandBase offCommand)
        {
            OnCommand[slot] = onCommand;
            OffCommand[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            OnCommand[slot].Execute();
            UndoCommand = OnCommand[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            OffCommand[slot].Execute();
            UndoCommand = OffCommand[slot];
        }

        public void UndoButtonWasPushed()
        {
            UndoCommand.Undo();
        }

        public string ToString()
        {
            StringBuilder remoteInfo = new StringBuilder();
            remoteInfo.Append("\n-------Remote Control -------\n");
            for (int i = 0; i < 7; i++)
            {
                remoteInfo.AppendFormat("slot {0} : {1} \t {2} \n", i,
                    OnCommand[i].GetType().Name, OffCommand[i].GetType().Name);
            }
            return remoteInfo.ToString();
        }



    }
}
