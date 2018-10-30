﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFall : MonoBehaviour {

    public GameObject destroyedVersion;

    void OnTriggerEnter(Collider col)
    {
        if ("Axe" == col.gameObject.name)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
