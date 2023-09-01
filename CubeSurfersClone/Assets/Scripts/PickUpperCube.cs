using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUpperCube : MonoBehaviour
{
    
    public TextMeshProUGUI hpText;
    public GameObject player;
    int yukseklik;
    public int hp;

    public bool isGameActive;

    void Start()
    {

    }


    void Update()
    {
        hpText.text = "Hp : " + hp;
        player.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    public void YukseklikAzalt()
    {
        yukseklik--;

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "topla" && other.gameObject.GetComponent<pickUpCube>().GetToplandiMi() == false && IsGameActive())
        {


            yukseklik++;
            hp++;
            other.gameObject.GetComponent<pickUpCube>().ToplandiMi();
            other.gameObject.GetComponent<pickUpCube>().indexAyarla(yukseklik);
            other.gameObject.transform.parent = player.transform;


        }
    }
    public bool IsGameActive()
    {
        if (hp < 0)
        {
            isGameActive = false;
            

        }
        else
        {
            isGameActive = true;
        }
        return isGameActive;
    }
}
