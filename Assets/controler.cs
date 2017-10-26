using UnityEngine;
using System.Collections;

public class controler : MonoBehaviour
{
    
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    // Use this for initialization
    void Start()
    {
    //    shoot(new Vector3(0, 200, 2000));
    }

}
