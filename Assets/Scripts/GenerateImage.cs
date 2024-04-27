using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateImage : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Image image;
    [SerializeField] private List<Sprite> images;

    private void Awake()
    {
        canvas.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.gameObject.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            canvas.enabled = true;
            StartCoroutine(Generate());
        }
    }

    private IEnumerator Generate()
    {
        image.sprite = images[Random.Range(0, images.Count)];

        yield return new WaitForSeconds(3);

        canvas.enabled = false;
    }
}
