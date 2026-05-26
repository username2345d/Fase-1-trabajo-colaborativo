using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene04Events : MonoBehaviour
{
    [SerializeField] GameObject endText;
    [SerializeField] GameObject fadeOut;

    void Start()
    {
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(1.5f);

        endText.SetActive(true);

        yield return new WaitForSeconds(4f);

        fadeOut.SetActive(true);

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(0);
    }
}
