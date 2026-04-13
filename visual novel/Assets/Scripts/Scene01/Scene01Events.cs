using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{

    public GameObject FadeScreenIn;
    public GameObject charFhós;
    public GameObject charFhósSpeak1;
    public GameObject charFhósSpeak2;
    public GameObject charNpc;
    public GameObject TextBox;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    // This coroutine controls the entire initial sequence of Scene 01.
    // It is the main part of the events in this scene (intro cinematic) and character timings.
    IEnumerator EventStarter() 
    {
        yield return new WaitForSeconds(2);
        FadeScreenIn.SetActive(false);

        yield return new WaitForSeconds(1);
        charFhós.SetActive(true);

        yield return new WaitForSeconds(2);
        TextBox.SetActive(true);

        yield return new WaitForSeconds(6);
        charFhós.SetActive(false);
        charFhósSpeak1.SetActive(true);

        yield return new WaitForSeconds(6);
        charFhósSpeak1.SetActive(false);
        charFhósSpeak2.SetActive(true);

        yield return new WaitForSeconds(5);
        charFhósSpeak2.SetActive(false);
        charFhós.SetActive(true);

        yield return new WaitForSeconds(1);
        charNpc.SetActive(true);

    }


}
