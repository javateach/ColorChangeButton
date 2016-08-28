using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {

    public Image background;

	public void ChangeBackgroundColor()
    {
        background.color = Color.blue;
    }
}
