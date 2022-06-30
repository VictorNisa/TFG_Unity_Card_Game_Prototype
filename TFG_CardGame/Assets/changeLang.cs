using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLang : MonoBehaviour
{
    public TextMenu tmenu;
    public string lang;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        Debug.Log("Changed the language from " + tmenu.userLanguage + " to " + lang);
        tmenu.userLanguage = lang;
    }
}
