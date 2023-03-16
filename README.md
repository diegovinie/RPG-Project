
## Notes

### Ep 01

- Download assets https://devassets.com/assets/rpg-tutorial-assets/ and import unit package


- Change **colorset** from gamma to linear, *Project Settings > Player > Other Settings > Color Space*
- 
- Enable **pivot** to see the origin at the bottom

- Player
  - Add capsule collider
  - Add Rigidbody: Enable is Kinematic to make it works with the 
  - Add Nav Mesh Agent: this allows player movements
    - To set the walkable space:
      - Add Navigation window
      - To see the walkable areas *Navgation > Bake > Bake button*
      - Object marked as static: *Navigation > Object > Navigation Area*
      - Nav Mesh Obstacle and check carv to create an unwalkable area that updates in RT
  
- Raycasting: Add new layer called Ground

- New concepts
  - UnityEngine.AI, NavMeshAgent
  - RaycastHit, Ray, Physics.Raycast(), LayerMask
  - Camera concepts:
    - zoom
    - yaw
    - pitch

- To change the fog: 
    ![image](notes/images/ep01-1.png)

- Hints
  - In play mode copy component values and paste them after in edit mode

### Ep 02
TODO

### Ep 03

#### Importing the avatar
  - Error importing the animation clips [check this issue](https://issuetracker.unity3d.com/issues/using-multiple-animation-clips-in-blender-not-all-animation-clips-are-imported-using-a-blend-file) 
  - Recommended is to open the blender file and export to fbx
  - Select T-pose, Apply and Done 
  ![image](notes/images/ep03-02.png)
  - COnfigure the animations
  ![image](notes/images/ep03-03.png)


#### Setup animations in player

  - Create a new Animation (delete de PlayerAnimator)

  - In the *Player graphic* add an *Animator* component, and uncheck *Apply Root Motion*
  ![image](notes/images/ep03-04.png)

  - Create new blend tree
  ![image](notes/images/ep03-01.png)

  - In *Animator Controller* (called Player Graphic), open it, create a new *Blend Tree* and call it Locomotion, double click to enter in it
  ![image](notes/images/ep03-05.png)


  - Add the 3 animations in the *Blend Tree*
  ![image](notes/images/ep03-06.png)

  - The blend *parameter* rename it to *speedPercent*
  
### Ep 04

- heritance `ItemPickup : Interactable`
- For avoid error, check if *interactionTramsform* is null
- Instead of using json for data driven objects, use `Item : ScriptableObject`
- For override properties use **new**
- `[CreateAssetMenu()]` for creating a menu entry
  ![image](notes/images/ep04-01.png)

### Ep 05

#### Import sprites
![image](notes/images/ep05-001.png)

#### Fix sprite borders
- Install sprites 2D
![image](notes/images/ep05-002.png)
- Mark borders
![image](notes/images/ep05-003.png)
- Change image type in the consumer
![image](notes/images/ep05-004.png)


![image](notes/images/ep05-005.png)

#### Make the inventory to scale
![image](notes/images/ep05-006.png)

#### Final setup
- delete the placeholder
- Disable the image
- Make close button non interactable
- change the disabled alpha


### Ep 06

- Useful methods:
`slots = itemsParent.GetComponentsInChildren<InventorySlot>();`

- avoiding moving the player when interacting with inventory.
```
using UnityEngine.EventSystems;

EventSystem.current.IsPointerOverGameObject()
```
- Add new buttons
`Input.GetButtonDown("Inventory")`
![image](notes/images/ep06-001.png)


