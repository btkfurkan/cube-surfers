using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    public GameObject player;
 

    [SerializeField]
    private float dikeyHiz;

    [SerializeField]
    private float yatayHiz;


    void Start()
    {

    }


    void Update()
    {

        OyuncuHareket();


    }

    void OyuncuHareket()
    {
       
            float horizontalInput = Input.GetAxis("Horizontal") * yatayHiz * Time.deltaTime;

            player.transform.Translate(horizontalInput, 0, dikeyHiz * Time.deltaTime);

    }
   
}
