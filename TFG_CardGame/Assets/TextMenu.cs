using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class TextMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userLevelText;
    [SerializeField] private TextMeshProUGUI userGoldText;
    [SerializeField] private TextMeshProUGUI userEssenceText;

    [SerializeField] private TextMeshProUGUI menuStoreButton;
    [SerializeField] private TextMeshProUGUI menuStoreGoldStore;
    [SerializeField] private TextMeshProUGUI menuStoreBundleStore;
    [SerializeField] private TextMeshProUGUI menuStoreCardStore;
    [SerializeField] private TextMeshProUGUI menuStorePurchasePrompt;
    [SerializeField] private TextMeshProUGUI menuStorePurchaseConfirmation;
    [SerializeField] private TextMeshProUGUI menuStorePurchaseBack;

    [SerializeField] private TextMeshProUGUI menuTextName;
    [SerializeField] private TextMeshProUGUI menuTextDescription;
    [SerializeField] private TextMeshProUGUI menuTextDamage;
    [SerializeField] private TextMeshProUGUI menuTextAttackSpeed;
    [SerializeField] private TextMeshProUGUI menuTextDPS;
    [SerializeField] private TextMeshProUGUI menuTextHP;
    [SerializeField] private TextMeshProUGUI menuTextUnits;
    [SerializeField] private TextMeshProUGUI menuTextSpeed;
    [SerializeField] private TextMeshProUGUI menuTextType;
    [SerializeField] private TextMeshProUGUI menuTextTarget;
    [SerializeField] private TextMeshProUGUI menuTextRange;

    [SerializeField] private TextMeshProUGUI menuDeckButton;
    [SerializeField] private TextMeshProUGUI menuBattleButton;

    [SerializeField] private TextMeshProUGUI menuOptionsButton;
    [SerializeField] private TextMeshProUGUI menuOptionsTitle;
    [SerializeField] private TextMeshProUGUI menuOptionsLanguage;
    [SerializeField] private TextMeshProUGUI menuOptionsActivateCrowd;

    [SerializeField] public bool isCrowdActive;

    public int userLevel;
    public int userGold;
    public int userEssence;
    public Card selectedcard;
    [SerializeField] public string userLanguage;
    string path;
    private string jsonMenu;
    private string jsonCards;
    menuterms terms;
    public Card cardtocopy;
    void Start ()
    {
        isCrowdActive = false;
        userGold = 100;
        userLevel = 10;
        userEssence = 2000;
        userLanguage = "eng";
        path = Application.dataPath + "/eng.json";
        jsonMenu = File.ReadAllText(path);
        terms = JsonUtility.FromJson<menuterms>(jsonMenu);
        //changeLang(userLanguage, terms);
        updateLang(terms);
        //Debug.Log(terms.tl_level);
    }
    void Update ()
    {
        //Debug.Log(userLanguage);

        updateLang(terms);
        //changeLang(userLanguage, terms);
    }

    public void changeLang(string newLang, menuterms newterms)
    {
        //if (System.IO.File.Exists(Application.dataPath + "/" + newLang + ".json"))
        //{
        //    path = Application.dataPath + "/" + newLang + ".json";
        //    // The file exists -> run event
        //}
        //path = Application.dataPath + "/" + newLang + ".json";
        //Debug.Log("Path: " + path);
        //jsonMenu = File.ReadAllText(path);
        //Debug.Log("JsonMenu: " + jsonMenu);
        //newterms = JsonUtility.FromJson<menuterms>(jsonMenu);
        //Debug.Log("NewTerms: " + newterms);
    }

    public void updateLang(menuterms sth)
    {
        path = Application.dataPath + "/" + userLanguage + ".json";
        //Debug.Log("Path: " + path);
        jsonMenu = File.ReadAllText(path);
        //Debug.Log("JsonMenu: " + jsonMenu);
        sth = JsonUtility.FromJson<menuterms>(jsonMenu);
        //Debug.Log("NewTerms: " + sth);

        userLevelText.text = sth.tl_level + "\n" + userLevel.ToString();
        userGoldText.text = sth.tl_gold + "\n" + userGold.ToString();
        userEssenceText.text = sth.tl_essence + "\n" + userEssence.ToString();

        //Debug.Log(sth);
        //Debug.Log(sth.tl_store);
        //Debug.Log(path);

        menuStoreButton.text = sth.tl_store;
        menuStoreGoldStore.text = sth.tl_gold;
        menuStoreBundleStore.text = sth.tl_bundles;
        menuStoreCardStore.text = sth.tl_cards;
        menuStorePurchaseBack.text = sth.tl_back;
        menuStorePurchaseConfirmation.text = sth.tl_confirm;
        menuStorePurchasePrompt.text = sth.tl_purchaseconfirm;

        menuTextName.text = sth.tl_name;
        menuTextDescription.text = sth.tl_description;
        menuTextDamage.text = sth.tl_damage;
        menuTextAttackSpeed.text = sth.tl_attackspeed;
        menuTextDPS.text = sth.tl_dps;
        menuTextHP.text = sth.tl_hp;
        menuTextUnits.text = sth.tl_units;
        menuTextSpeed.text = sth.tl_speed;
        menuTextType.text = sth.tl_type;
        menuTextTarget.text = sth.tl_targets;
        menuTextRange.text = sth.tl_range;

        menuDeckButton.text = sth.tl_deck;
        menuBattleButton.text = sth.tl_battle;

        menuOptionsButton.text = sth.tl_options;
        menuOptionsTitle.text = sth.tl_options;
        menuOptionsLanguage.text = sth.tl_language;
        menuOptionsActivateCrowd.text = sth.tl_activatecrowd;
    }
}

[System.Serializable]
public class Card
{
    public string tl_id;
    public string tl_name;
    public string tl_description;
    public string tl_damage;
    public string tl_attackspeed;
    public string tl_dps;
    public string tl_hp;
    public string tl_units;
    public string tl_speed;
    public string tl_type;
    public string tl_targets;
    public string tl_range;
}

[System.Serializable]
public class menuterms
{
    public string tl_back;
    public string tl_battle;
    public string tl_bundles;
    public string tl_cancel;
    public string tl_cards;
    public string tl_collection;
    public string tl_confirm;
    public string tl_deck;
    public string tl_essence;
    public string tl_gold;
    public string tl_language;
    public string tl_level;
    public string tl_no;
    public string tl_ok;
    public string tl_options;
    public string tl_purchase;
    public string tl_store;
    public string tl_yes;
    public string tl_purchaseconfirm;
    public string tl_rewardgiven;
    public string tl_translateconfirm;
    public string tl_activatecrowd;
    public string tl_card;
    public string tl_name;
    public string tl_description;
    public string tl_damage;
    public string tl_attackspeed;
    public string tl_dps;
    public string tl_hp;
    public string tl_units;
    public string tl_speed;
    public string tl_type;
    public string tl_targets;
    public string tl_range;
}

[System.Serializable]
public class cards
{
    public Card crossbowman;
    public Card barbarian;
    public Card wolfpack;
}