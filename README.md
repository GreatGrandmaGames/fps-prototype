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

#### Player Prefab
This contains the entire player object, the movement system, and the gun. The Camera is childed to the Moveable Player object, and all of the PF objects are childed to the Camera. This can all be changed but it works currently. There's also a hitbox with a damageable component on it, and the Ability Manager, which has all of the ability scripts.

#### Persistent Gameplay Prefab
This contains all data necessary to the basic UI - two ability dials and an ammo counter. This is very placeholder and pretty rough (lol can u tell?).

### Installation

I think you should just be able to clone and run the DemoScene... I tried it on my own machine from scratch, and there were a couple null reference exceptions for ability manager that just aren't saved in the AbilityManager prefab, you should just have to drag the abilities into the ability manager to initialize it. 

If there are other issues (like not being able to move / shoot), you may have to initialize some data which is in DemoSceneCore/Data. 

If you make a new scene, the Player object has a Camera in it so if you drop the Player into a scene with another camera you'll have an issue.

This is running Unity 2018.3.0f2. 


