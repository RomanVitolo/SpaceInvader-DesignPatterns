using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Adapter
{
    [Serializable]
    public class Data
    {
        public string File1;
        public int File2;

        public Data(string file1, int file2)
        {
            File1 = file1;
            File2 = file2;
        }
    }
}

