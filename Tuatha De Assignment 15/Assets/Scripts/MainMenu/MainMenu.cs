using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        public void StartButton()
        {
            SceneManager.LoadScene("Game");
        }

        public void QuitButton()
        {
            Application.Quit();
        }

        public void MenuButton()
        {
        
        }
    }
}