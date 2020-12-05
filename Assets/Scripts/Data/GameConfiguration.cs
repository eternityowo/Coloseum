using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AppData
{
    [CreateAssetMenu(fileName = "GameConfiguration", menuName = "AppData/GameConfig", order = 0)]
    public class GameConfiguration : ScriptableObject
    {
        public string enemyBlueprintsPath = "Blueprints/Enemies/";
        public string towerBlueprintsPath = "Blueprints/Towers/";

        [Header("Context Start Settings")] public float timeBetweenWave = 10f;
        public int startGold = 200;
        public int keepHealth = 1000;

        [Header("Camera Settings")] 
        public float CameraSpeed = 10f;
        public int ScreenBorderInPx = 40;
        
        
        public float Player1Speed = 5;
        public float Player2Speed = 5;
    }
}