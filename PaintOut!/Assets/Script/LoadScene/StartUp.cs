using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour
{
    // Start is called before the first frame update\

    [SerializeField]
    private int max_skin = 100;
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Start"))
        {
            for (int i = 0; i < max_skin; i++)
                PlayerPrefs.SetInt("BuyFlag" + i, 0);

            SaveDataInitialize();
        }

    }

    // Update is called once per frame
    private void SaveDataInitialize()
    {
        PlayerPrefs.SetInt("Start", 1); // ”Start”のキーをint型の値(1)で保存
                                        // PlayerPrefs.SetInt("Score", 0);
    }
}
