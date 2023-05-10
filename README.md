
# Multiplayer Lobby Asset

Asset presentation: https://youtu.be/ozUm8ABtvFo     (10.05.2023)

<br><code>1. DESCRIPTION:</code>
<br>--------------------------------------------------------------------------------------------------------------------------------------
<br>This lobby asset uses Mirror asset in version 78.3.0.
<br>Download from: https://assetstore.unity.com/packages/tools/network/mirror-129321https://assetstore.unity.com/packages/tools/network/mirror-129321
<br>
<br>If your Mirror version is different you may need to change the way the functions in "MyNetworkManager.cs" are written(some of them refer to Mirror's functions)
<br>
<br>You will also need Text Mesh Pro downloaded in your project.
<br>Make sure that your build include all scenes used in this asset.
<br>Please, don't forget to leave the review if you like the asseet, thank you!
<br>
-----------------------------------------------------------------------------------------------------------------------------------------<br>

<br>All the scripts in this asset have their own description.
<br>Here are some examples, that may help you adjust this asset for your own project:


<code>1. Some adjustments you can make for your project:</code><br>
1.  If you want to change the names displayed by the players:

    Go to MyNetworkManager script -> line 60 -> you can change the display name here. If you want your players so set up their own names 
   <br> there are two methods already prepared for that in "MyNetworkPlayer" script(line 59 and 69)<br>

2. How to move from lobby scene to your own custom scene:

    Go to MyNetworkManager script -> line 47 -> change "GameScene" to your own Scene<br>

3. How do I define how many players are needed to start the game:

   Go to MyNetworkManager script -> line 45 -> change "3" to number you want to set<br>

4. If you want to change images when players are connected/not connected yet to the lobby:

    Go to Hierarchy -> MainMenu -> Canvas -> LobbyPage -> in inspector change Old Lobby Images(no one is connected) and New Lobby Images(when a player connects)
   <br> If you want to change the script, go to LobbyMenu script -> line 41

5. How do I change lobby address from "localhost" to my own?

   Go to Hierarchy -> NetworkManager -> Inspector -> NetworkAddress: localhost -> change that line to your own custom address<br>
                                  
<code>2. If you have any issues with the asset: </code>     <br><br>
If for some reason you are having issues with this asset:

1. Make sure your Mirror version matches the version from the description.

2. Make sure you are using TMP in your project.

3. Make sure your build settings are correct and the resolution does not interfere with the display of UI elements

4. Make sure that you type "localhost" using lowercase letters.

5. Your build have to include two scenes: one with the lobby and one with the example scene


