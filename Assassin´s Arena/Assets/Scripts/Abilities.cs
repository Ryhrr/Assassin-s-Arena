using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abilities : ScriptableObject
{

    private Animator animator;

    public new string name;
    public float cooldownTime;
    public float activeTime;

    public virtual void Activate() { }



}
