using UnityEngine;
using System.Collections;

public class target : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "shoot")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
	
	}
}
