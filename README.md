# fps-prototype

## Prototype for FPS
This repo has a couple of the GameObjects necessary to make the Parametric Firearm system work with movement, jump ability, and zero G ability.

### Prefabs
In the Prefabs folder contains a couple of fundamental GameObjects for basic movement and abilities in the game. There are canvas prefabs, player prefabs, and only one (at the moment) prefab for a PF gun that shoots 3 projectiles. The intention with the prefabs was to get the basic functionality working so we can start to build other things. 

Prefabs tasklist:
- [x] Player
- [x] UI
- [ ] Enemy
- [ ] Sound Source
- [ ] Door
- [ ] Key
- [ ] Interactive Firearm (one that you can pick up / collect)

- #### Player Prefab
This contains the entire player object, the movement system, and the gun. The Camera is childed to the Moveable Player object, and all of the PF objects are childed to the Camera. This can all be changed but it works currently. There's also a hitbox with a damageable component on it, and the Ability Manager, which has all of the ability scripts.

**Player Prefab Content**

![player prefab](https://user-images.githubusercontent.com/25305809/53062278-4f2f2180-348e-11e9-8a87-4c585f7d66d8.png).



- #### Persistent Gameplay Prefab
This contains all data necessary to the basic UI - two ability dials and an ammo counter. This is very placeholder and pretty rough (lol can u tell?).

![player prefab](https://user-images.githubusercontent.com/25305809/53062287-56eec600-348e-11e9-8124-c5b9cc905bdd.png).
**UI Screenshot**
Checkmark is "Jump" and the dot is "zeroG" ability. Currently, jump has a 5 sec cooldown and zero g has a 5 second active time and a 10 second cooldown.

### Installation

#### GrandmaAssetPackages Submodule
Note that the Folder "GrandmaAssetPackages" is a github submodule. Here's some info on it but if you clone the repo and there are no files in there you might have to pull the repo. 

[Submodule Resource](https://gist.github.com/gitaarik/8735255).
[Submodule Documentation](https://git-scm.com/book/en/v2/Git-Tools-Submodules).

#### Other things
I think you should just be able to clone and run the DemoScene... I tried it on my own machine from scratch, and there were a couple null reference exceptions for ability manager that just aren't saved in the AbilityManager prefab, you should just have to drag the abilities into the ability manager to initialize it. 

If there are other issues (like not being able to move / shoot), you may have to initialize some data which is in DemoSceneCore/Data. 

If you make a new scene, the Player object has a Camera in it so if you drop the Player into a scene with another camera you'll have an issue.

This is running Unity 2018.3.0f2. 


