using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class GameOver : MonoBehaviour
{
    public int heartcount;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Start is called before the first frame update
    void Start()
    {
        heartcount = 0;
       // Advertisement.Initialize(4402129, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("collision");

        if (collision.transform.tag == "hoop")
        {

            Debug.Log(heartcount);
            heartcount += 1;
            Debug.Log(heartcount);
            PlayerPrefs.SetInt("Heart", heartcount);
            if (PlayerPrefs.GetInt("Heart", 0) == 1)
            {
                Debug.Log("heat 1");
                heart3.SetActive(false);
            }
            if (PlayerPrefs.GetInt("Heart", 0) == 2)
            {
                Debug.Log("heat 2");
                heart2.SetActive(false);
            }

            if (PlayerPrefs.GetInt("Heart", 0) == 3)
            {
                Debug.Log("heat 3");
                heart1.SetActive(false);



                SceneManager.LoadScene("Gameover");
            }

        }

    }
}
