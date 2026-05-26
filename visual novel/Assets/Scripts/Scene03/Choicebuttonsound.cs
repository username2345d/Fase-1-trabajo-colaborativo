using UnityEngine;

public class ChoiceButtonSound : MonoBehaviour
{
    [SerializeField] AudioSource buttonClick;

    public void PlayClick()
    {
        buttonClick.Play();
    }
}
