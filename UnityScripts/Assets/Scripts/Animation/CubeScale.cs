using UnityEngine;
using System.Collections;
// Scale object up and down over time
public class CubeScale : MonoBehaviour 
{
	//get this item's Transform
	private Transform itemTransform;
	//a variable to store the number of collected items
	public static int numberOfItems=0;

    private int growCube = 1;

    // Use this for initialization
    void Awake () 
	{
		//get the this item's Transform
		itemTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//rotate this game object
		itemTransform.Rotate(Vector3.up * 1,Space.Self);
        
        if (growCube == 1)
        {
            if (itemTransform.transform.localScale.y < 8)
            {
                itemTransform.transform.localScale += new Vector3(-0.02f, 0.05F, 0);
            }
            else
            {
                growCube = 0;
            }
        }
        if (growCube == 0)
        {
            if (itemTransform.transform.localScale.y > 2)
            {
                itemTransform.transform.localScale += new Vector3(0.02f, -0.05F, 0);
            }
            else
            {
                growCube = 1;
            }
        }
        Debug.Log(itemTransform.transform.localScale.y);
    }
}
