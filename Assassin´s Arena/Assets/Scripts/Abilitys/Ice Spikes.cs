using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu]
public class IceSpikes : Abilities
{
    
    public GameObject Spawn_cube;
    public float Range;
    

    public override void Activate(GameObject parent)
    {

        Transform parentTransform = parent.transform;

        
        Instantiate(Spawn_cube, parentTransform.position, Quaternion.identity);



    }
}
