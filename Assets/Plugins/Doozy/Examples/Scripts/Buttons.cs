using Doozy.Engine.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Doozy.Examples
{
    public class Buttons : MonoBehaviour
    {
        public Sprite[] sprites;
        public GameObject buttonPrefab;

        void Start()
        {
            GenerateButtons();
        }

        void Update()
        {

        }

        void GenerateButtons()
        {
            foreach (Sprite sprite in sprites)
            {
                GameObject button = Instantiate(buttonPrefab, gameObject.transform.position, Quaternion.identity);
                button.transform.SetParent(gameObject.transform);

                //button.GetComponent<RectTransform>().sizeDelta = new Vector2(gameObject.GetComponent<RectTransform>().sizeDelta.x, gameObject.GetComponent<RectTransform>().sizeDelta.y);
                button.GetComponent<RectTransform>().localScale = gameObject.GetComponent<RectTransform>().localScale * 4;

                button.GetComponent<RectTransform>().position = gameObject.transform.position / 2;

                button.GetComponent<Image>().sprite = sprite;
            }
        }
    }
}
