```mermaid
graph TD
    A([start script])
    B(Vector3 follow mouse variable)
    D(in update let tower follow mousepos)
    E(Make function that instantiates the tower)
    F(If another tower is not on the same pos then you can place the tower)
    C(Checks if tower is on grass)
    G(if you click left mouse button then it will place)
    H([End])
    A --> B --> E --> D --> C --> F --> D
    F --> G --> H