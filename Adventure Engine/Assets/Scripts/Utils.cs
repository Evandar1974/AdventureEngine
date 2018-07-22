// raycast layers
public enum Layer
{
    RaycastEndStop = -1,
    Enemy = 9,
    Walkable = 10,
    Usable = 11,
    Pickup = 12
}

//Game manager states
public enum GameStates
{
    MainMenu = 0,
    Game = 1,
    Notes = 2,
    Inventory = 3,
    Pause = 4,
    ReadNote = 5,
    Container = 6,
    ActionsList = 7,
    Death = 8,
    Loading = 9,
    GameComplete = 10,
    PasswordInput = 11
}
