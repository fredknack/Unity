using UnityEngine;
using System.Collections;

public class spawnMotionSlash : MonoBehaviour
{
    public GameObject patternPrefabOne;
    public GameObject patternPrefabTwo;
    public GameObject patternPrefabThree;
    public GameObject patternPrefabFour;
    public GameObject patternPrefabFive;
    public GameObject patternPrefabSix;
    public GameObject patternPrefabSeven;
    public GameObject patternPrefabEight;
    public GameObject patternPrefabNine;
    public GameObject patternPrefabTen;
    public GameObject patternPrefabEleven;
    public GameObject patternPrefabTwelve;
    public GameObject patternPrefabThirteen;
    public GameObject patternPrefabFourteen;
    public GameObject patternPrefabFifteen;
    public GameObject patternPrefabSixteen;
    public GameObject patternPrefabSeventeen;
    public GameObject patternPrefabEighteen;
    public GameObject patternPrefabNinteen;
    public GameObject patternPrefabTwenty;
    public GameObject patternPrefabTwentyone;

    private GameObject instantiatedObjectOne;
    private GameObject instantiatedObjectTwo;
    private GameObject instantiatedObjectThree;
    private GameObject instantiatedObjectFour;
    private GameObject instantiatedObjectFive;
    private GameObject instantiatedObjectSix;
    private GameObject instantiatedObjectSeven;
    private GameObject instantiatedObjectEight;
    private GameObject instantiatedObjectNine;
    private GameObject instantiatedObjectTen;
    private GameObject instantiatedObjectEleven;
    private GameObject instantiatedObjectTwelve;
    private GameObject instantiatedObjectThirteen;
    private GameObject instantiatedObjectFourteen;
    private GameObject instantiatedObjectFifteen;
    private GameObject instantiatedObjectSixteen;
    private GameObject instantiatedObjectSeventeen;
    private GameObject instantiatedObjectEighteen;
    private GameObject instantiatedObjectNinteen;
    private GameObject instantiatedObjectTwenty;
    private GameObject instantiatedObjectTwentyone;

    private int currentPrefab = 1;
    private float lifetime = 30;
    private int tweenStyle = 1;
    public float prefabX = 0;
    public float prefabY = 0;
    public float prefabZ = 0f;
    public float prefabSpeed = 25f;
    public float prefabDelay = 1f;

    //public cameraControl activeCam;

    public void Start()
    {
        launchPrefab(currentPrefab);
    }

