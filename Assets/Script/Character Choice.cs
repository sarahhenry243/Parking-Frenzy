using UnityEngine;

public class CharacterChoice : MonoBehaviour
{
    public GameObject Car;
    public GameObject Character;
    public GameObject Camera;
    public GameObject UI;

    public void CarChoiceFunction()
    {
        Car.SetActive(true);
        Character.SetActive(false);
        Camera.SetActive(false);
        UI.SetActive(false);
    }

    public void CharacterChoiceFunction()
    {
        Car.SetActive(false);
        Character.SetActive(true);
        Camera.SetActive(false);
        UI.SetActive(false);
    }
}
