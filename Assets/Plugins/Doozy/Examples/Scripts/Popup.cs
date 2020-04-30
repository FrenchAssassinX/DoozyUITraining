using Doozy.Engine.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Examples
{
    public class Popup : MonoBehaviour
    {
        public Sprite newImage;
        public GameObject imageGameObject;

        void Start()
        {
            imageGameObject = gameObject.transform.GetChild(1).GetChild(0).gameObject;
            imageGameObject.GetComponent<Image>().sprite = newImage;

            //GameObject.Find("ImageInPopup").GetComponent<Image>().sprite = newImage;
        }
    }
}
