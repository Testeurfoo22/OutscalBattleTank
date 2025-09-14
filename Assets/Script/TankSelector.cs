using UnityEngine;

namespace Script
{
    public class TankSelector : MonoBehaviour
    {
        [SerializeField] TankSpawners tankSpawners;
        
        public void OnBlueSelect()
        {
            tankSpawners.OnTankSelected(TankTypes.BlueTank);
            CloseUI();
        }
        public void OnRedSelect()
        {
            tankSpawners.OnTankSelected(TankTypes.RedTank);
            CloseUI();
        }
        public void OnGreenSelect()
        {
            tankSpawners.OnTankSelected(TankTypes.GreenTank);
            CloseUI();
        }

        private void CloseUI()
        {
            gameObject.SetActive(false);
        }
    }
}