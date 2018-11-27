using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicrockanimation : MonoBehaviour
{

    public Animation stopanimation;

    void OnTriggerEnter(Collider col)
    {
        if ("OnRightHandAnchor" == col.gameObject.name)
        {
            stopanimation.Stop();
        }
    }
}
