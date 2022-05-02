using UnityEngine;
using System;
using System.Diagnostics;

public class MyLibaryManager : MonoBehaviour
{
    //worst scripts ever made by BigBoyTaco https://github.com/BigBoyTaco
    //games installed
    public bool GFPS_Installed = false;
    public bool MPLPFPS_Installed = false;
    public bool Ciscord_Installed = false;

    //laucnch stuff
    public void LaunchGFPS1()
    {
        Process.Start(Application.dataPath + @"\Games\GFPS\GFPS1.exe");
    }
    public void LaunchMLFPS()
    {
        Process.Start(Application.dataPath + @"\Games\MLFPS\MLFPS.exe");
    }
    public void LaunchCiscord()
    {
        Process.Start(Application.dataPath + @"\Games\Ciscord\Ciscord\csiscord.exe");
    }
    public void LauchGCS()
    {
        Process.Start(Application.dataPath + @"\Games\GCS\Generic Cookin Simulator\Generic Cooking Simulator.exe");
    }
    public void LaunchSBCFrFr()
    {
        Process.Start(Application.dataPath + @"\Games\SBCFrFr\smash bros copy frfr.exe");
    }
    public void LaunchGPG()
    {
        Process.Start(Application.dataPath + @"\Games\GPG\GPG.exe");
    }
}