using UnityEngine;
using UnityEngine.SceneManagement;

namespace BHSCamp.UI
{
    public class OpenFinishMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _finishMenuPanel;
        [SerializeField] private LevelPreviewData _nextLevel;
        [SerializeField] private GameObject _openMenuInGame;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _openMenuInGame.GetComponent<OpenMenuInGame>().CanOpenMenu();
            _finishMenuPanel.SetActive(true);
            Time.timeScale = 0;
        }

        public void Exit()
        {
            SceneManager.LoadScene("Menu");
            Time.timeScale = 1;
        }

        public void Continue()
        {
            SceneManager.LoadScene(_nextLevel.SceneIndex);
        }
    }
}