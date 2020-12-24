using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacters : MonoBehaviour
{
    public GameObject[] Characters;

    public int numberCharacter = 0;

    // Start is called before the first frame update
    void Start()
    {
        numberCharacter = PlayerPrefs.GetInt("Characters");
    }

    // Update is called once per frame
    void Update()
    {
        if (numberCharacter == 0)
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
        if (numberCharacter == 1)
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
        if (numberCharacter == 2)
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
        if (numberCharacter == 3)
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
        if (numberCharacter == 4)
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
        if (numberCharacter == 5)
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
        if (numberCharacter == 6)
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
        if (numberCharacter == 7)
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
        if (numberCharacter == 8)
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
        if (numberCharacter == 9)
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
        if (numberCharacter == 10)
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
        if (numberCharacter == 11)
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
            Characters[11].SetActive(true);
            Characters[12].SetActive(false);
        }
        if (numberCharacter == 12)
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
    public void NextCharacters()
    {
        numberCharacter++;
        if (numberCharacter > 13)
        {
            numberCharacter = 0;
        }
    }
    public void BackCharacters()
    {
        numberCharacter--;
        if (numberCharacter < -1)
        {
            numberCharacter = 13;
        }
    }
    public void Select_Ch()
    {
        PlayerPrefs.SetInt("Characters", numberCharacter);
        PlayerPrefs.Save();
    }
    public void GoScene()
    {
        Application.LoadLevel("Demo");
    }
}
