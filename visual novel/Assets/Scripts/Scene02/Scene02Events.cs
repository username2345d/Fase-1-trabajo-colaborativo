using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02Events : MonoBehaviour
{

    public GameObject textBox;
    [SerializeField] GameObject FadeScreenIn;
    [SerializeField] GameObject charThalassaSpeakAnim;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLenght;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    void Update()
    {
        
    }

    IEnumerator EventStarter()
    {
        //event 0
        yield return new WaitForSeconds(2);
        FadeScreenIn.SetActive(false);

        yield return new WaitForSeconds(2);
        charThalassaSpeakAnim.SetActive(true);
        mainTextObject.SetActive(true);
        textToSpeak = "Fhós… You can still stop this. You don’t have to keep carrying everything alone.";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLenght = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLenght);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 1;

    }
}
