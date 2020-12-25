using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFirstGameStart : MonoBehaviour
{
    public GameObject[] TimeStart;
    public GameObject[] Cameras;

    // Start is called before the first frame update
    void Start()
    {
        TimeStart[0].SetActive(true);
        Cameras[0].SetActive(true);
        StartCoroutine(emolator());
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator emolator()
    {
        yield return new WaitForSeconds(1f);
        //Count
        TimeStart[0].SetActive(false);
        TimeStart[1].SetActive(true);
        TimeStart[2].SetActive(false);
        //Camera
        Cameras[0].SetActive(false);
        Cameras[1].SetActive(true);
        Cameras[2].SetActive(false);

        yield return new WaitForSeconds(2f);
        //Count
        TimeStart[0].SetActive(false);
        TimeStart[1].SetActive(false);
        TimeStart[2].SetActive(true);
        //Camera
        Cameras[0].SetActive(false);
        Cameras[1].SetActive(false);
        Cameras[2].SetActive(true);

        yield return new WaitForSeconds(2.25f);
        //Count
        TimeStart[0].SetActive(false);
        TimeStart[1].SetActive(false);
        TimeStart[2].SetActive(false);
        TimeStart[3].SetActive(true);
        //Camera
        Cameras[2].SetActive(false);
        yield return new WaitForSeconds(2.30f);
        //Count
        TimeStart[3].SetActive(false);

    }
}
