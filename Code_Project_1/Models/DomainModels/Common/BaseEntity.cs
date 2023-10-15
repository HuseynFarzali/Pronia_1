namespace Code_Project_1.Models.DomainModels.Common
{
    public abstract class BaseEntity
    {
        private static int _idCounter = 0;
        public int ID { get; set; }

        public BaseEntity()
        {
            ID = _idCounter++;
        }
    }
}
