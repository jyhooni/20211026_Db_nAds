using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hoop : MonoBehaviour


{

    


    public int heartcount;

    //public GameObject Pannel;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.5f, 1.5f);
        float y = Random.Range(-6.0f, -6.1f);

        transform.position = new Vector3(x, y, 0);

        heartcount = 3;
}

    // Update is called once per frame
    void Update()
    {//���ο� ��ġ = ������ġ + ���� * �ӵ� 
        transform.position = transform.position + new Vector3(0, 1, 0) * Time.deltaTime;
        
        
        
        

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("collision");

        

       // if(collision.transform.tag == "topwall")
        //{
            
          //  Debug.Log(heartcount);
           // heartcount = heartcount - 1;
            //Debug.Log(heartcount);
         //   PlayerPrefs.SetInt("Heart", heartcount);
          //  if (PlayerPrefs.GetInt("Heart", 0) == 3)
           // {
            //    Debug.Log("heat 3");
             //   SceneManager.LoadScene("Gameover");
           // }

       // }

    }


   // private void OnCollisionEnter2D(Collision2D coll2)
    //{
        
     //   Debug.Log("1111111111111");

       // Debug.Log(coll2.gameObject.tag);

       // if (coll2.gameObject.tag == "topwall")
        //{
//            Debug.Log("GAMEOVER");
  //      /
    //        SceneManager.LoadScene("Gameover");

            //Pannel.SetActive(true);
            //�ð��� �����
      //      Time.timeScale = 0.0f;
           // Destroy(gameover.gameObject);

       // }
   // }

    
}


     
