using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vibtoggle : MonoBehaviour
{
    public GameObject Ball;
    

    [SerializeField] Image vibonIcon;
    [SerializeField] Image viboffIcon;

    private bool muted = false;
    // Start is called before the first frame update
    
    void Start()
    {
        if (!PlayerPrefs.HasKey("vibmuted"))
        {
            PlayerPrefs.SetInt("vibmuted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        
        //GameObject.Find("Ball").GetComponent<Ball>().vib = muted;
        // AudioListener.pause = muted;
    }


    public void OnbuttonPress()
    {
        if (muted == false)
        {
            muted = true;
           // AudioListener.pause = true;


        }
        else
        {
            muted = false;
           // AudioListener.pause = false;
        }

        Save();
        UpdateButtonIcon();
    }




    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            vibonIcon.enabled = true;
            viboffIcon.enabled = false;
        }
        else
        {
            vibonIcon.enabled = false;
            viboffIcon.enabled = true;

        }

    }





    // Update is called once per frame



    private void Load()
    {

        muted = PlayerPrefs.GetInt("vibmuted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("vibmuted", muted ? 1 : 0);

    }





}
