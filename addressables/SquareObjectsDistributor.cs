using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SquareObjectsDistributor : MonoBehaviour
{
    public SquareObject[] SquareObjectArray;

    [System.Serializable]
    public class SquareObject {
        public string sqObject;
        public AssetReference sqObjectReference;
        public Vector3 sqObjectPosition;
        public Vector3 sqObjectRotation;
    }

    public void DistributeObjects(GameObject whichSquare) {
        for(int i = 0; i < SquareObjectArray.Length; i++)
        {
             StartCoroutine(LoadAddressable(whichSquare, i));
        }
    }

    private IEnumerator LoadAddressable(GameObject whichSquare, int whichObject)
    {
        AsyncOperationHandle<GameObject> instHandle = Addressables.InstantiateAsync(SquareObjectArray[whichObject].sqObjectReference, transform);
        yield return instHandle;

        GameObject newObject = instHandle.Result;
    }
}
