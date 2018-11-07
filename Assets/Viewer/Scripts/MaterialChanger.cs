using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Renderer[] renderersToChange;
    public Material[] possibleMaterials;
    public MaterialTemplate materialTemplate;
    public bool canBeColored;

    int templateCount;
    int currentPage;

    Pages pages;

    public void Start()
    {
        pages = GetComponent<Pages>();
        foreach(Material material in possibleMaterials)
        {
            if(templateCount < pages.templatesPerPage)
            {
                templateCount++;
                MaterialTemplate newMaterialTemplate = Instantiate(materialTemplate, pages.GetPage(currentPage));
                newMaterialTemplate.Initialize(this, material);
            }
            else
            {
                templateCount = 0;
                currentPage++;
            }
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
