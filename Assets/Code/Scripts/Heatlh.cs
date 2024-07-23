using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heatlh : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitPoint = 2;
    [SerializeField] private int currencyWorth = 50;

    private bool isDestroyed = false;

    public void TakeDamage(int dmg)
    {
        hitPoint -= dmg;

        if (hitPoint <= 0 && !isDestroyed)
        {
            EnemySpawner.onEnemyDestroy.Invoke();
            LevelManager.main.IncreaseCurrency(currencyWorth); 
            isDestroyed = true; 
            Destroy (gameObject);
        }
    }
}
