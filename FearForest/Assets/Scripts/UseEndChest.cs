using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UseEndChest : MonoBehaviour
{
    private GameObject OB;
    public GameObject handUI;
    public GameObject lockUI;
    private bool inReach;
    public int keyNum = 4;
    public Text textKEY;

    void Start()
    {
        textKEY.text = "KEY x" + keyNum;

        OB = this.gameObject;
        handUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach" && keyNum == 0)
        {
            inReach = true;
            handUI.SetActive(true);
        }
        if (other.gameObject.tag == "Reach" && keyNum > 0)
        {
            inReach = false;
            lockUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            handUI.SetActive(false);
            lockUI.SetActive(false);
        }
    }
    public void GetKey()
    {
        keyNum -= 1;
        textKEY.text = "KEY x" + keyNum;
    }
    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            handUI.SetActive(false);
            lockUI.SetActive(false);
            OB.GetComponent<Animator>().SetBool("open", true);
            
            Invoke("GameClear", 3f);
        }
    }
    private void GameClear()
    {
        SceneManager.LoadScene("GameClear");
    }
}
