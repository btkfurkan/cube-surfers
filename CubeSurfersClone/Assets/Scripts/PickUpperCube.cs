using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpperCube : MonoBehaviour
{
    public GameObject player;
    int yukseklik;
    void Start()
    {

    }


    void Update()
    {
        player.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    public void YukseklikAzalt()
    {
        yukseklik--;

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "topla" && other.gameObject.GetComponent<pickUpCube>().GetToplandiMi()==false)
        {
            yukseklik++;
            other.gameObject.GetComponent<pickUpCube>().ToplandiMi();
            other.gameObject.GetComponent<pickUpCube>().indexAyarla(yukseklik);
            other.gameObject.transform.parent = player.transform;


        }
    }
}
