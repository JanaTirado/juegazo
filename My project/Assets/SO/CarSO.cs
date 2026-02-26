using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName="New Car", menuName="Car/NewCar")]
public class CarSO : ScriptableObject
{
    public float speed;
    public float angle;
    public float brake;
    public Sprite carImage;
    public string carName;
    public GameObject carPrefab;
    

 
}
