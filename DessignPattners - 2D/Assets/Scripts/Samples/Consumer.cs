using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Adapter
{
    public class Consumer : MonoBehaviour
    {
        private PlayerPrefsDataStoreAdapter fileDataStoreAdapter;
        
        private void Awake()
        {
            fileDataStoreAdapter = new PlayerPrefsDataStoreAdapter();
            var data = new Data("File1", 1234);
            fileDataStoreAdapter.SetData(data, "File1");
        }

        private void Start()
        {
            var data = fileDataStoreAdapter.GetData<Data>("File1");
            Debug.Log(data.File1);
            Debug.Log(data.File2);
        }
    }
}

