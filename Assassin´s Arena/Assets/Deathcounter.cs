using UnityEngine;
using UnityEngine.UI;

public class Deathcounter : MonoBehaviour
{
    public Text Killcounter;
    public GameObject Killcounterobj;

    void Update()
    {
        Killcounter.text = Enemy_Health.killchanger.ToString();

        if (Enemy_Health.killchanger < 10)
        {

            RectTransform rectTransform = Killcounter.GetComponent<RectTransform>();
            rectTransform.localPosition = new Vector3(170, rectTransform.localPosition.y, rectTransform.localPosition.z);
        }
        else if (Enemy_Health.killchanger > 10)
        {
            
            RectTransform rectTransform = Killcounter.GetComponent<RectTransform>();
            rectTransform.localPosition = new Vector3(199, rectTransform.localPosition.y, rectTransform.localPosition.z);
        }
        else if (Enemy_Health.killchanger > 100)
        {

            RectTransform rectTransform = Killcounter.GetComponent<RectTransform>();
            rectTransform.localPosition = new Vector3(230, rectTransform.localPosition.y, rectTransform.localPosition.z);
        }
    }
}
