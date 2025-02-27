namespace FoodWeb.API.Database.Entities
{
    public class GroupDetail
    {
        public int IdGroupDetail { get; set; }     

        public bool EnableGroupDetail { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}