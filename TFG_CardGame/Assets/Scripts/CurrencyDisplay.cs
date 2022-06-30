using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplay : MonoBehaviour
{
    private int currency = 5;
    public Text currencyText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        currencyText.text = "GOLD : " + currency;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currency--;
        }
    }
}
