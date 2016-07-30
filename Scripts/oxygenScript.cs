using UnityEngine;
using System.Collections;


public class oxygenScript : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        //Destroy(gameObject, interval);
        
	}
	
    void OnCollisionEnter(Collision col)
    {
        GameObject.Find("Plane").SendMessage("moreTime");

        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject,1);
            
        }

        
        
    }
	// Update is called once per frame
	
}