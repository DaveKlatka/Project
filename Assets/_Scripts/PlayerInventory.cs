using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

    public GameObject thePlayer;
    public GameObject inventory;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update ()
    {
	   if (Input.GetButtonDown("Inventory"))
        {
            StartCoroutine(InventoryScreen());
        }
	}

    private IEnumerator InventoryScreen()
    {
        if (inventory.activeInHierarchy == false)
        {
            inventory.SetActive(true);
            thePlayer.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {

            inventory.SetActive(false);
            thePlayer.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        yield return null;
    }
}
