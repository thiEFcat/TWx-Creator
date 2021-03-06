﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TWx_Creator
{
    public class NoteData
    {
        public int version { get; }
        public Note[] notes { get; set; }

        public NoteData()
        {
            version = 1;
        }
    }

    public class Note
    {
        public int ID { get; set; }
        public int Size { get; set; }
        public byte[] Color { get; set; }
        public int Mode { get; set; }
        public int Flick { get; set; }
        public double Time { get; set; }
        public double Speed { get; set; }
        public double StartLine { get; set; }
        public double EndLine { get; set; }
        public int[] PrevIDs { get; set; }

        public Note(int prevLength)
        {
            Color = new byte[4];
            PrevIDs = new int[prevLength];
        }

        public void CreateNote(int id, int size, byte[] color, int mode, int flick, double time, double speed, double start, double end, int[] prev)
        {
            ID = id;
            Size = size;
            Color = color;
            Mode = mode;
            Flick = flick;
            Time = time;
            Speed = speed;
            StartLine = start;
            EndLine = end;
            PrevIDs = prev;
        }
    }
}