    public void launchPrefab(int whichPrefab)
    {
        //screenPoint = Input.mousePosition;
        //screenPoint.z = activeCam.getCamPosition(); //distance of the plane from the camera
        //prefabZ = activeCam.getCamPosition() + 3.58f;

        tweenStyle = Random.Range(1, 5);
        print(tweenStyle);
        if (prefabZ > 3.25f)
        {
            //prefabZ = prefabZ - .05f;
        } else {
            //prefabZ = prefabZ - 3.58f;
        }
        switch (whichPrefab)
            {
                case 1:
                    instantiatedObjectOne = Instantiate(patternPrefabOne, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectOne.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectOne, lifetime);
                    animatePrefab(instantiatedObjectOne);
                break;
                case 2:
                    instantiatedObjectTwo = Instantiate(patternPrefabTwo, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectTwo.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectTwo, lifetime);
                    animatePrefab(instantiatedObjectTwo);
                break;
                case 3:
                    instantiatedObjectThree = Instantiate(patternPrefabThree, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectThree.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectThree, lifetime);
                    animatePrefab(instantiatedObjectThree);
                break;
                case 4:
                    instantiatedObjectFour = Instantiate(patternPrefabFour, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectFour.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectFour, lifetime);
                    animatePrefab(instantiatedObjectFour);
                break;
                case 5:
                    instantiatedObjectFive = Instantiate(patternPrefabFive, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectFive.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectFive, lifetime);
                    animatePrefab(instantiatedObjectFive);
                break;
                case 6:
                    instantiatedObjectSix = Instantiate(patternPrefabSix, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectSix.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectSix, lifetime);
                    animatePrefab(instantiatedObjectSix);
                break;
                case 7:
                    instantiatedObjectSeven = Instantiate(patternPrefabSeven, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectSeven.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectSeven, lifetime);
                    animatePrefab(instantiatedObjectSeven);
                break;
                case 8:
                    instantiatedObjectEight = Instantiate(patternPrefabEight, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectEight.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectEight, lifetime);
                    animatePrefab(instantiatedObjectEight);
                break;
                case 9:
                    instantiatedObjectNine = Instantiate(patternPrefabNine, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectNine.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectNine, lifetime);
                    animatePrefab(instantiatedObjectNine);
                break;
                case 10:
                    instantiatedObjectTen = Instantiate(patternPrefabTen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectTen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectTen, lifetime);
                    animatePrefab(instantiatedObjectTen);
                break;
                case 11:
                    instantiatedObjectEleven = Instantiate(patternPrefabEleven, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectEleven.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectEleven, lifetime);
                    animatePrefab(instantiatedObjectEleven);
                break;
                case 12:
                    instantiatedObjectTwelve = Instantiate(patternPrefabTwelve, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectTwelve.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectTwelve, lifetime);
                    animatePrefab(instantiatedObjectTwelve);
                break;
                case 13:
                    instantiatedObjectThirteen = Instantiate(patternPrefabThirteen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectThirteen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectThirteen, lifetime);
                    animatePrefab(instantiatedObjectThirteen);
                break;
                case 14:
                    instantiatedObjectFourteen = Instantiate(patternPrefabFourteen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectFourteen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectFourteen, lifetime);
                    animatePrefab(instantiatedObjectFourteen);
                break;
                case 15:
                    instantiatedObjectFifteen = Instantiate(patternPrefabFifteen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectFifteen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectFifteen, lifetime);
                    animatePrefab(instantiatedObjectFifteen);
                break;
                case 16:
                    instantiatedObjectSixteen = Instantiate(patternPrefabSixteen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectSixteen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectSixteen, lifetime);
                    animatePrefab(instantiatedObjectSixteen);
                break;
                case 17:
                    instantiatedObjectSeventeen = Instantiate(patternPrefabSeventeen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectSeventeen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectSeventeen, lifetime);
                    animatePrefab(instantiatedObjectSeventeen);
                break;
                case 18:
                    instantiatedObjectEighteen = Instantiate(patternPrefabEighteen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectEighteen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectEighteen, lifetime);
                    animatePrefab(instantiatedObjectEighteen);
                break;
                case 19:
                    instantiatedObjectNinteen = Instantiate(patternPrefabNinteen, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectNinteen.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectNinteen, lifetime);
                    animatePrefab(instantiatedObjectNinteen);
                break;
                case 20:
                    instantiatedObjectTwenty = Instantiate(patternPrefabTwenty, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectTwenty.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectTwenty, lifetime);
                    animatePrefab(instantiatedObjectTwenty);
                break;
                case 21:
                    instantiatedObjectTwentyone = Instantiate(patternPrefabTwentyone, new Vector3(prefabX, prefabY, prefabZ), Quaternion.identity) as GameObject;
                    instantiatedObjectTwentyone.transform.SetParent(this.transform);
                    Destroy(instantiatedObjectTwentyone, lifetime);
                    animatePrefab(instantiatedObjectTwentyone);
                break;
        }
        
    }

    private void playNext()
    {
        if (currentPrefab < 21)
        {
            currentPrefab++;
        } else {
            currentPrefab = 1;
        }
        launchPrefab(currentPrefab);
    }

    public void animatePrefab(GameObject whichPrefab)
    {
        iTween.MoveFrom(whichPrefab, iTween.Hash("x", 2.25f, "time", prefabSpeed, "easeType", "linear", "loopType", "none", "delay", prefabDelay));
        iTween.MoveTo(whichPrefab, iTween.Hash("x", -2.25f, "time", prefabSpeed, "easeType", "linear", "loopType", "none", "oncomplete", "playNext", "oncompletetarget", gameObject, "delay", prefabDelay));
        /*
         * switch (tweenStyle)
        {
            case 1:
                iTween.MoveFrom(whichPrefab, iTween.Hash("y", 16, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", 0));
                iTween.MoveTo(whichPrefab, iTween.Hash("y", -16, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", .5f));
            break;
            case 2:
                iTween.MoveFrom(whichPrefab, iTween.Hash("y", -16, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", 0));
                iTween.MoveTo(whichPrefab, iTween.Hash("y", 16, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", .5f));
            break;
            case 3:
                iTween.MoveFrom(whichPrefab, iTween.Hash("x", 26, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", 0));
                iTween.MoveTo(whichPrefab, iTween.Hash("x", -26, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", .5f));
            break;
            case 4:
                iTween.MoveFrom(whichPrefab, iTween.Hash("x", -26, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", 0));
                iTween.MoveTo(whichPrefab, iTween.Hash("x", 26, "time", .5f, "easeType", "easeInOutSine", "loopType", "none", "delay", .5f));
            break;
        }
        */

    }
}