using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpCube : MonoBehaviour
{
    bool toplandiMi; // bir kere alýnan bir daha alýnmasýn diye kontrol
    int index;  // toplama pozisyonu yüksekliðini belirtecek
    public PickUpperCube upperPick;

    void Start()
    {
        toplandiMi = false;
    }


    void Update()
    {
        if (toplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "engel")
        {
            upperPick.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetToplandiMi()
    {
        return toplandiMi;
    }
    public void ToplandiMi()
    {
        toplandiMi = true;
    }

    public void indexAyarla(int index)
    {
        this.index = index;
    }

}
