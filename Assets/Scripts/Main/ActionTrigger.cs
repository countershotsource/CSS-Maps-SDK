using System;

using UnityEngine;

public class ActionTrigger : MonoBehaviour
{
    public bool Once;
    public bool Bullet;
    public bool PlayerTerrorist;
    public bool PlayerCounterTerrorist;
    public int TimeSeconds;
    public int CooldownSeconds;
    public Act[] actions;

    [Serializable]
    public class Act
    {
        public string Object;
        public string Method;
        public string[] args;
    }
}
