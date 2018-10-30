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
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
