using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelController : MonoBehaviour
{
    public GameObject pixel; // todo can use list of object
    

    public int rows = 10,col = 20;
    private float xOffset = 5f, yOffset = 9f;
   

    private void Start() 
    {
        offScreen();
        
    }

    public void offScreen()
    {
        for(int r = 1; r <= rows; r++)
        {
            for (int c = 0; c < col; c++)
            {
                Instantiate(pixel, new Vector3(r - xOffset, 0f, c - yOffset),Quaternion.identity);
            }
            
        }
    }
}
