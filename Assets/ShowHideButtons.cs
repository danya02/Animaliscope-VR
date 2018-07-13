using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRStandardAssets.Utils;


public class ShowHideButtons : MonoBehaviour
{

    [SerializeField] private SelectionSlider Slider;

    // Use this for initialization
    void Start()
    {
        Hide();
        Slider.OnBarFilled += HandleSelectionComplete;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public bool shown = false;
    void HandleSelectionComplete()
    {
        if (!shown)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    public void Show()
    {
        StartCoroutine("ShowWork");
        gameObject.GetComponentInChildren<Text>().text = "Hide";
        shown = true;

    }

    public void Hide()
    {
        StartCoroutine("HideWork");
        gameObject.GetComponentInChildren<Text>().text = "Show";
        shown = false;
    }
    public GameObject Menu;

    IEnumerator ShowWork()
    {
        Vector3 startScale = Menu.transform.localScale;
        Vector3 startPos = Menu.transform.position;
        Vector3 endScale = new Vector3(0.04881492f, 0.04881492f, 0.04881492f);
        Vector3 endPos = new Vector3(210.47f, 2.26f, 81.03f);
        for(int i=0; i<100; i++)
        {
            Menu.transform.position = Vector3.Lerp(startPos, endPos, i / 100);
            Menu.transform.localScale = Vector3.Lerp(startScale, endScale, i / 100);
            yield return new WaitForSeconds(0.05f);
        }
    }
    IEnumerator HideWork()
    {
        Vector3 startScale = Menu.transform.localScale;
        Vector3 startPos = Menu.transform.position;
        Vector3 endScale = new Vector3(0, 0, 0);
        Vector3 endPos = new Vector3(210.47f, 5, 81.03f);
        for (int i = 0; i < 100; i++)
        {
            Menu.transform.position = Vector3.Lerp(startPos, endPos, i / 100);
            Menu.transform.localScale = Vector3.Lerp(startScale, endScale, i / 100);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
