using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UI;

public class Shop_System : MonoBehaviour
{
    // Die Werte werden von PlayerPrefs geladen und gespeichert
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

    public Text txt_Currency;
    public GameObject redMagePanel;
    public GameObject greenMagePanel;
    public GameObject blueMagePanel;
    public GameObject blackMagePanel;

    public GameObject redMageBuyButton;
    public GameObject greenMageBuyButton;
    public GameObject blueMageBuyButton;
    public GameObject blackMageBuyButton;

    public GameObject redMageOwnedLabel;
    public GameObject greenMageOwnedLabel;
    public GameObject blueMageOwnedLabel;
    public GameObject blackMageOwnedLabel;

    public int redMagePrice;
    public int greenMagePrice;
    public int blueMagePrice;
    public int blackMagePrice;

    public GameObject redMagePricetag;
    public GameObject greenMagePricetag;
    public GameObject blueMagePricetag;
    public GameObject blackMagePricetag;

    public Text redMageText;
    public Text greenMageText;
    public Text blueMageText;
    public Text blackMageText;

    private GameObject activePanel;
    private GameObject activeBuyButton;
    private GameObject activeOwnedLabel;
    private GameObject activePriceTag;

    private void Start()
    {
        // Setze die Texte der Preise
        redMageText.text = redMagePrice.ToString();
        greenMageText.text = greenMagePrice.ToString();
        blueMageText.text = blueMagePrice.ToString();
        blackMageText.text = blackMagePrice.ToString();

        // Lade den Fortschritt beim Spielstart
        LoadProgress();

        // Überprüfe, ob Magier bereits gekauft wurden und aktualisiere die UI entsprechend
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
            blackMagePricetag.SetActive(true);
        }
    }

    void Update()
    {
        LoadProgress();
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

        if (BlackMageBought) 
        { 
            blackMageBuyButton.SetActive(true);
            blackMageOwnedLabel.SetActive(false);
            blackMagePricetag.SetActive(true);
        }

        // Aktualisiere die Anzeige der Münzen
        txt_Currency.text = Currency.ToString();
        CheckActivePanel();
    }

    void CheckActivePanel()
    {
        // Überprüfe, welches Panel aktiv ist
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
        else
        {
            activePanel = null;
            activeBuyButton = null;
            activeOwnedLabel = null;
            
        }
    }

    public void BuyCurrentMage()
    {
        int currentPrice = GetActiveMagePrice();
        if (activePanel != null && activeBuyButton != null && activeOwnedLabel != null && Currency >= currentPrice)
        {
            // Deaktiviere den Kaufbutton, das Preis-Tag und aktiviere das "Owned"-Label
            activeBuyButton.SetActive(false);
            activeOwnedLabel.SetActive(true);
            activePriceTag.SetActive(false);

            // Ziehe den Preis vom Spielerkonto ab
            Currency -= currentPrice;

            // Setze die entsprechende Variable, um anzuzeigen, dass der Magier gekauft wurde
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

            // Speichere den Fortschritt
            SaveProgress();
        }
    }


    int GetActiveMagePrice()
    {
        // Gib den Preis des aktiven Magiers zurück
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
        else if (activePanel == blueMagePanel)
        {
            return blackMagePrice;
        }
        return 0;
    }

    void SaveProgress()
    {
        // Speichere den Fortschritt
        PlayerPrefs.Save();
    }

    void LoadProgress()
    {
        // Lade den Fortschritt
        // Hier werden die Daten automatisch geladen, wenn sie vorhanden sind
    }
}
