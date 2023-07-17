using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public float delay = 2f; // Delay in seconds before changing the audio clip
    public Button button; // Button to trigger the audio change

    private bool isAudioActive = false;
    private Coroutine audioChangeCoroutine; // Coroutine for changing the audio clip

    private void Start()
    {
        audioSource.gameObject.SetActive(false);
        button.onClick.AddListener(ChangeAudio);
    }

    private void Update()
    {
        if (!isAudioActive && Input.GetMouseButtonDown(0))
        {
            ActivateAudio();
        }
    }

    private void ActivateAudio()
    {
        audioSource.gameObject.SetActive(true);
        isAudioActive = true;
        PlayAudioClip(audioClips[0]);
        audioChangeCoroutine = StartCoroutine(ChangeAudioClip());
    }

    private void PlayAudioClip(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    private void ChangeAudio()
    {
        if (isAudioActive)
        {
            StopCoroutine(audioChangeCoroutine);

            if (audioClips.Length > 1)
            {
                PlayAudioClip(audioClips[1]);
            }
        }
    }

    private IEnumerator ChangeAudioClip()
    {
        yield return new WaitForSeconds(delay);

        if (audioClips.Length > 1)
        {
            PlayAudioClip(audioClips[1]);
        }
    }
}
