using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;


public class SwitchViewOnSlider : MonoBehaviour
{

    [SerializeField] private SelectionSlider Slider;

    // Use this for initialization
    void Start()
    {
        Slider.OnBarFilled += HandleSelectionComplete;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void HandleSelectionComplete()
    {
        StartCoroutine("FadeThru");

    }

    public VisionChangeController.PPModes mode;

    IEnumerator FadeThru()
    {
        Camera.main.GetComponent<VRCameraFade>().FadeOut(2, true);
        GameObject.Find("MenuShowHide").GetComponent<ShowHideButtons>().Hide();
        yield return new WaitForSeconds(2);
        Camera.main.GetComponent<VisionChangeController>().SetMode(mode);
        Camera.main.GetComponent<VRCameraFade>().FadeIn(2,true);

    }
}
