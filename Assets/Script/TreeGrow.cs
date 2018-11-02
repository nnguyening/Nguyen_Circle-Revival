using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGrow : MonoBehaviour
{

    public GameObject destroyedVersion;

    void OnTriggerEnter(Collider col)
    {
        if ("MagicRock" == col.gameObject.name)
        {
            Instantiate(destroyedVersion, new Vector3(transform.position.x,0,transform.position.z), transform.rotation);
            Destroy(gameObject);
        }
    }
}
