using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadAddressables : MonoBehaviour
{
    public AssetRefObject[] RefObjectArray;

    [System.Serializable]
    public class AssetRefObject {
        public string refObject;
        public AssetReference refObjectReference;
        public Vector3 refObjectPosition;
        public Vector3 refObjectRotation;
    }

    void Start(){
        DistributeObjects();
    }

    public void DistributeObjects() {
        for(int i = 0; i < RefObjectArray.Length; i++)
        {
             StartCoroutine(LoadAddressable(i));
        }
    }

    private IEnumerator LoadAddressable(int whichObject)
    {
        AsyncOperationHandle<GameObject> instHandle = Addressables.InstantiateAsync(RefObjectArray[whichObject].refObjectReference, transform);
        yield return instHandle;

        GameObject newObject = instHandle.Result;
        newObject.name = RefObjectArray[whichObject].refObject;
        newObject.transform.localPosition = RefObjectArray[whichObject].refObjectPosition;
    }
}
