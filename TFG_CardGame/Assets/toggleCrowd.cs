using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleCrowd : MonoBehaviour
{
    public TextMenu tmenu;

    public void onToggle()
    {
        tmenu.isCrowdActive = !tmenu.isCrowdActive;
        Debug.Log("Toggled Crowd Translations for " + tmenu.userLanguage + " to " + tmenu.isCrowdActive);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
