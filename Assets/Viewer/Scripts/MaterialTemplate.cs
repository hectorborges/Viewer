using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialTemplate : MonoBehaviour
{
    public RawImage exampleImage;

    Material currentMaterial;
    MaterialChanger materialChanger;

    public void Initialize(MaterialChanger newMaterialChanger, Material material)
    {
        currentMaterial = material;
        exampleImage.texture = currentMaterial.mainTexture;
        materialChanger = newMaterialChanger;
    }

    public void SetMaterial()
    {
        materialChanger.ChangeMaterial(currentMaterial);
    }
}
