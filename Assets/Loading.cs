using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider LoadingBar;

    public Tween t;
    private void OnEnable()
    {
        LoadingBar.value = 0;
        t = LoadingBar.DOValue(1, 220f).OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
