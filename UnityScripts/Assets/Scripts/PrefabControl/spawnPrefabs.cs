using UnityEngine;
using System.Collections;

public class spawnPrefabs : MonoBehaviour {
    // This code will create a random swarm of game objects
    
    // GameObjects need to be assigned in the inspector
    public GameObject prefabObjectOne;
    public GameObject prefabObjectTwo;
    public GameObject prefabObjectThree;
    public GameObject prefabObjectFour;
    public GameObject prefabObjectFive;
    public GameObject prefabObjectSix;
    public GameObject prefabObjectSeven;
    public GameObject prefabObjectEight;

    // Inspector assigned GameObjects will be assigned to these GameObjects
    private GameObject instantiatedObjectOne;
    private GameObject instantiatedObjectTwo;
    private GameObject instantiatedObjectThree;
    private GameObject instantiatedObjectFour;
    private GameObject instantiatedObjectFive;
    private GameObject instantiatedObjectSix;
    private GameObject instantiatedObjectSeven;
    private GameObject instantiatedObjectEight;

    private float thePosDistance = 20f;
    private float theNegDistance = -20f;
    private float prefabX = 0;
    private float prefabY = 0;
    private float prefabZ = 0;
    private float lifetime = 20;

    public int numberOfObjects = 80;

    void Start()
    {
        launchPrefab(1);        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
            launchPrefab(1);
        if (Input.GetKeyUp(KeyCode.S))
            launchPrefab(2);
        if (Input.GetKeyUp(KeyCode.D))
            launchPrefab(3);
        if (Input.GetKeyUp(KeyCode.F))
            launchPrefab(4);
        if (Input.GetKeyUp(KeyCode.G))
            launchPrefab(5);
        if (Input.GetKeyUp(KeyCode.H))
            launchPrefab(6);
        if (Input.GetKeyUp(KeyCode.J))
            launchPrefab(7);
        if (Input.GetKeyUp(KeyCode.K))
            launchPrefab(8);
    }

    public void launchPrefab(int whichPrefab)
    {
        prefabX = Random.Range(theNegDistance, thePosDistance);
        prefabY = Random.Range(theNegDistance, thePosDistance);
        prefabZ = Random.Range(theNegDistance, thePosDistance);

        for (int i=1; i<numberOfObjects; i++)
        {    
            switch (whichPrefab)
            {
                case 1:
                    
                    instantiatedObjectOne = Instantiate(prefabObjectOne, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectOne.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectOne.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectOne.transform.SetParent(this.transform);

                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectOne, lifetime);

                    break;
                case 2:
                    instantiatedObjectTwo = Instantiate(prefabObjectTwo, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    instantiatedObjectTwo.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectTwo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectTwo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectTwo, lifetime);

                    break;
                case 3:
                    instantiatedObjectThree = Instantiate(prefabObjectThree, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    instantiatedObjectThree.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectThree.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectThree.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectThree, lifetime);

                    break;
                case 4:
                    instantiatedObjectFour = Instantiate(prefabObjectFour, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    instantiatedObjectFour.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectFour.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectFour.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectFour, lifetime);

                    break;
                case 5:
                    instantiatedObjectFive = Instantiate(prefabObjectFive, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    instantiatedObjectFive.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectFive.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectFive.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectFive, lifetime);

                    break;
                case 6:
                    instantiatedObjectSix = Instantiate(prefabObjectSix, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    instantiatedObjectSix.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectSix.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectSix.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectSix, lifetime);

                    break;
                case 7:
                    instantiatedObjectSeven = Instantiate(prefabObjectSeven, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    instantiatedObjectSeven.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectSeven.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectSeven.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectSeven, lifetime);

                    break;
                case 8:
                    instantiatedObjectEight = Instantiate(prefabObjectEight, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    instantiatedObjectEight.transform.Rotate(new Vector3(90, 0, 0));
                    instantiatedObjectEight.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    instantiatedObjectEight.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(instantiatedObjectEight, lifetime);

                    break;
            }
        }
    }
}
