using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialTemplate : MonoBehaviour
{
    public RawImage exampleImage;

    Material currentMaterial;

    public void Initialize(Material material)
    {
        currentMaterial = material;
        exampleImage.texture = currentMaterial.mainTexture;
    }

    public void SetMaterial()
    {
        MaterialChanger.instance.ChangeMaterial(currentMaterial);
    }
}
