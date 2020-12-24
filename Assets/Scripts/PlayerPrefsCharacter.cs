using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsCharacter : MonoBehaviour
{

    public GameObject[] Characters;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Characters") == 0)
        {
            Characters[0].SetActive(true);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 1)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(true);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 2)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(true);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 3)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(true);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 4)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(true);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 5)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(true);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 6)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(true);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 7)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(true);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 8)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(true);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 9)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(true);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 10)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(true);
            Characters[11].SetActive(false);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 11)
        {
            Characters[0].SetActive(true);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(true);
            Characters[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Characters") == 12)
        {
            Characters[0].SetActive(false);
            Characters[1].SetActive(false);
            Characters[2].SetActive(false);
            Characters[3].SetActive(false);
            Characters[4].SetActive(false);
            Characters[5].SetActive(false);
            Characters[6].SetActive(false);
            Characters[7].SetActive(false);
            Characters[8].SetActive(false);
            Characters[9].SetActive(false);
            Characters[10].SetActive(false);
            Characters[11].SetActive(false);
            Characters[12].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
