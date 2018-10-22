using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDestrutction : MonoBehaviour {

    public GameObject destroyedVersion;

    private void Start()
    {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("Trigger Pulled");
        }
    }
    void OnTriggerEnter(Collider col)
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
