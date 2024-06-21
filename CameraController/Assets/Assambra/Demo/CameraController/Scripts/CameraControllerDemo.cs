using UnityEngine;

namespace Assambra.GameFramework.CameraController.Demo
{
    public class CameraControllerDemo : MonoBehaviour
    {
        [SerializeField] private CameraController cameraController;

        void Start()
        {
            cameraController.ChangeCameraPreset("PreGameCamera");
        }

        void Update()
        {

        }

        public void OnButtonChangePreset()
        {
            cameraController.ChangeCameraPreset("GameCamera");
            Debug.Log("Camera Preset changed to: GameCamera");
        }
    }
}

