using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CloudOnce;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cloud.Initialize(false, true);
    }
}
