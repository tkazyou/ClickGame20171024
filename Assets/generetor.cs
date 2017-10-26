using UnityEngine;
using System.Collections;

public class generetor : MonoBehaviour {
    GameObject shootfab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
             GameObject shoot =
                Instantiate(shootfab) as GameObject;
            shootfab.GetComponent<controler>().shoot(new Vector3(0, 0, 2000));
        }
	}
}
