using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pages : MonoBehaviour
{
    public GameObject page;
    public int templatesPerPage = 21;

    MaterialChanger materialChanger;
    int currentPage;

    public List<GameObject> pages = new List<GameObject>();

    private void Awake()
    {
        materialChanger = GetComponent<MaterialChanger>();
        int amoutOfPages = (materialChanger.possibleMaterials.Length / templatesPerPage) + 1;
        for (int i = 0; i < amoutOfPages; i++)
        {
            GameObject tempPage = Instantiate(page, transform);
            pages.Add(tempPage);
            if (i > 0)
                tempPage.SetActive(false);
        }
    }

    public Transform GetPage(int pageNumber)
    {
        return pages[pageNumber].transform;
    }

    public void NextPage()
    {
        if(pages[currentPage])
            pages[currentPage].SetActive(false);

        if (currentPage + 1 < pages.Count)
            currentPage++;
        else
            currentPage = 0;

        if (pages[currentPage])
            pages[currentPage].SetActive(true);
    } 

    public void PreviousPage()
    {
        if (pages[currentPage])
            pages[currentPage].SetActive(false);

        if (currentPage > 0)
            currentPage--;
        else
            currentPage = pages.Count - 1;

        if (pages[currentPage])
            pages[currentPage].SetActive(true);
    }
}
