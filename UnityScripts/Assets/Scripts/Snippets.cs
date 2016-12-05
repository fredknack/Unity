using UnityEngine;
using System.Collections;
// Just a bunch of sometimes handy code chunks
public class Snippets : MonoBehaviour 
{
    public void toggleBool()
    {
        Debug.Log("Toggle");
        if (randomMode == false)
        {
            randomMode = true;
        }
        else
        {
            randomMode = false;
        }
    }
}
