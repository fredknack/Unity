using UnityEngine;
using System.Collections;

public class spawnParticleSquares : MonoBehaviour {

    public GameObject patternObjectOne;
    public GameObject patternObjectTwo;
    public GameObject patternObjectThree;
    public GameObject patternObjectFour;
    public GameObject patternObjectFive;
    public GameObject patternObjectSix;
    public GameObject patternObjectSeven;
    public GameObject patternObjectEight;

    // Start 90 degree towers
    public GameObject patternObjectNine;

    private GameObject oneGo;
    private GameObject twoGo;
    private GameObject threeGo;
    private GameObject fourGo;
    private GameObject fiveGo;
    private GameObject sixGo;
    private GameObject sevenGo;
    private GameObject eightGo;

    private bool patternObjectOneActive = false;
    //private bool patternObjectOneStatus = false;

    private bool patternObjectTwoActive = false;
    //private bool patternObjectTwoStatus = false;

    private bool patternObjectThreeActive = false;
    //private bool patternObjectThreeStatus = false;

    private bool patternObjectFourActive = false;
    //private bool patternObjectFourStatus = false;

    private bool patternObjectFiveActive = false;
    //private bool patternObjectFiveStatus = false;

    private bool patternObjectSixActive = false;
    //private bool patternObjectSixStatus = false;

    private bool patternObjectSevenActive = false;
    //private bool patternObjectSevenStatus = false;

    private bool patternObjectEightActive = false;
    //private bool patternObjectEightStatus = false;

    private float InstantiationTimer = 2f;
    public float thePosDistance = 20f;
    public float theNegDistance = -20f;
    public float prefabX = 0;
    public float prefabY = 0;
    public float prefabZ = 1;
    private float lifetime = 2;
    private float lifetimeAngle = 3;
    private float theInterval = 0.2f;

    private int newSlotID;
    private int currentSlotID = 0;

    //not really using quadVied in this mode - bug that I need this at all
    private bool quadView = false;
    
    public int numberOfObjects = 50;
    //private float prefabDirection = 1;
    public bool patternActive = false;
    public bool randomMode = false;
    public bool randomAngle = false;
    private float yDistance = 0;
    public bool centerMode = false;
    //private Vector3 velosity = new Vector3(0, 0, 10);
    //Color[] ringShapeColours = { Color.red, Color.blue, Color.green, Color.yellow, Color.black };
    int counter = 0;
    Coroutine IntervalCoroutineReference;

    private Transform itemTransform;

    public float maxSize = 2;
    public float growFactor = 0.01f;
    public float waitTime = 0.1f;

    void Awake()
    {
        itemTransform = GetComponent<Transform>();
    }

    void Start()
    {
        launchPrefab(1);        
    }

