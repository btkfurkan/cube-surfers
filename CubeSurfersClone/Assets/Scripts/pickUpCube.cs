using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpCube : MonoBehaviour
{
    bool toplandiMi; // bir kere al�nan bir daha al�nmas�n diye kontrol
    int index;  // toplama pozisyonu y�ksekli�ini belirtecek
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
            upperPick.hp--;
            upperPick.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.GetComponent<BoxCollider>().enabled = false;
            if (upperPick.hp == 0)
            {
                upperPick.hp = -1;
                Time.timeScale = 0.0f;

            }


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
