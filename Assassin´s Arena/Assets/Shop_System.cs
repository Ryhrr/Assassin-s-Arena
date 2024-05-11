using UnityEngine;
using UnityEngine.UI;

public class Shop_System : MonoBehaviour
{
    public static int Currency;

    public Text txt_Currency;
    public GameObject redMagePanel;
    public GameObject greenMagePanel;
    public GameObject blueMagePanel;

    public GameObject redMageBuyButton;
    public GameObject greenMageBuyButton;
    public GameObject blueMageBuyButton;

    public GameObject redMageOwnedLabel;
    public GameObject greenMageOwnedLabel;
    public GameObject blueMageOwnedLabel;

    public int redMagePrice;
    public int greenMagePrice;
    public int blueMagePrice;

    public Text redMageText;
    public Text greenMageText;
    public Text blueMageText;

    private GameObject activePanel;
    private GameObject activeBuyButton;
    private GameObject activeOwnedLabel;

    private void Start()
    {
        redMageText.text = redMagePrice.ToString();
        greenMageText.text = greenMagePrice.ToString();
        blueMageText.text = blueMagePrice.ToString();


    }
    void Update()
    {
        txt_Currency.text = Currency.ToString();
        CheckActivePanel();
    }

    // Methode zum Überprüfen des aktiven Panels
    void CheckActivePanel()
    {
        if (redMagePanel.activeSelf)
        {
            activePanel = redMagePanel;
            activeBuyButton = redMageBuyButton;
            activeOwnedLabel = redMageOwnedLabel;
        }
        else if (greenMagePanel.activeSelf)
        {
            activePanel = greenMagePanel;
            activeBuyButton = greenMageBuyButton;
            activeOwnedLabel = greenMageOwnedLabel;
        }
        else if (blueMagePanel.activeSelf)
        {
            activePanel = blueMagePanel;
            activeBuyButton = blueMageBuyButton;
            activeOwnedLabel = blueMageOwnedLabel;
        }
        else
        {
            activePanel = null;
            activeBuyButton = null;
            activeOwnedLabel = null;
        }
    }

    // Methode zum Kaufen eines Magiers
    public void BuyCurrentMage()
    {
        int currentPrice = GetActiveMagePrice();
        if (activePanel != null && activeBuyButton != null && activeOwnedLabel != null && Currency >= currentPrice)
        {
            // Deaktiviere den Kaufbutton und aktiviere das "Owned"-Label
            activeBuyButton.SetActive(false);
            activeOwnedLabel.SetActive(true);
            // Ziehe den Preis vom Spielerkonto ab
            Currency -= currentPrice;
        }
    }

    // Methode zum Abrufen des Preises des aktiven Magiers
    int GetActiveMagePrice()
    {
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
        return 0;
    }
}
