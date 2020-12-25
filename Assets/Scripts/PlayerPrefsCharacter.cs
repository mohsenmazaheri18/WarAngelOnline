using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsCharacter : MonoBehaviour
{

    public GameObject[] Characters;

    public GameObject[] Respwan;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Characters") == 0)
        {
            Vector3 position = new Vector3(Random.Range(0,Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[0], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 1)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[1], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 2)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[2], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 3)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[3], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 4)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[4], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 5)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[5], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 6)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[6], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 7)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[7], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 8)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[8], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 9)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[9], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 10)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[10], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 11)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[11], position, Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("Characters") == 12)
        {
            Vector3 position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
            Instantiate(Characters[12], position, Quaternion.identity);
        }
    }
}
