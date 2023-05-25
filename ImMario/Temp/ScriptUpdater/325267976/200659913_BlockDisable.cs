using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDisable : MonoBehaviour
{
    public Material[] material;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.materials[0] = material[1];
        rend.materials[1] = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Head"))
        {
            print("collision with box & head!");
            var mats = GetComponent<Renderer>().materials;
            mats[1] = material[3];
            mats[0] = material[2];
            rend.materials = mats;
            //rend.materials[1] = material[3];
            //rend.materials[0] = material[2];
            //rend.material = material[2];
        }
    }
}
