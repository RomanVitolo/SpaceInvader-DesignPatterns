using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Adapter
{
    public interface IDataStore
    {
        void SetData<T>(T data, string name);
        T GetData<T>(string name);
    }
}

