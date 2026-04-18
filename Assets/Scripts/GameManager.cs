using UnityEngine;

namespace Gambrawl
{
    /// <summary>
    /// Example game manager script for Gambrawl
    /// This demonstrates the basic project setup and serves as a starting point for game development
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        [Header("Game Settings")]
        [SerializeField] private string gameName = "Gambrawl";
        [SerializeField] private string version = "0.1.0";
        
        private void Awake()
        {
            // Initialize game systems
            Debug.Log($"{gameName} v{version} - Starting...");
            
            // Set target frame rate for mobile
            Application.targetFrameRate = 60;
            
            // Pause the game when app goes to background (standard for mobile games)
            Application.runInBackground = false;
        }
        
        private void Start()
        {
            Debug.Log($"{gameName} - Ready!");
            LogSystemInfo();
        }
        
        private void LogSystemInfo()
        {
            Debug.Log($"Platform: {Application.platform}");
            Debug.Log($"Device: {SystemInfo.deviceModel}");
            Debug.Log($"Graphics: {SystemInfo.graphicsDeviceName}");
            Debug.Log($"Memory: {SystemInfo.systemMemorySize}MB");
        }
    }
}
