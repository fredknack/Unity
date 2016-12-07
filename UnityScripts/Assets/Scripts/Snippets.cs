using UnityEngine;
using System.Collections;
// Just a bunch of sometimes handy code chunks
public class Snippets : MonoBehaviour 
{
    private bool randomMode;
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
