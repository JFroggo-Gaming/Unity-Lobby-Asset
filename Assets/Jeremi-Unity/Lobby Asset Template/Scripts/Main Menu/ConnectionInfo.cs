using UnityEngine;

public class ConnectionInfo : MonoBehaviour
{
// IN THIS SCRIPT: Whenever we lose connection with the lobby, we will be shown a message, that we have been disconnected
// This is based on a two-method subscription(WhenWeAreConnected / WhenWeAreDisconnected)
    [SerializeField] private GameObject EnterAddress = null;
    [SerializeField] private GameObject ExitPanel = null;
    [SerializeField] private GameObject LobbyPanel = null;
    [SerializeField] private GameObject MainMenu = null; 
    [SerializeField] private GameObject DisconnectPanel = null; // This panel becomes visible when someone disconnects from the game

    private void OnEnable()
    {
      WhenWeAreDisconnected();
    }

    private void WhenWeAreDisconnected() // If we have been disconnected, take care of the whole UI and display it in the correct way
    {
        
        DisconnectPanel.SetActive(true);
        LobbyPanel.SetActive(false);
        MainMenu.SetActive(true);


        EnterAddress.SetActive(false);

           if(EnterAddress.activeSelf)
        {
            EnterAddress.SetActive(false);
        }
     
         ExitPanel.SetActive(false);

           if(ExitPanel.activeSelf)
        {
            ExitPanel.SetActive(false);
        }
    
    }
}
