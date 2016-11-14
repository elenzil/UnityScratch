using UnityEngine;
using UnityEngine.UI;

public class outlineController : MonoBehaviour {

  public Button theButton;
  public Outline theOutline;

  void Start() {
    theButton.onClick.AddListener(onClickTheButton);
  }

  int mode = 0;

  void onClickTheButton() {
    switch (mode) {
      case 0: {
        theOutline.effectColor = Color.white;
        break;
      }
      case 1: {
        theOutline.effectColor = Color.black;
        break;
      }
      case 2: {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        theOutline.effectColor = new Color(r, g, b);
        break;
      }
    }

    mode = (mode + 1) % 3;
  }
}
