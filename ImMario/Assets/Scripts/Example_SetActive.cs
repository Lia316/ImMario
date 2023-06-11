using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_SetActive : MonoBehaviour
{
    private bool state;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ARAVRInput.GetDown(ARAVRInput.Button.IndexTrigger))
        {
            if (state == true)
            {
                target.SetActive(false);
                state = false;
            }
            else
            {
                target.SetActive(true);
                state = true;
            }
        }
    }
}
