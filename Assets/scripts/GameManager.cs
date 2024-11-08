using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     private void Start()
    {
        Player player = new Player("Subhi", 80);
        Enemy enemy = new Enemy("Zarifeh", 100);

        Debug.Log($"Player: {player.Name}, Health: {player.Health}");
        Debug.Log($"Enemy: {enemy.Name}, Health: {enemy.Health}");

        player.Heal(10);

        enemy.Attack(player, 15);
    }
}