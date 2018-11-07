using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectArea : MonoBehaviour
{
    public Color selectedColor;
    public Color unSelectedColor;
    public ObjectChanger objectChanger;
    public Image currentImage;

    private void Start()
    {
        SetCurrentImage(currentImage);
    }

    public void SelectNewArea(ObjectChanger newObjectChanger)
    {
        objectChanger = newObjectChanger;
    }

    public void SetCurrentImage(Image newImage)
    {
        if (currentImage)
            currentImage.color = unSelectedColor;
        currentImage = newImage;
        currentImage.color = selectedColor;
    }

    public void ChangeOject(int newObjectIndex)
    {
        objectChanger.ChangeObject(newObjectIndex);
    }
}
