using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextGenerator : MonoBehaviour
{
    public Text labelText;
    [Header("Загрузить сцену | не обязательный параметр")]
    public string ScaneName;

    // Start is called before the first frame update
    void Start()
    {
        /* Получаем название сцены. В преспективе можно изменять генерируемый текст в зависисости от того, на кокой сцене мы находимся*/
        string lname = SceneManager.GetActiveScene().name;
        print(lname);
        StartCoroutine( ChangeText());
    }

    IEnumerator ChangeText()
    {
        yield return new WaitForSeconds(7);
        labelText.GetComponent<Text>().text = "При каждой новой метаморфозе, вам будет доступно три варианта выбора. Один из них наиболее удачен, другой - " +
            "нейтрален и третий - совсем не подходит клиенту. Используйте свой опыт, чтобы не допускать ошибок и предложить лучший результат. ";
        yield return new WaitForSeconds(7);
        labelText.GetComponent<Text>().text = "Это всего лишь тренировка, но в реальности, если вы ошибётесь более одного раза, то клиент " +
            "останется недоволен, и уровень придётся начинать повторно.";
        yield return new WaitForSeconds(4);

        if (ScaneName != null)
        {
            SceneManager.LoadScene(ScaneName);
        }

    }

    /*  void OnMouseDown()
      {
          GetComponent<Text>().text = "42";
      }*/

    // Update is called once per frame
    void Update()
    {
      /*  if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.KeypadEnter))
        {
            labelText.GetComponent<Text>().text = "42";
        }*/

    }

   
}
