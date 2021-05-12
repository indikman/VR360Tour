using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TourManager : MonoBehaviour
{
    private static TourManager _Instance;

    public GameObject XRRig;

    public static TourManager Instance()
    {
        return _Instance;
    }

    void Awake()
    {
        if(_Instance != null && _Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _Instance = this;
        }
    }


    public void NavigateTo(GameObject scene)
    {
        XRRig.transform.position = scene.transform.position;
    }

  
}
