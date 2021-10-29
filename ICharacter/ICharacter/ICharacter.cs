namespace Interfaces.Smash
{
    public interface ICharacter
    {
        void SetHorizontalDirection(float dx);
        void PerformAttack();
        void StartJump();
    }
    public interface ICharacterController
    {
        void SetCharacter(string ICharacter);
        void Logic(float frametime);
    }
}
