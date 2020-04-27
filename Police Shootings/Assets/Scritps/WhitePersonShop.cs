using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePersonShop : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject EndCollision;
    public GameObject Obj1, Obj2;
    public GameObject logo, house;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            print("Hit");
            Obj1.SetActive(false);
            logo.SetActive(false);
            Obj2.SetActive(true);
            house.SetActive(true);
            EndCollision.SetActive(true);

        }

        
    }

    void Update()
    {
        
    }
}
