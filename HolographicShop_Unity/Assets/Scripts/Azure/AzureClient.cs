using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AzureClient : MonoBehaviour
{
    public List<Category> categories;
    public List<Product> products;

    private void Start()
    {
        DownloadCategories();
    }

    public void DownloadCategories()
    {
        StartCoroutine(GetCategories());
    }

    private IEnumerator GetCategories()
    {
        var url = AzureUrls.BaseUrl + AzureUrls.Category;

        var www = UnityWebRequest.Get(url);
        www.SetRequestHeader("ZUMO-API-VERSION", "2.0.0");

        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }
        else
        {
            var json = www.downloadHandler.text;

            categories = JsonUtility.FromJson<List<Category>>(json);

            foreach (var category in categories)
            {
                Debug.Log("Category: " + category.Name);
            }
        }
    }

    private IEnumerator GetProducts(string categoryID)
    {
        var url = AzureUrls.BaseUrl + AzureUrls.Category + categoryID;

        var www = UnityWebRequest.Get(url);
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }
        else
        {
            var json = www.downloadHandler.text;

            products = JsonUtility.FromJson<List<Product>>(json);
        }
    }

    public void DownloadProduct(string productID)
    {

    }
}
