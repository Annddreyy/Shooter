using System.Collections;
using UnityEngine;
using TMPro;

public class ReactiveTarget : MonoBehaviour
{
    public int HP;
    public TMP_Text hpText;

    private void Awake()
    {
        HP = 5;
        hpText.text = $"HP: {HP}";
    }

    public void ReactToHit()
    {
        HP--;
        hpText.text = $"HP: {HP}";
        if (HP == 0)
        {
            WanderingAI behavior = GetComponent<WanderingAI>();
            if (behavior != null)
            {
                behavior.SetAlive(false);
            }
            StartCoroutine(Die());
        }
    }

    private IEnumerator Die()
    {
        transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1);

        Destroy(gameObject);
    }
}
