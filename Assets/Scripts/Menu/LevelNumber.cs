using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelNumber : MonoBehaviour
{
    public static LevelNumber Instance;
    public int level;

    private void Awake()
    {
        Instance = this;
    }
}
