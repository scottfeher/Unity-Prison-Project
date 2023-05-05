using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class incLevel : MonoBehaviour
{
    private bool isInteractable = false;
    public GameObject player, IntText;
    public int level = 1;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            isInteractable = true;
            IntText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            isInteractable = false;
            IntText.SetActive(false);
        }
    }

    void Update()
    {
        if(isInteractable == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
            level++;
            if (level > 2)
            {
                level = 1;
            }
            if (level == 2)
            {
                player.transform.position = new Vector3(498, 35, 517);
            }
            if(level == 1)
            {
                player.transform.position = new Vector3(498, 35, 517);

            }
            }


        }
        
    }
}
