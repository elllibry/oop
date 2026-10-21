using UnityEngine;
using UnityEngine.SceneManagement; // Необходимо для загрузки сцен
using TMPro; // Необходимо для работы с TextMeshPro

public class MainMenu : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject settingsPanel; // Ссылка на панель настроек

    // Метод для кнопки "Играть"
    public void PlayGame()
    {
        // ВАЖНО: Замените "Level1" на точное имя вашей сцены из предыдущего задания
        // Убедитесь, что оно написано так же, как в окне Project (с учетом регистра)
        SceneManager.LoadScene("Game");
    }

    // Метод для кнопки "Настройки"
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    // Метод для кнопки "Закрыть" (крестик) внутри настроек
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    // Метод для кнопки "Выход"
    public void ExitGame()
    {
        Debug.Log("Выход из игры..."); // Работает в сборке
        Application.Quit();
    }
}
