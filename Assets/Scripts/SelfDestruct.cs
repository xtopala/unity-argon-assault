﻿using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);    // TODO: allow customization
    }
}
