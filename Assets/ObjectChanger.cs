using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanger : MonoBehaviour
{
    public GameObject[] changeableObjects;
    public GameObject currentObject;

    public void ChangeObject(int newObjectIndex)
    {
        if(currentObject)
            currentObject.SetActive(false);

        currentObject = changeableObjects[newObjectIndex];
        currentObject.SetActive(true);
    }
}
