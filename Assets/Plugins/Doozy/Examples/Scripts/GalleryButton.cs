using Doozy.Engine.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Examples
{
    public class GalleryButton : MonoBehaviour
    {
        public GameObject prefabPopup;
        private UIPopup popup;
        public Sprite imageButton;

        void Start()
        {
            imageButton = GetComponent<Image>().sprite;

            if (imageButton == null)
            {
                Debug.Log("Error no image found");
            }
        }

        public void Show()
        {
            popup = UIPopup.GetPopup(prefabPopup.name);

            if (popup == null)
                return;

            popup.GetComponent<Popup>().SetImage(imageButton);

            popup.HideOnBackButton = false;
            popup.HideOnClickAnywhere = true;
            popup.HideOnClickOverlay = true;
            popup.HideOnClickContainer = true;

            popup.AutoHideAfterShow = false;

            popup.Show();
        }
    }
}