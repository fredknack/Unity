using UnityEngine;
using System.Collections;

public class spawnParticlePrefabs : MonoBehaviour {

    #region initGameObjects

    public GameObject patternObjectOne;
    public GameObject patternObjectTwo;
    public GameObject patternObjectThree;
    public GameObject patternObjectFour;
    public GameObject patternObjectFive;
    public GameObject patternObjectSix;
    public GameObject patternObjectSeven;
    public GameObject patternObjectEight;

    private GameObject oneGo;
    private GameObject twoGo;
    private GameObject threeGo;
    private GameObject fourGo;
    private GameObject fiveGo;
    private GameObject sixGo;
    private GameObject sevenGo;
    private GameObject eightGo;

    #endregion

    public float thePosDistance = 5f;
    public float theNegDistance = -5f;
    public float prefabX = 0;
    public float prefabY = 0;
    public float prefabZ = 0;
    public int numberOfObjects = 50;
    public bool randomMode = false;

    private float lifetime = 100;
    private int prefabStyle = 1;
    private Vector3 objectScale;
    private Transform itemTransform;

    void Awake()
    {
        itemTransform = GetComponent<Transform>();
    }

    void Start()
    {
        launchPrefab(1);        
    }

    public void launchPrefab(int whichPrefab)
    {
        prefabX = Random.Range(theNegDistance, thePosDistance);
        prefabY = Random.Range(theNegDistance, thePosDistance);
        prefabZ = Random.Range(theNegDistance, thePosDistance);
        for (int i=1; i<numberOfObjects; i++)
        {
            whichPrefab = Random.Range(1, 8);
            prefabStyle++;
            
            switch (whichPrefab)
            {
                case 1:
                    oneGo = Instantiate(patternObjectOne, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    oneGo.transform.Rotate(new Vector3(90, 0, 0));
                    oneGo.transform.localScale += objectScale;
                    oneGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    oneGo.transform.SetParent(this.transform);

                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(oneGo, lifetime);

                    break;
                case 2:
                    twoGo = Instantiate(patternObjectTwo, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    twoGo.transform.Rotate(new Vector3(90, 0, 0));
                    twoGo.transform.localScale += objectScale;
                    twoGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    twoGo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(twoGo, lifetime);

                    break;
                case 3:
                    threeGo = Instantiate(patternObjectThree, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    threeGo.transform.Rotate(new Vector3(90, 0, 0));
                    threeGo.transform.localScale += objectScale;
                    threeGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    threeGo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(threeGo, lifetime);

                    break;
                case 4:
                    fourGo = Instantiate(patternObjectFour, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    fourGo.transform.Rotate(new Vector3(90, 0, 0));
                    fourGo.transform.localScale += objectScale;
                    fourGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    fourGo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(fourGo, lifetime);

                    break;
                case 5:
                    fiveGo = Instantiate(patternObjectFive, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    fiveGo.transform.Rotate(new Vector3(90, 0, 0));
                    fiveGo.transform.localScale += objectScale;
                    fiveGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    fiveGo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(fiveGo, lifetime);

                    break;
                case 6:
                    sixGo = Instantiate(patternObjectSix, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    sixGo.transform.Rotate(new Vector3(90, 0, 0));
                    sixGo.transform.localScale += objectScale;
                    sixGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    sixGo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(sixGo, lifetime);

                    break;
                case 7:
                    sevenGo = Instantiate(patternObjectSeven, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    sevenGo.transform.Rotate(new Vector3(90, 0, 0));
                    sevenGo.transform.localScale += objectScale;
                    sevenGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    sevenGo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(sevenGo, lifetime);

                    break;
                case 8:
                    eightGo = Instantiate(patternObjectEight, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    eightGo.transform.Rotate(new Vector3(90, 0, 0));
                    eightGo.transform.localScale += objectScale;
                    eightGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                    eightGo.transform.SetParent(this.transform);
                    prefabX = Random.Range(theNegDistance, thePosDistance);
                    prefabY = Random.Range(theNegDistance, thePosDistance);
                    prefabZ = Random.Range(theNegDistance, thePosDistance);
                    Destroy(eightGo, lifetime);

                    break;
            }

            //Loop through all the styles over and over
            if (prefabStyle < 8)
            {
                prefabStyle++;
            }
            else
            {
                prefabStyle = 1;
            }
            
        }
    }

    public void toggleRandomMode()
    {
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
