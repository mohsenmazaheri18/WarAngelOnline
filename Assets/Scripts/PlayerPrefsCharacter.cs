using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsCharacter : MonoBehaviour
{

    public GameObject[] Characters;

    public GameObject[] Respwan;

    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Characters") == 0)
        {
            StartCoroutine(emolator1());
        }
        if (PlayerPrefs.GetInt("Characters") == 1)
        {
           StartCoroutine(emolator2());
        }
        if (PlayerPrefs.GetInt("Characters") == 2)
        {
            StartCoroutine(emolator3());
        }
        if (PlayerPrefs.GetInt("Characters") == 3)
        {
            StartCoroutine(emolator4());
        }
        if (PlayerPrefs.GetInt("Characters") == 4)
        {
            StartCoroutine(emolator5());
        }
        if (PlayerPrefs.GetInt("Characters") == 5)
        {
            StartCoroutine(emolator6());
        }
        if (PlayerPrefs.GetInt("Characters") == 6)
        {
           StartCoroutine(emolator7());
        }
        if (PlayerPrefs.GetInt("Characters") == 7)
        {
            StartCoroutine(emolator8());
        }
        if (PlayerPrefs.GetInt("Characters") == 8)
        {
            StartCoroutine(emolator9());
        }
        if (PlayerPrefs.GetInt("Characters") == 9)
        {
            StartCoroutine(emolator10());
        }
        if (PlayerPrefs.GetInt("Characters") == 10)
        {
            StartCoroutine(emolator11());
        }
        if (PlayerPrefs.GetInt("Characters") == 11)
        {
            StartCoroutine(emolator12());
        }
        if (PlayerPrefs.GetInt("Characters") == 12)
        {
            StartCoroutine(emolator13());
            
        }
    }
    IEnumerator emolator1()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[0], position, Quaternion.identity);
    }
    IEnumerator emolator2()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[1], position, Quaternion.identity);
    }
    IEnumerator emolator3()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[2], position, Quaternion.identity);
    }
    IEnumerator emolator4()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[3], position, Quaternion.identity);
    }
    IEnumerator emolator5()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[4], position, Quaternion.identity);
    }
    IEnumerator emolator6()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[5], position, Quaternion.identity);
    }
    IEnumerator emolator7()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[6], position, Quaternion.identity);
    }
    IEnumerator emolator8()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[7], position, Quaternion.identity);
    }
    IEnumerator emolator9()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[8], position, Quaternion.identity);
    }
    IEnumerator emolator10()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[9], position, Quaternion.identity);
    }
    IEnumerator emolator11()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[10], position, Quaternion.identity);
    }
    IEnumerator emolator12()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[11], position, Quaternion.identity);
    }
    IEnumerator emolator13()
    {
        yield return new WaitForSeconds(5f);
        position = new Vector3(Random.Range(0, Respwan.Length), 0, Random.Range(0, Respwan.Length));
        Instantiate(Characters[12], position, Quaternion.identity);
    }
}
