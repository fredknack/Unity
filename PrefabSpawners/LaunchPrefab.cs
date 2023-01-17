 using UnityEngine; 
 using System.Collections;
 
 public class LaunchPrefab : MonoBehaviour 
 {
    public GameObject prefabone;
    public GameObject prefabtwo;
    public GameObject prefabthree;

    float xRandom, yRandom, zRandom;
    Vector3 pos;

    int whichPrefab = 1;
 
     void Update () 
     {
        //"Fire1" is the right mouse button
        if (Input.GetButtonDown("Fire1"))
            StartCoroutine(Burst());
     }

    IEnumerator Burst()
    {
        //each burst will generate 30 objects
        for(int i = 0; i < 30; i++)
        {
            //create a random number
            whichPrefab = Random.Range(1, 4);
            
            //create some random values to offset the launch opsition for the object
            xRandom = Random.Range(-0.1f, 0.1f);
            yRandom = Random.Range(-0.1f, 0.1f);
            zRandom = Random.Range(-0.1f, 0.1f);
            
            //create the object to launch
            GameObject objectClone;

            //Set the launch position and apply the random values
            pos = new Vector3(transform.position.x + xRandom, transform.position.y + yRandom, transform.position.z + zRandom);
            
            //Launch an object that corresponds with the random number generated above
            if(whichPrefab == 1){
                objectClone = Instantiate(prefabone, pos, transform.rotation);
                objectClone.GetComponent<Rigidbody>().velocity = transform.up * 8;
                Destroy(objectClone, 5);
            } else if (whichPrefab == 2) {
                objectClone = Instantiate(prefabtwo, pos, transform.rotation);
                objectClone.GetComponent<Rigidbody>().velocity = transform.up * 6;
                Destroy(objectClone, 5);
            } else if (whichPrefab == 3) {
                objectClone = Instantiate(prefabthree, pos, transform.rotation);
                objectClone.GetComponent<Rigidbody>().velocity = transform.up * 10;
                Destroy(objectClone, 5);
            } 
            //add a slight delay before creating a new object
            yield return new WaitForSeconds(0.1f);
        }
    }
 }