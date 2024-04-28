using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class FireRing : Abilities
{
    public GameObject Spawn_Fire_cube;
    public float Range;

    public override void Activate(GameObject parent)
    {

        Transform parentTransform = parent.transform;


        Instantiate(Spawn_Fire_cube, parentTransform.position, Quaternion.identity);

    }

}