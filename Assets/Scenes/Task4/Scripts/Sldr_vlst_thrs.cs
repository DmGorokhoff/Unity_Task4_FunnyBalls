using UnityEngine;
using UnityEngine.UI;

public class Sldr_vlst_thrs : MonoBehaviour // Ёлементы управлени€ (слайдеры) скоростью и силой игрового м€ча
{       
    public MovePlayer MovePlayer;
    [SerializeField] private Text txtVelosity;
    [SerializeField] private Text txtThrust;
    public void OnSldrVelosityChanged(float value_velocity)
    {   
        MovePlayer.speed = value_velocity * 100;
        txtVelosity.text = value_velocity.ToString();        
    }
    public void OnSldrThrustChanged(float value_thrust)
    {
        MovePlayer.thrust = value_thrust * 350;
        txtThrust.text = value_thrust.ToString();
    }
}
