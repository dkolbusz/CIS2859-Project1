using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{
    [SerializeField]
    private GameObject fireballPrefab;
    private GameObject fireball;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
             fireball = Instantiate(fireballPrefab) as GameObject;

                    fireball.transform.position = 
                        transform.TransformPoint(Vector3.forward * 1.5f);
                    fireball.transform.rotation = transform.rotation;
        }
    }

    private void OnGUI()
    {
        int size = 12;
        float posX = GetComponent<Camera>().pixelWidth / 2 - size / 4;
        float posY = GetComponent<Camera>().pixelHeight / 2 - size / 2;
        //display text on screen in a label
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }

}
