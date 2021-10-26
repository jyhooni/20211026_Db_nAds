using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setsound : MonoBehaviour
{


    [SerializeField] Image soundonIcon;
    [SerializeField] Image soundoffIcon;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }


    public void OnbuttonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;


        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonIcon();
    }




    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundonIcon.enabled = true;
            soundoffIcon.enabled = false;
        }
        else
        {
            soundonIcon.enabled = false;
            soundoffIcon.enabled = true;

        }

    }

   

   

    // Update is called once per frame
    


    private void Load()
    {

        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);

    }




    
}
