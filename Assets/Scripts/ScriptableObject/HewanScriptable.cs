﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="Nama Hewan",menuName = "Hewan")]
public class HewanScriptable : ScriptableObject
{
    //attribute item
    [Header("Attribute Data Hewan")]
    public string namaHewan;
    public string deskripsiHewan;
    public string ciriHewan;
    public string makananHewan;
    public Sprite gambarHewan;
    public bool statusHewan;

    public void SetStatusHewan(bool value)
    {
        statusHewan = value;
    }
}
