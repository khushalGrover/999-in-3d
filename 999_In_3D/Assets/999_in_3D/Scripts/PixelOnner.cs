using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelOnner : MonoBehaviour
{
    public Material onPixelMaterial;
    public Material offPixelMaterial;

    public GameObject parentGrid;     


    private void Start() 
    {
        this.transform.parent = parentGrid.transform;
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "TiggerCube")
        {
            this.GetComponent<Renderer>().material = onPixelMaterial;
        }

        // todo add blinking animtion on Head and bullets
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.tag == "TiggerCube")
        {
            this.GetComponent<Renderer>().material = offPixelMaterial;
        }
    }


    // todo remove blinking animtion on Head and bullets

}
