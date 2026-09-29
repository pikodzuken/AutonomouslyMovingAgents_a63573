using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class world
{
    private static readonly world instance = new world();
    private static GameObject[] hidingSports;

    static world()
    {
        hidingSports = GameObject.FindGameObjectsWithTag("hide");
    }

    private world() { }

    public static world Instance
    {
        get { return instance; }
    }

    public GameObject[] GetHidingSports()
    {
        return hidingSports;
    }
}
