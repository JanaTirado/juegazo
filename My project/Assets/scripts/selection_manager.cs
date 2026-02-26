using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class selection_manager : MonoBehaviour
{
    [Header("UI")]
    public Image carImage;
    public TextMeshProUGUI carNameText;
    public Scrollbar speedScrollbar;
    public Scrollbar brakeScrollbar;
    public Scrollbar angleScrollbar;

    //[Header("Car")]
    public MainCameraController cam;
    public CarSO[] cars;
    private int index;
    public Transform startPos;
    private CarSO selectedCar;

    private float maxScrollbar = 1000;
    private float maxScrollbarAngle = 60;

    void Start()
    {
        index = 0;
        selectedCar = cars[index];
        UpdateUI();
    }

    public void UpdateUI()
    {
        carImage.sprite = selectedCar.carImage;
        carNameText.text = selectedCar.carName;
        speedScrollbar.size = selectedCar.speed / maxScrollbar;
        brakeScrollbar.size = selectedCar.brake / maxScrollbar;
        angleScrollbar.size = selectedCar.angle / maxScrollbarAngle;
    }

    public void ChangeCar(bool isRight)
    {
        if (isRight)
        {
            index = (index + 1) % cars.Length;
        }
        else
        {
            index = (index - 1 + cars.Length) % cars.Length;
        }
        selectedCar = cars[index];
        UpdateUI();
    }

    public void SelectedCar()
    {
        GameObject prefabSelected = Instantiate(selectedCar.carPrefab, startPos.position, Quaternion.identity); 
        cam.target= prefabSelected.transform;
    }
}
