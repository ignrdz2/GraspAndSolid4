namespace Full_GRASP_And_SOLID;

public class ProductCreator{
    public static Product CreateProduct(string description, double unitCost){
        Product product = new Product(description, unitCost);

        return product;
    }
}