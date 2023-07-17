using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float fadeDuration = 2f; // Duration of the fade effect in seconds
    public Image[] imagesToFade; // Array of images to fade in
    public Button button; // Button to trigger the fade-in effect

    private Coroutine fadeCoroutine; // Coroutine for fading in images

    private void Start()
    {
        button.onClick.AddListener(StartFadeIn);
    }

    public void StartFadeIn()
    {
        if (fadeCoroutine != null)
            StopCoroutine(fadeCoroutine);

        fadeCoroutine = StartCoroutine(FadeInImages());
    }

    private IEnumerator FadeInImages()
    {
        foreach (Image image in imagesToFade)
        {
            image.gameObject.SetActive(true);

            Color initialColor = image.color;
            Color targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, 1f); // Fade đúng màu

            float elapsedTime = 0f;
            while (elapsedTime < fadeDuration)
            {
                float t = elapsedTime / fadeDuration;
                image.color = Color.Lerp(initialColor, targetColor, t);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // Sure kèo ảnh đã Fade hoàn toàn
            image.color = targetColor;

            yield return new WaitForSeconds(3f); // thời gian Delay ảnh
        }
    }
}