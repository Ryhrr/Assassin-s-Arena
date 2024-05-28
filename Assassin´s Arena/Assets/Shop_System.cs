using UnityEngine;
using UnityEngine.UI;

public class Shop_System : MonoBehaviour
{
    // The values are loaded and saved from PlayerPrefs
    public static int Currency
    {
        get { return PlayerPrefs.GetInt("Currency", 0); }
        set { PlayerPrefs.SetInt("Currency", value); }
    }

    public static bool RedMageBought
    {
        get { return PlayerPrefs.GetInt("RedMageBought", 0) == 1; }
        set { PlayerPrefs.SetInt("RedMageBought", value ? 1 : 0); }
    }

    public static bool GreenMageBought
    {
        get { return PlayerPrefs.GetInt("GreenMageBought", 0) == 1; }
        set { PlayerPrefs.SetInt("GreenMageBought", value ? 1 : 0); }
    }

    public static bool BlueMageBought
    {
        get { return PlayerPrefs.GetInt("BlueMageBought", 0) == 1; }
        set { PlayerPrefs.SetInt("BlueMageBought", value ? 1 : 0); }
    }

    public static bool BlackMageBought
    {
        get { return PlayerPrefs.GetInt("BlackMageBought", 0) == 1; }
        set { PlayerPrefs.SetInt("BlackMageBought", value ? 1 : 0); }
    }

    public static int MeteorCount
    {
        get { return PlayerPrefs.GetInt("MeteorCount", 0); }
        set { PlayerPrefs.SetInt("MeteorCount", value); }
    }

  
    public Text txt_Currency;
    public Text txt_MeteorCount; // Add a Text component to display the meteor count

    public GameObject redMagePanel;
    public GameObject greenMagePanel;
    public GameObject blueMagePanel;
    public GameObject blackMagePanel;
    public GameObject meteorPanel;

    public GameObject redMageBuyButton;
    public GameObject greenMageBuyButton;
    public GameObject blueMageBuyButton;
    public GameObject blackMageBuyButton;
    public GameObject meteorBuyButton;

    public GameObject redMageOwnedLabel;
    public GameObject greenMageOwnedLabel;
    public GameObject blueMageOwnedLabel;
    public GameObject blackMageOwnedLabel;

    public int redMagePrice;
    public int greenMagePrice;
    public int blueMagePrice;
    public int blackMagePrice;
    public int meteorPrice;

    public GameObject redMagePricetag;
    public GameObject greenMagePricetag;
    public GameObject blueMagePricetag;
    public GameObject blackMagePricetag;
    public GameObject meteorPricetag;

    public Text redMageText;
    public Text greenMageText;
    public Text blueMageText;
    public Text blackMageText;
    public Text meteorPricetagText;

    private GameObject activePanel;
    private GameObject activeBuyButton;
    private GameObject activeOwnedLabel;
    private GameObject activePriceTag;

    private void Start()
    {
        // Set the price texts
        redMageText.text = redMagePrice.ToString();
        greenMageText.text = greenMagePrice.ToString();
        blueMageText.text = blueMagePrice.ToString();
        blackMageText.text = blackMagePrice.ToString();
        meteorPricetagText.text = meteorPrice.ToString();

        // Load progress at the start of the game
        LoadProgress();

        // Check if mages have been bought and update the UI accordingly
        if (RedMageBought)
        {
            redMageBuyButton.SetActive(false);
            redMageOwnedLabel.SetActive(true);
            redMagePricetag.SetActive(false);
        }
        if (GreenMageBought)
        {
            greenMageBuyButton.SetActive(false);
            greenMageOwnedLabel.SetActive(true);
            greenMagePricetag.SetActive(false);
        }
        if (BlueMageBought)
        {
            blueMageBuyButton.SetActive(false);
            blueMageOwnedLabel.SetActive(true);
            blueMagePricetag.SetActive(false);
        }
        if (BlackMageBought)
        {
            blackMageBuyButton.SetActive(false);
            blackMageOwnedLabel.SetActive(true);
            blackMagePricetag.SetActive(false);
        }
        
        txt_MeteorCount.text = MeteorCount.ToString(); // Initialize the meteor count display
    }

