using Doozy.Engine.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Examples
{
    public class GalleryButton : MonoBehaviour
    {
        public GameObject prefabPopup;
        private UIPopup popup;

        public void Show()
        {
            popup = UIPopup.GetPopup(prefabPopup.name);

            if (popup == null)
                return;

            popup.HideOnBackButton = false;
            popup.HideOnClickAnywhere = true;
            popup.HideOnClickOverlay = true;
            popup.HideOnClickContainer = true;

            popup.AutoHideAfterShow = false;

            popup.Show();
        }
    }
}