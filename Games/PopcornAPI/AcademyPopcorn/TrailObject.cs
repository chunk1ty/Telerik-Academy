namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        static readonly char[,] TrailIBody = new char[,] {{'*'}};
        private int lifetime; 
        public TrailObject(MatrixCoords topLeft, int lifetime = 3 ) : base(topLeft,TrailObject.TrailIBody)
        {
            this.lifetime = lifetime;
        }
        public override void Update()
        {
            this.lifetime--;

            if (this.lifetime <= 0)
            {
                this.IsDestroyed = true;
            }            
        }
    }
}