    void Update()
    {
        // Update UI for mages that can be bought only once
        if (!RedMageBought)
        {
            redMageBuyButton.SetActive(true);
            redMageOwnedLabel.SetActive(false);
            redMagePricetag.SetActive(true);
        }
        if (!GreenMageBought)
        {
            greenMageBuyButton.SetActive(true);
            greenMageOwnedLabel.SetActive(false);
            greenMagePricetag.SetActive(true);
        }
        if (!BlueMageBought)
        {
            blueMageBuyButton.SetActive(true);
            blueMageOwnedLabel.SetActive(false);
            blueMagePricetag.SetActive(true);
        }
        if (!BlackMageBought)
        {
            blackMageBuyButton.SetActive(true);
            blackMageOwnedLabel.SetActive(false);
            blackMagePricetag.SetActive(true);
        }

        // Meteor button and price tag are always active for buying
        meteorBuyButton.SetActive(true);
        meteorPricetag.SetActive(true);

        // Update currency display
        txt_Currency.text = Currency.ToString();
        txt_MeteorCount.text = MeteorCount.ToString(); // Update the meteor count display

        // Check the active panel
        CheckActivePanel();
    }

    void CheckActivePanel()
    {
        // Check which panel is active
        if (redMagePanel.activeSelf)
        {
            activePanel = redMagePanel;
            activeBuyButton = redMageBuyButton;
            activeOwnedLabel = redMageOwnedLabel;
            activePriceTag = redMagePricetag;
        }
        else if (greenMagePanel.activeSelf)
        {
            activePanel = greenMagePanel;
            activeBuyButton = greenMageBuyButton;
            activeOwnedLabel = greenMageOwnedLabel;
            activePriceTag = greenMagePricetag;
        }
        else if (blueMagePanel.activeSelf)
        {
            activePanel = blueMagePanel;
            activeBuyButton = blueMageBuyButton;
            activeOwnedLabel = blueMageOwnedLabel;
            activePriceTag = blueMagePricetag;
        }
        else if (blackMagePanel.activeSelf)
        {
            activePanel = blackMagePanel;
            activeBuyButton = blackMageBuyButton;
            activeOwnedLabel = blackMageOwnedLabel;
            activePriceTag = blackMagePricetag;
        }
        else if (meteorPanel.activeSelf)
        {
            activePanel = meteorPanel;
            activeBuyButton = meteorBuyButton;
            activeOwnedLabel = null; // Meteor doesn't have an owned label
            activePriceTag = meteorPricetag;
        }
        else
        {
            activePanel = null;
            activeBuyButton = null;
            activeOwnedLabel = null;
            activePriceTag = null;
        }
    }

    public void BuyCurrentMage()
    {
        int currentPrice = GetActiveMagePrice();
        if (activePanel != null && activeBuyButton != null && Currency >= currentPrice)
        {
            if (activePanel == meteorPanel)
            {
                // Handle meteor purchase
                Currency -= currentPrice;
                MeteorCount++; // Increment the meteor count
                txt_MeteorCount.text = MeteorCount.ToString();
                SaveProgress();
            }
            else
            {
                // Deactivate buy button, price tag, and activate the "owned" label
                activeBuyButton.SetActive(false);
                activeOwnedLabel.SetActive(true);
                activePriceTag.SetActive(false);

                // Deduct the price from the player's currency
                Currency -= currentPrice;

                // Set the corresponding variable to indicate the mage has been bought
                if (activePanel == redMagePanel)
                {
                    RedMageBought = true;
                }
                else if (activePanel == greenMagePanel)
                {
                    GreenMageBought = true;
                }
                else if (activePanel == blueMagePanel)
                {
                    BlueMageBought = true;
                }
                else if (activePanel == blackMagePanel)
                {
                    BlackMageBought = true;
                }

                // Save the progress
                SaveProgress();
            }
        }
    }

    int GetActiveMagePrice()
    {
        // Return the price of the active mage
        if (activePanel == redMagePanel)
        {
            return redMagePrice;
        }
        else if (activePanel == greenMagePanel)
        {
            return greenMagePrice;
        }
        else if (activePanel == blueMagePanel)
        {
            return blueMagePrice;
        }
        else if (activePanel == blackMagePanel)
        {
            return blackMagePrice;
        }
        else if (activePanel == meteorPanel)
        {
            return meteorPrice;
        }
        return 0;
    }

    void SaveProgress()
    {
        // Save the progress
        PlayerPrefs.Save();
    }

    void LoadProgress()
    {
        // Load the progress
        // Data will be loaded automatically if available
    }
}
