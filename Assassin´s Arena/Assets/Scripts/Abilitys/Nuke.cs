using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Nuke : Abilities
{
    public GameObject nuke;
    public float Range;


    public override void Activate(GameObject parent)
    {

        Transform parentTransform = parent.transform;


        Instantiate(nuke, parentTransform.position, Quaternion.identity);


    }
}
