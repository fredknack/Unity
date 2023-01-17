 using UnityEngine; 
 using System.Collections;
 
 public class GenerateLaunchers : MonoBehaviour 
 {
    public GameObject launcherPrefab;

    float xRandom, zRandom;
    Vector3 pos;
 
     void Update () 
     {
        // "Jump" is the spacebar
        if (Input.GetKey("G"))
            StartCoroutine(GenerateLauncherPrefabs());
     }

    IEnumerator GenerateLauncherPrefabs()
    {
        //each spacebar press will generate 10 launchers
        for(int i = 0; i < 10; i++)
        {
            //create some random values to offset the launch opsition for the object
            xRandom = Random.Range(-50f, 50f);
            zRandom = Random.Range(-50f, 50f);
            
            //create the object to generate
            GameObject objectClone;

            //Set the launch position and apply the random values
            pos = new Vector3(transform.position.x + xRandom, transform.position.y, transform.position.z + zRandom);

            objectClone = Instantiate(launcherPrefab, pos, transform.rotation);

            //add a slight delay before creating a new object
            yield return new WaitForSeconds(0.1f);
        }
    }
 }