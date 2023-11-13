using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gameplay
{
    public class ControleGeral: MonoBehaviour
    {
        public GameObject textoSaude;
        public GameObject textoMoedas;
        private int _moedas; 
        
        
        void Update()
        {
            textoSaude.GetComponent<TextMeshProUGUI>().text = $"Saúde {GetComponent<HealthController>().health}";
        }
        
        public void AddMoeda()
        {
            textoMoedas.GetComponent<TextMeshProUGUI>().text = $"Moedas {++_moedas}";
        }

        public void JogarNovamente()
        {
            SceneManager.LoadScene("Jogo");
        }
        
        public void Sair()
        {
            Application.Quit();
        }
    }
}