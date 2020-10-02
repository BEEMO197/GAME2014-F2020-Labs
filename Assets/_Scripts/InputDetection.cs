using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputDetection : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoresLabel;

    public float livesLabelHalfWidth;
    public float livesLabelHalfHeight;

    public float ScoresLabelHalfWidth;
    public float ScoresLabelHalfHeight;

    public CanvasScaler scaler;
    public Vector2 scale;
    // Start is called before the first frame update
    void Start()
    {
        var currentResolution = new Vector2(Screen.currentResolution.width, Screen.currentResolution.height);
        scale = currentResolution / scaler.referenceResolution;

        livesLabelHalfWidth = LivesLabel.rectTransform.rect.width * 0.5f * scale.x;
        livesLabelHalfHeight = LivesLabel.rectTransform.rect.height * 0.5f * scale.y;

        ScoresLabelHalfWidth = ScoresLabel.rectTransform.rect.width * 0.5f * scale.x;
        ScoresLabelHalfHeight = ScoresLabel.rectTransform.rect.height * 0.5f * scale.x;
    }

    // Update is called once per frame
    void Update()
    {
        LivesLabel.rectTransform.position = new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);
        ScoresLabel.rectTransform.position = new Vector2(Screen.safeArea.xMax - ScoresLabelHalfWidth, Screen.safeArea.yMax - ScoresLabelHalfHeight);
        //switch(Input.deviceOrientation)
        //{
        //    case DeviceOrientation.Portrait:
        //        LivesLabel.rectTransform.position = new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);
        //        ScoresLabel.rectTransform.position = new Vector2(Screen.safeArea.xMax - ScoresLabelHalfWidth, Screen.safeArea.yMax - ScoresLabelHalfHeight);
        //        break;
        //
        //    case DeviceOrientation.LandscapeLeft:
        //        LivesLabel.rectTransform.position = new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth * 2, Screen.safeArea.yMax - livesLabelHalfHeight * 2);
        //        ScoresLabel.rectTransform.position = new Vector2(Screen.safeArea.xMax - ScoresLabelHalfWidth * 2, Screen.safeArea.yMax - ScoresLabelHalfHeight * 2);
        //        break;
        //
        //    case DeviceOrientation.LandscapeRight:
        //        LivesLabel.rectTransform.position = new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth * 2, Screen.safeArea.yMax - livesLabelHalfHeight * 2);
        //        ScoresLabel.rectTransform.position = new Vector2(Screen.safeArea.xMax - ScoresLabelHalfWidth * 2, Screen.safeArea.yMax - ScoresLabelHalfHeight * 2);
        //        break;
        //
        //    case DeviceOrientation.Unknown:
        //        break;
        //
        //    default:
        //        break;
        //}
    }
}
