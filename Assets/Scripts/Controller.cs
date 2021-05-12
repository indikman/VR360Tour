using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private LineRenderer line;
    RaycastHit hit;
    GameObject selectedButton;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.enabled = false;
    }

    void Update()
    {
        if (Input.GetButton("XRI_Right_TriggerButton"))
        {
            line.enabled = true;
        }
        else
        {
            line.enabled = false;
        }

        Debug.DrawRay(transform.position, transform.forward * 3.0f, Color.green);

        if (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            Debug.Log("works");
            if (Physics.Raycast(transform.position, transform.forward, out hit, 3.0f))
            {
                selectedButton = hit.collider.gameObject;
                Debug.Log(selectedButton.name);
                if (selectedButton.CompareTag("navigator"))
                {
                    selectedButton.GetComponent<Navigator>().Navigate();
                }
            }
        }
    }
}