    void Update()
    {
        if (patternActive == true)
            InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            launchPrefab(1);
            InstantiationTimer = Random.Range(6.1f, 8.0f);
        }
    }

    //IEnumerator Scale()
    //{
    //float timer = 0;

    //maxSize = 0;
    //while (true) // this could also be a condition indicating "alive or dead"
    //{
    //Debug.Log("Scale " + maxSize);
    //maxSize=maxSize + 0.01f;
    //yield return new WaitForSeconds(2);
    //}
    //}

    public IEnumerator TimerIntervalStart(float howLong, int whichPrefab)
    {

        newSlotID = Random.Range(0, 6);
        if (newSlotID == currentSlotID)
        {
            if (newSlotID == currentSlotID)
            {
                if (newSlotID == currentSlotID)
                {
                    newSlotID = Random.Range(0, 6);
                }
            }
        }
        positionTowerForSlotID(newSlotID);
        constructSquare(whichPrefab);
        yield return new WaitForSeconds(howLong);
        launchPrefab(whichPrefab);
    }

    public void launchPrefab(int whichPrefab)
    {
        //prefabX = Random.Range(theNegDistance, thePosDistance);
        //prefabY = Random.Range(theNegDistance, thePosDistance);
        //prefabZ = Random.Range(theNegDistance, thePosDistance);

        if (randomAngle == true)
        {

            //delay
        }

        //prefabX = -3;
        prefabZ = Random.Range(.2f, 4f);

        //Debug.Log("launchPrefab: "+ whichPrefab);
        //allOff();
        //if (PersistentManagerScript.Instance.particleRandomPrefabMode)
        //{
            //whichPrefab = Random.Range(1, 7);

        //}


        //for (int i=1; i<numberOfObjects; i++)
        //{
            // Find a way to toggle random mode - very cool looking
            if (randomMode == true)
            {
            
                whichPrefab = Random.Range(1, 9);
            }
            if (randomAngle == true)
            {
                yDistance = Random.Range(-2f, 2f);
                theInterval = 0.1f;
                if (randomMode == true)
                {

                    whichPrefab = Random.Range(1, 7);
                }
            }
            if (centerMode == true)
            {
                yDistance = 0;
                prefabX = 0;
                prefabY = 0;
                //prefabZ = 0.3f;
            }
            

        StartCoroutine(TimerIntervalStart(theInterval, whichPrefab));

            
            
        //}
    }

    public void constructSquare(int whichStylePrefab)
    {
        /*
        if (randomMode)
        {
            whichStylePrefab = Random.Range(1, 9);
        }
        if (randomAngle)
        {
            //yDistance = Random.Range(-2f, 2f);
        }
        if (centerMode)
        {
            yDistance = 0;
            prefabX = 0;
            prefabY = 0;
            //prefabZ = 0.3f;
        }
        */

        switch (whichStylePrefab)
        {
            case 1:
                //Debug.Log("launchPrefab");
                

                    oneGo = Instantiate(patternObjectOne, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    prefabY = yDistance;

                
                oneGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                oneGo.transform.SetParent(this.transform);

                if (randomAngle == true)
                {
                    Destroy(oneGo, lifetimeAngle);
                }
                else
                {
                    Destroy(oneGo, lifetime);
                }

                //iTween.FadeFrom(oneGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", oneGo));

                counter = 1;

                break;
            case 2:

                    twoGo = Instantiate(patternObjectTwo, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    prefabY = yDistance;
               
                
                twoGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                twoGo.transform.SetParent(this.transform);
                if (randomAngle == true)
                {
                    Destroy(twoGo, lifetimeAngle);
                }
                else
                {
                    Destroy(twoGo, lifetime);
                }

                //iTween.FadeFrom(twoGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", twoGo));

                counter = 1;

                break;
            case 3:

                    threeGo = Instantiate(patternObjectThree, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    prefabY = yDistance;
                
                threeGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                if (randomAngle == true)
                {
                    Destroy(threeGo, lifetimeAngle);
                }
                else
                {
                    Destroy(threeGo, lifetime);
                }

                //iTween.FadeFrom(threeGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", threeGo));

                counter = 1;

                break;
            case 4:
                    fourGo = Instantiate(patternObjectFour, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    prefabY = yDistance;

                fourGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                fourGo.transform.SetParent(this.transform);
                if (randomAngle == true)
                {
                    Destroy(fourGo, lifetimeAngle);
                }
                else
                {
                    Destroy(fourGo, lifetime);
                }

                //iTween.FadeFrom(fourGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", fourGo));

                counter = 1;

                break;
            case 5:

                    fiveGo = Instantiate(patternObjectFive, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    prefabY = yDistance;

                fiveGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                fiveGo.transform.SetParent(this.transform);
                if (randomAngle == true)
                {
                    Destroy(fiveGo, lifetimeAngle);
                }
                else
                {
                    Destroy(fiveGo, lifetime);
                }

                //iTween.FadeFrom(fiveGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", fiveGo));
                counter = 1;

                break;
            case 6:

                    sixGo = Instantiate(patternObjectSix, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    prefabY = yDistance;

                sixGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                sixGo.transform.SetParent(this.transform);
                if (randomAngle == true)
                {
                    Destroy(sixGo, lifetimeAngle);
                }
                else
                {
                    Destroy(sixGo, lifetime);
                }

                //iTween.FadeFrom(sixGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", sixGo));

                counter = 1;

                break;
            case 7:
                    sevenGo = Instantiate(patternObjectSeven, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                    prefabY = yDistance;

                sevenGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                sevenGo.transform.SetParent(this.transform);
                if (randomAngle == true)
                {
                    Destroy(sevenGo, lifetimeAngle);
                }
                else
                {
                    Destroy(sevenGo, lifetime);
                }

                //iTween.FadeFrom(sevenGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", sevenGo));


                counter = 1;


                break;
            case 8:
                    prefabY = yDistance;
                    eightGo = Instantiate(patternObjectEight, new Vector3(0.01f, 0.01f, 6.5f), Quaternion.identity) as GameObject;
                
                eightGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
                eightGo.transform.SetParent(this.transform);
                if (randomAngle == true)
                {
                    Destroy(eightGo, lifetimeAngle);
                }
                else
                {
                    Destroy(eightGo, lifetime);
                }

                //iTween.FadeFrom(eightGo, iTween.Hash("alpha", 0f, "time", 3f, "oncomplete", "ReturnToOriginalAlphaTransparencyTweenOnComplete", "oncompletetarget", eightGo));

                counter = 1;

                break;
        }
    }

    public void positionTowerForSlotID(int whichSlotID)
    {
            switch (whichSlotID)
            {
                case 0:
                    prefabX = Random.Range(-3, 5);


                //prefabZ = 1.5f;
                break;
                case 1:
                    prefabX = Random.Range(-3, 5);
                //prefabZ = 1.5f;
                break;
                case 2:
                    prefabX = Random.Range(-3, 5);
                //prefabZ = 1.5f;
                break;
                case 3:
                    prefabX = Random.Range(-3, 5);
                //prefabZ = 1.5f;
                break;
                case 4:
                    prefabX = Random.Range(-3, 5);
                    //prefabZ = 1.5f;
                break;
                case 5:
                    prefabX = Random.Range(-3, 5);
                    //prefabZ = 1.5f;
                break;
                case 6:
                    prefabX = Random.Range(-3, 5);
                    //prefabZ = 1.5f;

                break;
            }

            if (centerMode == true)
            {
                prefabX = 0;
            }

    }

    public void effectPrefab()
    {
        //gameObject.GetComponentsInChildren<Transform>();
        Debug.Log("effectPrefab");
        //patternObjectOne.transform.position = new Vector3(20, 20, 20);
        //patternObjectOne
        //oneGo.transform.position = new Vector3(prefabX, prefabY, prefabZ);
        var allChildren = this.GetComponentsInChildren<Transform>();
        int numChildren = this.transform.childCount;
        Debug.Log("numChildren: " + numChildren);
        Debug.Log("allChildren: " + allChildren);

        //foreach (Transform child in allChildren)
        //{
        //This is a sub object of the master particle prefab
        //Figure out how to talk to particle layers
        //Debug.Log("children: " + numChildren);
        while (transform.childCount > 0)
        {
            print("destroy!");
            Destroy(transform.GetChild(0).gameObject);
        }

        //}
        this.transform.position = new Vector3(1, 1, 1);
        for (int i = 1; i < numChildren; i++)
        {
            //this.transform.position = new Vector3(10, 20, 20);
        }
    }

    public void toggleRandomMode()
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

    public void toggleQuad()
    {
        //I should not need this function in this mode - Bug 
        Debug.Log("Toggle Quad-");
        if (quadView == false) { quadView = true; } else { quadView = false; }
    }

    public void allOff()
    {
        togglePatternOneOff();
        togglePatternTwoOff();
        togglePatternThreeOff();
        togglePatternFourOff();
        togglePatternFiveOff();
        togglePatternSixOff();
        togglePatternSevenOff();
        togglePatternEightOff();
    }
    //ONE
    public void launchPrefabOne()
    {
        allOff();
        launchPrefab(1);
    }

    void togglePatternOneOn()
    {
        patternObjectOneActive = true;
        //patternObjectOneStatus = true;
        launchPrefabOne();
        //Debug.Log("backdropPlaneOne = true");
    }
    void togglePatternOneOff()
    {
        patternObjectOneActive = false;
        //patternObjectOneStatus = false;
        Destroy(this.oneGo);

        //Debug.Log("backdropPlaneOne = false - zap");  
    }

    //TWO
    public void launchPrefabTwo()
    {
        allOff();
        launchPrefab(2);
    }
    void togglePatternTwoOn()
    {
        patternObjectTwoActive = true;
        //patternObjectTwoStatus = true;
        launchPrefabTwo();
        //Debug.Log("backdropPlaneTwo = true");
    }
    void togglePatternTwoOff()
    {
        patternObjectTwoActive = false;
        //patternObjectTwoStatus = false;
        Destroy(this.twoGo);
        //Debug.Log("backdropPlaneTwo = false");
    }

    //THREE
    public void launchPrefabThree()
    {
        allOff();
        launchPrefab(3);
    }
    void togglePatternThreeOn()
    {
        patternObjectThreeActive = true;
        //patternObjectThreeStatus = true;
        launchPrefabThree();
        Debug.Log("backdropPlaneThree = true");
    }
    void togglePatternThreeOff()
    {
        patternObjectThreeActive = false;
        //patternObjectThreeStatus = false;
        Destroy(this.threeGo);
        Debug.Log("backdropPlaneThree = false");
    }

    //FOUR
    public void launchPrefabFour()
    {
        allOff();
        launchPrefab(4);
    }
    void togglePatternFourOn()
    {
        patternObjectFourActive = true;
        //patternObjectFourStatus = true;
        launchPrefabFour();
        Debug.Log("backdropPlaneFour = true");
    }
    void togglePatternFourOff()
    {
        patternObjectFourActive = false;
        //patternObjectFourStatus = false;
        Destroy(this.fourGo);
        Debug.Log("backdropPlaneFour = false");
    }

    //FIVE
    public void launchPrefabFive()
    {
        allOff();
        launchPrefab(5);
    }
    void togglePatternFiveOn()
    {
        patternObjectFiveActive = true;
        //patternObjectFiveStatus = true;
        launchPrefabFive();
        Debug.Log("backdropPlaneFive = true");
    }
    void togglePatternFiveOff()
    {
        patternObjectFiveActive = false;
        //patternObjectFiveStatus = false;
        Destroy(this.fiveGo);
        Debug.Log("backdropPlaneFive = false");
    }

    //SIX
    public void launchPrefabSix()
    {
        allOff();
        launchPrefab(6);
    }
    void togglePatternSixOn()
    {
        patternObjectSixActive = true;
        //patternObjectSixStatus = true;
        launchPrefabSix();
        Debug.Log("backdropPlaneSix = true");
    }
    void togglePatternSixOff()
    {
        patternObjectSixActive = false;
        //patternObjectSixStatus = false;
        Destroy(this.sixGo);
        Debug.Log("backdropPlaneSix = false");
    }

    //SEVEN
    public void launchPrefabSeven()
    {
        allOff();
        launchPrefab(7);
    }
    void togglePatternSevenOn()
    {
        patternObjectSevenActive = true;
        //patternObjectSevenStatus = true;
        launchPrefabSeven();
        Debug.Log("backdropPlaneSeven = true");
    }
    void togglePatternSevenOff()
    {
        patternObjectSevenActive = false;
        //patternObjectSevenStatus = false;
        Destroy(this.sevenGo);
        Debug.Log("backdropPlaneSeven = false");
    }

    //EIGHT
    public void launchPrefabEight()
    {
        allOff();
        launchPrefab(8);
    }
    void togglePatternEightOn()
    {
        patternObjectEightActive = true;
        //patternObjectEightStatus = true;
        launchPrefabEight();
        Debug.Log("backdropPlaneEight = true");
    }
    void togglePatternEightOff()
    {
        patternObjectEightActive = false;
        //patternObjectEightStatus = false;
        Destroy(this.eightGo);
        Debug.Log("backdropPlaneEight = false");
    }

}
