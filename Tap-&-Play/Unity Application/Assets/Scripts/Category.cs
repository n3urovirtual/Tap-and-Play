using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Category : MonoBehaviour
{
    public string SelectedCat;
    public string NotSelectedCat;
    void Start()
    {
        SelectedCat = PlayerPrefs.GetString("SelectedCategory");
        NotSelectedCat = PlayerPrefs.GetString("NotSelectedCategory");
        GameObject.Find(SelectedCat).SetActive(true);
        GameObject.Find(NotSelectedCat).SetActive(false);
    }
}
