using System.Collections;
using TMPro;
using UnityEngine;

public class TextFlash : MonoBehaviour
{
    [SerializeField]
    private float _flashDuration;

    [SerializeField]
    private Color _flashColor;

    private IEnumerator Start()
    {
        var textMeshPro = GetComponent<TextMeshProUGUI>();
        var originalColor = textMeshPro.color;
        while (true)
        {
            yield return new WaitForSeconds(_flashDuration);
            textMeshPro.color = _flashColor;
            yield return new WaitForSeconds(_flashDuration);
            textMeshPro.color = originalColor;
        }
    }
}
