using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseChest : MonoBehaviour
{
    private GameObject OB;
    public GameObject handUI;
    public GameObject objToActivate;
    private bool inReach;
    UseEndChest endChest;
    Pistol gun;
    void Start()
    {
        endChest = FindObjectOfType<UseEndChest>();
        gun = FindObjectOfType<Pistol>();
        OB = this.gameObject;
        handUI.SetActive(false);
        objToActivate.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            handUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            handUI.SetActive(false);
        }
    }

    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            handUI.SetActive(false);
            OB.GetComponent<Animator>().SetBool("open", true);
            Invoke("GetTheObject", 1);
            
        }
    }

    void GetTheObject()
    {
        objToActivate.SetActive(true);
        Invoke("ChangeTheText", 2);
    }
    void ChangeTheText()
    {
        objToActivate.SetActive(false);
        if (objToActivate.name == "Cart")
        {
            gun.currentAmmoInStorage += 10;
        }
        else if (objToActivate.name == "Key")
        {
            endChest.GetKey();
        }
    }
}
