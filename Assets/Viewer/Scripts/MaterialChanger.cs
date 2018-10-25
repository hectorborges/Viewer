using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public static MaterialChanger instance;
    public Renderer[] renderersToChange;
    public Material[] possibleMaterials;
    public Transform parentTransform;
    public MaterialTemplate materialTemplate;
    public bool canBeColored;

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        foreach(Material material in possibleMaterials)
        {
            MaterialTemplate newMaterialTemplate = Instantiate(materialTemplate, parentTransform);
            newMaterialTemplate.Initialize(material);
        }
    }

    public void ChangeMaterial(Material newMaterial)
    {
        foreach(Renderer renderer in renderersToChange)
        {
            renderer.material = newMaterial;
        }
    }
}
