namespace ShopSystem.Data.API
{
    public  interface IProduct
    {
         int Id { get; set; }
         double Price { get; set; }
         Category Category { get; set; }
    }

}
