using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class planeTimer : MonoBehaviour {
    public float interval;
    public string Level2;
    public bool addTime = false;
    // Use this for initialization
    void Start () {
	
	}

    public void moreTime()
    {
        addTime = true;
        interval = 30;

    }

    // Update is called once per frame
    void Update()
    {




        if (interval > 0)
        {
            interval -= Time.deltaTime;
        }
        else
        {
            //enabled = false;
            SceneManager.LoadScene(Level2);
        }

     

    }
        

       
    
    
}
