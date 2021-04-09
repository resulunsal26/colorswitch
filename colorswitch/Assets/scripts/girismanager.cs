using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class girismanager : MonoBehaviour
{
    [SerializeField]
    private GameObject bir, iki, uc, dort, bes, alti;
    void Start()
    {
        StartCoroutine(basla());
       

    }
    IEnumerator basla()
    {
        bir.GetComponent<RectTransform>().DOLocalMoveX(-192, 1f);
        iki.GetComponent<RectTransform>().DOLocalMoveY(11, 1f);
        uc.GetComponent<RectTransform>().DOLocalMoveX(-245, 1f);
        dort.GetComponent<RectTransform>().DOLocalMoveY(-77, 1f);
        yield return new WaitForSeconds(1f);
        bes.transform.GetComponent<CanvasGroup>().DOFade(1, 1f);
        alti.transform.GetComponent<CanvasGroup>().DOFade(1, 1f);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SampleScene");


    }

   
}
