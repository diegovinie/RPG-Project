
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
