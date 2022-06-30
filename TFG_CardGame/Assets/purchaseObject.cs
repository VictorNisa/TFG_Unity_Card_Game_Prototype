using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class purchaseObject : MonoBehaviour
{
    public TextMenu tmenu;
    public string id;
    string path;
    private string jsonMenu;
    //card
    public string damage;
    public string attackspeed;
    public string dps;
    public string hp;
    public string units;
    public string speed;
    [SerializeField] private TextMeshProUGUI menuTextCardName;
    [SerializeField] private TextMeshProUGUI menuTextCardDescription;
    [SerializeField] private TextMeshProUGUI menuTextCardDamage;
    [SerializeField] private TextMeshProUGUI menuTextAttackSpeed;
    [SerializeField] private TextMeshProUGUI menuTextDPS;
    [SerializeField] private TextMeshProUGUI menuTextHP;
    [SerializeField] private TextMeshProUGUI menuTextUnits;
    [SerializeField] private TextMeshProUGUI menuTextSpeed;
    [SerializeField] private TextMeshProUGUI menuTextCardType;
    [SerializeField] private TextMeshProUGUI menuTextCardTarget;
    [SerializeField] private TextMeshProUGUI menuTextCardRange;

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
        tmenu.selectedcard.tl_id = id;
        path = Application.dataPath + "/" + id + "_" + tmenu.userLanguage + ".json";
        jsonMenu = File.ReadAllText(path);
        tmenu.cardtocopy = JsonUtility.FromJson<Card>(jsonMenu);
        menuTextCardDamage.text = damage;
        menuTextAttackSpeed.text = attackspeed;
        menuTextDPS.text = dps;
        menuTextHP.text = hp;
        menuTextUnits.text = units;
        menuTextSpeed.text = speed;
        menuTextCardDescription.text = tmenu.cardtocopy.tl_description;
        menuTextCardName.text = tmenu.cardtocopy.tl_name;
        menuTextCardType.text = tmenu.cardtocopy.tl_type;
        menuTextCardTarget.text = tmenu.cardtocopy.tl_targets;
        menuTextCardRange.text = tmenu.cardtocopy.tl_range;
    }
}
