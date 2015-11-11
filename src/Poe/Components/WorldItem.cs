namespace PoeHUD.Poe.Components
{
    public class WorldItem : Component
    {
        public Entity ItemEntity => Address != 0 ? ReadObject<Entity>(Address + 20) : GetObject<Entity>(0);
    }
}