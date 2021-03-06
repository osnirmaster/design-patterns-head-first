﻿using System;
using KV.PatternCommand.Receptor;

namespace KV.PatternCommand.Commands
{
    public class StereoOffCommand : Command
    {
        private Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }
}