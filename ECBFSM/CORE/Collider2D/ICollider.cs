public interface ICollider
{
    public delegate void VerifyColision(EntityCollider other);
    public void CollisionAction(VerifyColision colision);
}