```mermaid
graph TD
    A(start script)
    B(Vector3 follow mouse variable)
    C(bool that checks if a tower is on the same position, if true then you cant place)
    D(in update let tower follow mousepos)
    E(Make function that instantiates the tower)
    F(If it's not on the same pos then you can place, also can only place on grass)
    A --> B --> E --> D --> C --> F