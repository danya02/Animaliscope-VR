using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class VisionChangeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        pp = GetComponent<PostProcessingBehaviour>();

    }
	// Update is called once per frame
	void Update () {
		
	}
    public PostProcessingProfile HumanProfile, CatProfile, BirdProfile, DogProfile, FishProfile, SharkProfile, SnakeProfile, ProgrammerProfile;
    private Camera cam;
    private PostProcessingBehaviour pp;

    public enum PPModes { HUMAN, CAT, BIRD, DOG, FISH, SHARK, SNAKE, PROGRAMMER}

    public void SetMode(PPModes mode)
    {
        switch (mode)
        {
            case PPModes.HUMAN:SetHuman();break;
            case PPModes.CAT: SetNeko(); break;
            case PPModes.BIRD: SetBird(); break;
            case PPModes.DOG: SetDog(); break;
            case PPModes.FISH: SetFish(); break;
            case PPModes.SHARK: SetShark(); break;
            case PPModes.SNAKE: SetSnake(); break;
            case PPModes.PROGRAMMER: SetDev(); break;
        }
    }
    float divisor = 2;
    void SetHuman() {
        cam.fieldOfView = 150/divisor;
        cam.orthographic = false;
        pp.profile = HumanProfile;
    }
    void SetNeko()
    {
        cam.fieldOfView = 160/ divisor;
        cam.orthographic = false;
        pp.profile = CatProfile;
    }
    void SetBird()
    {
        cam.fieldOfView = 160 / divisor;
        cam.orthographic = false;
        pp.profile = BirdProfile;
    }
    void SetDog()
    {
        cam.fieldOfView = 160 / divisor;
        cam.orthographic = false;
        pp.profile = DogProfile;
    }
    void SetFish()
    {
        cam.fieldOfView = 160 / divisor;
        cam.orthographic = false;
        pp.profile = FishProfile;
    }
    void SetShark()
    {
        cam.fieldOfView = 160 / divisor;
        cam.orthographic = false;
        pp.profile = SharkProfile;
    }
    void SetSnake()
    {
        cam.fieldOfView = 160 / divisor;
        cam.orthographic = false;
        pp.profile = SnakeProfile;
    }
    void SetDev()
    {
        cam.fieldOfView = 150 / divisor;
        cam.orthographic = false ;
        pp.profile = ProgrammerProfile;
    }
}
