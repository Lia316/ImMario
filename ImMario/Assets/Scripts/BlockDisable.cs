using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDisable : MonoBehaviour
{
    public Material[] material;
    private Renderer rend;
    bool isBoxEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(isBoxEnabled && collision.collider.CompareTag("Head"))
        {
            print("collision with box & head!");

            var mats = rend.materials;

            if (mats.Length == 2) {
            mats[1] = material[3];
            mats[0] = material[2];
            }
            else if (mats.Length == 1) {
                mats[0] = material[2];
            }
            rend.materials = mats;

            isBoxEnabled = false;
        }
    }
}
