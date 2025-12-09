using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColourGradingController : MonoBehaviour
{
    public List<Material> Shader_materials;
    public GameObject CanvasImage;
    public GameObject cameraColorGrading;

    void Update()
    {

        //toggling shaders
        ToggleCorrection();
    }

    public void ToggleCorrection()
    {

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            cameraColorGrading.SetActive(false);

        }

        // CustomLUT
        if (Input.GetKeyDown(KeyCode.E))
        {
            cameraColorGrading.SetActive(true);

            CanvasImage.GetComponent<RawImage>().material = Shader_materials[0];
        }
    }
}