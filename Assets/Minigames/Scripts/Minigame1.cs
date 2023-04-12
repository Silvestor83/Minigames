using UnityEngine;
using UnityEngine.UI;

public class Minigame1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var text = GameObject.Find("Text");
        var textBeh = text.GetComponent<Text>();

        var coreService = new CoreService();

        textBeh.text = coreService.Text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
